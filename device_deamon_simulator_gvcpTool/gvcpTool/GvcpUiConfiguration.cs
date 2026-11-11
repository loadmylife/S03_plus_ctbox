using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Xml;
using gvcpTool.Protocol;

namespace gvcpTool.Configuration
{
    public sealed class GvcpUiConfiguration
    {
        public const int RegisterCount = 71;
        private readonly XmlDocument _document = new XmlDocument();

        public GvcpUiConfiguration(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException("path");
            _document.Load(path);
        }

        public XmlNode Root { get { return _document.DocumentElement; } }

        public uint ReadAddress(string registerName)
        {
            return ParseHex(GetValue(registerName, "reg_addr"));
        }

        public uint ReadDefaultValue(string registerName)
        {
            return ParseDecimal(GetValue(registerName, "reg_data"));
        }

        public string ReadRegisterName(string registerName)
        {
            return GetValue(registerName, "reg_name");
        }

        public List<GvcpRegisterOperation> CreateRegisterOperations(uint[,] payload)
        {
            if (payload == null || payload.GetLength(0) < RegisterCount || payload.GetLength(1) < 2)
                throw new ArgumentException("The configuration payload must contain 71 address/data pairs.", "payload");

            List<GvcpRegisterOperation> operations = new List<GvcpRegisterOperation>(RegisterCount);
            for (int i = 0; i < RegisterCount; i++)
            {
                operations.Add(new GvcpRegisterOperation
                {
                    Address = payload[i, 0],
                    Data = payload[i, 1]
                });
            }
            return operations;
        }

        public static uint ParseHex(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return 0;
            string text = value.Trim();
            if (text.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
                text = text.Substring(2);
            return Convert.ToUInt32(text, 16);
        }

        public static uint ParseDecimal(string value)
        {
            uint result;
            return uint.TryParse(value, out result) ? result : ParseHex(value);
        }

        public static uint ParseUnsignedDecimal(string value)
        {
            uint result;
            if (string.IsNullOrWhiteSpace(value) ||
                !uint.TryParse(value.Trim(), NumberStyles.None, CultureInfo.InvariantCulture, out result))
                throw new FormatException("Register data must be an unsigned decimal value from 0 to 4294967295.");
            return result;
        }

        private string GetValue(string registerName, string childName)
        {
            XmlNode node = Root.SelectSingleNode(registerName + "/" + childName);
            if (node == null)
                throw new InvalidDataException("Missing configuration node: " + registerName + "/" + childName);
            return node.InnerText.Trim();
        }
    }

}
