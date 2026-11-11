using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace gvcpTool.Configuration
{
    public sealed class GvcpParameterValue
    {
        public string Name { get; set; }
        public uint Value { get; set; }
    }

    public static class GvcpParameterFile
    {
        public static void Save(string path, IEnumerable<GvcpParameterValue> parameters)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException("path");
            if (parameters == null)
                throw new ArgumentNullException("parameters");

            XDocument document = new XDocument(
                new XDeclaration("1.0", "utf-8", null),
                new XElement("gvcpParameters",
                    new XAttribute("version", "1"),
                    parameters.Select(parameter => new XElement("parameter",
                        new XAttribute("name", parameter.Name),
                        new XAttribute("value", parameter.Value.ToString(CultureInfo.InvariantCulture))))));
            document.Save(path);
        }

        public static Dictionary<string, uint> Load(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException("path");

            XDocument document = XDocument.Load(path);
            if (document.Root == null || document.Root.Name != "gvcpParameters")
                throw new InvalidDataException("The selected file is not a GVCP parameter file.");

            Dictionary<string, uint> values = new Dictionary<string, uint>(StringComparer.OrdinalIgnoreCase);
            foreach (XElement element in document.Root.Elements("parameter"))
            {
                string name = (string)element.Attribute("name");
                string text = (string)element.Attribute("value");
                uint value;
                if (string.IsNullOrWhiteSpace(name))
                    throw new InvalidDataException("A parameter is missing its register name.");
                if (!uint.TryParse(text, NumberStyles.None, CultureInfo.InvariantCulture, out value))
                    throw new InvalidDataException("Parameter " + name + " must contain an unsigned decimal value.");
                if (values.ContainsKey(name))
                    throw new InvalidDataException("Duplicate parameter name: " + name);
                values.Add(name, value);
            }

            if (values.Count == 0)
                throw new InvalidDataException("The parameter file does not contain any parameters.");
            return values;
        }
    }
}
