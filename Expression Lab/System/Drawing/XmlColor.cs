using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace System.Drawing
{
    public class XmlColor : IXmlSerializable
    {
        #region Constructors

        public XmlColor() { }

        public XmlColor(Color color)
        {
            this._color = color;
        }

        #endregion

        #region Fields

        private Color _color;

        public Color Color
        {
            get { return _color; }
        }

        #endregion

        #region Convertors

        public static implicit operator Color(XmlColor color)
        {
            return color._color;
        }

        public static implicit operator XmlColor(Color color)
        {
            return new XmlColor(color);
        }

        #endregion

        #region Serialization

        public Xml.Schema.XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(Xml.XmlReader reader)
        {
            _color = ColorTranslator.FromHtml(reader.ReadString());
        }

        public void WriteXml(Xml.XmlWriter writer)
        {
            writer.WriteString(ColorTranslator.ToHtml(_color));
        }

        #endregion
    }
}
