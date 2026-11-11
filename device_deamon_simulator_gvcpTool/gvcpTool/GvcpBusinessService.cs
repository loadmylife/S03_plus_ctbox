using System;
using System.Collections.Generic;
using System.Net;
using gvcpTool.Protocol;

namespace gvcpTool.Business
{
    public sealed class GvcpBusinessService : IDisposable
    {
        private readonly GvcpClient _client;

        public GvcpBusinessService(
            IPEndPoint endpoint,
            int realtimeStatusPort = GvcpStatusProtocolProcessor.DefaultRealtimeStatusPort,
            int periodicStatusPort = GvcpStatusProtocolProcessor.DefaultPeriodicStatusPort)
        {
            _client = new GvcpClient(endpoint, realtimeStatusPort, periodicStatusPort);
        }

        public event Action<string> Log
        {
            add { _client.Log += value; }
            remove { _client.Log -= value; }
        }

        public event Action<GvcpResponse> ResponseReceived
        {
            add { _client.ResponseReceived += value; }
            remove { _client.ResponseReceived -= value; }
        }

        public event Action<GvcpStatusMessage> PeriodicStatusReceived
        {
            add { _client.PeriodicStatusReceived += value; }
            remove { _client.PeriodicStatusReceived -= value; }
        }

        public event Action<GvcpStatusMessage> RealtimeStatusReceived
        {
            add { _client.RealtimeStatusReceived += value; }
            remove { _client.RealtimeStatusReceived -= value; }
        }

        public IPEndPoint RemoteEndPoint
        {
            get { return _client.RemoteEndPoint; }
            set { _client.RemoteEndPoint = value; }
        }

        public void StartHeartbeat()
        {
            _client.StartHeartbeat();
        }

        public void StopHeartbeat()
        {
            _client.StopHeartbeat();
        }

        public ushort ReadRegister(uint address)
        {
            return _client.ReadRegister(address);
        }

        public ushort WriteRegister(uint address, uint data, string operation)
        {
            return _client.WriteRegister(address, data, operation);
        }

        public ushort WriteRegisters(IList<GvcpRegisterOperation> registers, string operation)
        {
            return _client.WriteRegisters(registers, operation);
        }

        public void Dispose()
        {
            _client.Dispose();
        }
    }
}
