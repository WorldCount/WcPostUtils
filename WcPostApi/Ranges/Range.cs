using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WcPostApi.Ranges
{
    /// <summary>
    /// Диапазон ШПИ
    /// </summary>
    [XmlRoot("Range", Namespace = "http://russianpost.org")]
    public class Range
    {
        private string _crc;

        [XmlAttributeAttribute("schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string XsiSchemaLocation = "http://russianpost.org range.xsd";

        [XmlNamespaceDeclarationsAttribute]
        public XmlSerializerNamespaces Namespaces = new XmlSerializerNamespaces();

        [XmlAttributeAttribute("Inn")]
        public string Inn { get; set; }

        // Номер ОПС
        [XmlAttributeAttribute("IndexFrom")]
        public int IndexFrom { get; set; }

        // Дата выделения диапазона
        [XmlIgnore]
        public DateTime Date { get; set; } = DateTime.Now;

        [XmlAttributeAttribute("DateInfo")]
        public string DateInfo
        {
            get => Date.ToString("dd.MM.yyyy HH:mm:ss");
            set => Date = DateTime.Parse(value);
        }

        [XmlAttributeAttribute("CRC")]
        public string Crc
        {
            get
            {
                string s = $"{Inn}{IndexFrom}{DateInfo}{GetSegmentString()}";
                return CRC32.Crc32OfString(s).ToUpper();
            }
            set => _crc = value;
        }

        [XmlElement("Segment")]
        public List<Segment> Segments = new List<Segment>();

        public Range()
        {
            Namespaces.Add("ns", "http://russianpost.org");
        }

        public string GetFileName()
        {
            string inn = $"{Inn.PadLeft(12, '0')}";
            string date = Date.ToString("yyyyMMddHHmmss");
            return $"{inn}_{IndexFrom}_{date}.xml";
        }

        private string GetSegmentString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Segment segment in Segments)
            {
                sb.Append(segment);
            }

            return sb.ToString();
        }
    }
}
