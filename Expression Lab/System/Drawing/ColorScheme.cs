namespace System.Drawing
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    public class ColorScheme : Dictionary<string, Color>, IXmlSerializable
    {

        #region Methods

        [XmlIgnore]
        public string[] ColorNames
        {
            get
            {
                int i = 0;
                string[] names = new string[this.Keys.Count];
                foreach (string key in this.Keys)
                {
                    names[i] = key;
                    i++;
                }

                return names;
            }
        }

        #endregion

        #region XML Serialization

        public Xml.Schema.XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(Xml.XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.Name == "Color")
                {
                    var key = reader.GetAttribute("Name");
                    var val = reader.GetAttribute("Value");
                    var color = ColorTranslator.FromHtml(val);

                    if (this.ContainsKey(key))
                        this[key] = color;

                    else
                        this.Add(key, color);
                }
            }
        }

        public void WriteXml(Xml.XmlWriter writer)
        {
            foreach (var key in this.Keys)
            {
                writer.WriteStartElement("Color");
                writer.WriteAttributeString("Name", key);
                writer.WriteAttributeString("Value", ColorTranslator.ToHtml(this[key]));
                writer.WriteEndElement();
            }
        }

        #endregion
    }
}
