using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace gvcpTool.Protocol
{
    public sealed class GvcpStatusMessage
    {
        public ushort RequestId { get; internal set; }
        public ushort EventIdentifier { get; internal set; }
        public ushort StreamChannelIndex { get; internal set; }
        public ushort BlockId { get; internal set; }
        public ulong Timestamp { get; internal set; }
        public IReadOnlyDictionary<uint, uint> Registers { get; internal set; }

        public bool TryGetSignedValue(uint address, out int value)
        {
            uint rawValue;
            if (Registers != null && Registers.TryGetValue(address, out rawValue))
            {
                value = unchecked((int)rawValue);
                return true;
            }

            value = 0;
            return false;
        }
    }

    public sealed class GvcpStatusProtocolProcessor : IDisposable
    {
        public const ushort EventDataCommand = 0x00C2;
        public const int EventHeaderLength = 16;
        public const int DefaultRealtimeStatusPort = 3958;
        public const int DefaultPeriodicStatusPort = 3959;
        public const uint GantryPositionAddress = 0x0004A07C;
        public const uint GantryVelocityAddress = 0x0004A070;
        public const uint CoachAbsolutePositionAddress = 0x0005A008;

        private static readonly HashSet<uint> PeriodicStatusAddresses = new HashSet<uint>
        {
            GantryPositionAddress, GantryVelocityAddress, CoachAbsolutePositionAddress, 0x0005A020,
            0x0005A010, 0x0005A00C, 0x0005A014, 0x0005A01C, 0x0001A000,
            0x0002A000, 0x0003A000, 0x0004A000, 0x0005A000, 0x0006A000,
            0x0007A000, 0x0008A000, 0x0009A000, 0x000AA000, 0x000BA000,
            0x000CA000, 0x000DA000, 0x000EA000, 0x000CA028, 0x000CA02C,
            0x000CA038, 0x0002A12C, 0x0006A1FC, 0x0006A200, 0x0006A204,
            0x0006A208, 0x0007A1FC, 0x0007A200, 0x0007A204, 0x0007A208,
            0x0008A1FC, 0x0008A200, 0x0008A204, 0x0008A208, 0x0009A1FC,
            0x0009A200, 0x0009A204, 0x0009A208, 0x000AA1FC, 0x000AA200,
            0x000AA204, 0x000AA208, 0x000BA1FC, 0x000BA200, 0x000BA204,
            0x000BA208, 0x000CA0E4, 0x000CA0F4, 0x000CA100, 0x000CA10C,
            0x000CA118, 0x0003A098, 0x0005A094
        };

        private static readonly HashSet<uint> RealtimeStatusAddresses = new HashSet<uint>
        {
            0x0000A000, 0x0000A004, 0x0000A13C, 0x0000A140, 0x0000A144,
            0x0000A148, GantryPositionAddress, CoachAbsolutePositionAddress, 0x0005A020,
            0x0005A010, 0x0000A114, 0x0000A118, 0x0000A11C, 0x0000A120,
            0x0001A0BC, 0x0001A000, 0x0000A064, 0x0001A0EC, 0x0002A0C4,
            0x0002A13C, 0x0000A164, 0x0000A168, 0x0001A194, 0x0001A18C,
            0x0001A190
        };

        private readonly UdpClient _realtimeSocket;
        private readonly UdpClient _periodicSocket;
        private readonly Thread _realtimeThread;
        private readonly Thread _periodicThread;
        private volatile bool _running;

        public GvcpStatusProtocolProcessor(
            int realtimeStatusPort = DefaultRealtimeStatusPort,
            int periodicStatusPort = DefaultPeriodicStatusPort)
        {
            ValidatePort(realtimeStatusPort, "realtimeStatusPort");
            ValidatePort(periodicStatusPort, "periodicStatusPort");
            if (realtimeStatusPort == periodicStatusPort)
                throw new ArgumentException("Realtime and periodic status ports must be different.");

            _realtimeSocket = new UdpClient(new IPEndPoint(IPAddress.Any, realtimeStatusPort));
            _periodicSocket = new UdpClient(new IPEndPoint(IPAddress.Any, periodicStatusPort));
            RealtimeStatusPort = realtimeStatusPort;
            PeriodicStatusPort = periodicStatusPort;
            _running = true;
            _realtimeThread = new Thread(RealtimeReceiveLoop)
            {
                IsBackground = true,
                Name = "GVCP_Realtime_Status_Thread"
            };
            _periodicThread = new Thread(PeriodicReceiveLoop)
            {
                IsBackground = true,
                Name = "GVCP_Periodic_Status_Thread"
            };
            _realtimeThread.Start();
            _periodicThread.Start();
        }

        public int RealtimeStatusPort { get; private set; }
        public int PeriodicStatusPort { get; private set; }
        public event Action<GvcpStatusMessage> PeriodicStatusReceived;
        public event Action<GvcpStatusMessage> RealtimeStatusReceived;

        public static bool IsEventDataFrame(byte[] frame)
        {
            return frame != null && frame.Length >= GvcpClient.HeaderLength &&
                   ReadUInt16(frame, 2) == EventDataCommand;
        }

        public static bool TryParsePeriodic(byte[] frame, out GvcpStatusMessage message)
        {
            return TryParse(frame, PeriodicStatusAddresses, out message);
        }

        public static bool TryParseRealtime(byte[] frame, out GvcpStatusMessage message)
        {
            return TryParse(frame, RealtimeStatusAddresses, out message);
        }

        public void Dispose()
        {
            _running = false;
            try { _realtimeSocket.Close(); } catch (SocketException) { }
            try { _periodicSocket.Close(); } catch (SocketException) { }
            if (_realtimeThread != null && _realtimeThread.IsAlive) _realtimeThread.Join(1000);
            if (_periodicThread != null && _periodicThread.IsAlive) _periodicThread.Join(1000);
        }

        private void RealtimeReceiveLoop()
        {
            ReceiveLoop(_realtimeSocket, RealtimeStatusAddresses, message =>
            {
                Action<GvcpStatusMessage> handler = RealtimeStatusReceived;
                if (handler != null) handler(message);
            });
        }

        private void PeriodicReceiveLoop()
        {
            ReceiveLoop(_periodicSocket, PeriodicStatusAddresses, message =>
            {
                Action<GvcpStatusMessage> handler = PeriodicStatusReceived;
                if (handler != null) handler(message);
            });
        }

        private void ReceiveLoop(UdpClient socket, ISet<uint> addresses, Action<GvcpStatusMessage> publish)
        {
            while (_running)
            {
                try
                {
                    IPEndPoint source = new IPEndPoint(IPAddress.Any, 0);
                    byte[] frame = socket.Receive(ref source);
                    GvcpStatusMessage message;
                    if (TryParse(frame, addresses, out message)) publish(message);
                }
                catch (ObjectDisposedException) { if (_running) break; }
                catch (SocketException) { if (!_running) break; }
            }
        }

        private static bool TryParse(byte[] frame, ISet<uint> acceptedAddresses, out GvcpStatusMessage message)
        {
            message = null;
            if (!IsEventDataFrame(frame) || acceptedAddresses == null)
                return false;

            int payloadLength = ReadUInt16(frame, 4);
            int registerBytes = payloadLength - EventHeaderLength;
            int expectedLength = GvcpClient.HeaderLength + payloadLength;
            if (registerBytes < 0 || registerBytes % 8 != 0 || frame.Length < expectedLength)
                return false;

            int eventOffset = GvcpClient.HeaderLength;
            Dictionary<uint, uint> registers = new Dictionary<uint, uint>();
            for (int offset = eventOffset + EventHeaderLength; offset + 7 < expectedLength; offset += 8)
            {
                uint address = ReadUInt32(frame, offset);
                if (acceptedAddresses.Contains(address)) registers[address] = ReadUInt32(frame, offset + 4);
            }
            if (registers.Count == 0) return false;

            message = new GvcpStatusMessage
            {
                RequestId = ReadUInt16(frame, 6),
                EventIdentifier = ReadUInt16(frame, eventOffset + 2),
                StreamChannelIndex = ReadUInt16(frame, eventOffset + 4),
                BlockId = ReadUInt16(frame, eventOffset + 6),
                Timestamp = ((ulong)ReadUInt32(frame, eventOffset + 8) << 32) | ReadUInt32(frame, eventOffset + 12),
                Registers = registers
            };
            return true;
        }

        private static void ValidatePort(int port, string name)
        {
            if (port < IPEndPoint.MinPort || port > IPEndPoint.MaxPort)
                throw new ArgumentOutOfRangeException(name);
        }

        private static ushort ReadUInt16(byte[] buffer, int offset)
        {
            return (ushort)((buffer[offset] << 8) | buffer[offset + 1]);
        }

        private static uint ReadUInt32(byte[] buffer, int offset)
        {
            return ((uint)buffer[offset] << 24) | ((uint)buffer[offset + 1] << 16) |
                   ((uint)buffer[offset + 2] << 8) | buffer[offset + 3];
        }
    }
}
