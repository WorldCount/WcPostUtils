using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;
using WcApi.Cryptography;

namespace WcApi.Post.Ranges
{
    /// <summary>
    /// Диапазон ШПИ
    /// </summary>
    public class Range
    {
        private readonly XNamespace _xsi = "http://www.w3.org/2001/XMLSchema-instance";
        private readonly XNamespace _ns = "http://russianpost.org";
        private readonly XNamespace _schemaLocation = "http://russianpost.org range.xsd";

        // ИНН организации
        public string Inn { get; set; }
        // Номер ОПС
        public int IndexFrom { get; set; }
        // Дата выделения диапазона
        public DateTime DateInfo { get; set; } = DateTime.Now;

        // Список сегментов с номерами ШПИ
        // ReSharper disable once FieldCanBeMadeReadOnly.Local
        private List<Segment> _segments = new List<Segment>();

        public List<Segment> Segments => _segments;

        /// <summary>
        /// Добавить сегмент
        /// </summary>
        /// <param name="segment">Сегмент</param>
        public void AddSegment(Segment segment)
        {
            _segments.Add(segment);
        }

        /// <summary>
        /// Удалить сегмент
        /// </summary>
        /// <param name="segment">Сегмент</param>
        public void RemoveSegment(Segment segment)
        {
            _segments.Remove(segment);
        }

        // Возвращает имя файла диапазона с расширением
        public string GetFileName()
        {
            string inn = $"{Inn.PadLeft(12, '0')}";
            string date = DateInfo.ToString("yyyyMMddHHmmss");
            return $"{inn}_{IndexFrom}_{date}.xml";
        }

        // Возвращает защитный CRC32 код
        private string GetCrc(string data)
        {
            return CRC32.Crc32OfString(data).ToUpper();
        }

        // Переводит все сегменты в строку
        private string GetSegmentString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Segment segment in _segments)
            {
                sb.Append(segment);
            }

            return sb.ToString();
        }

        /// <summary>
        /// Сохраняет диапазон в папку
        /// </summary>
        /// <param name="path">Путь к папке</param>
        public void Save(string path = null)
        {

            StringBuilder sb = new StringBuilder();

            XDocument xDocument = new XDocument {Declaration = new XDeclaration("1.0", "UTF-8", "1")};

            XElement xRange = new XElement(_ns + "Range");

            XAttribute xInn = new XAttribute("Inn", Inn);
            sb.Append(Inn);

            XAttribute xIndexFrom = new XAttribute("IndexFrom", IndexFrom);
            sb.Append(IndexFrom);

            string dateInfo = DateInfo.ToString("dd.MM.yyyy HH:mm:ss");
            XAttribute xDateInfo = new XAttribute("DateInfo", dateInfo);
            sb.Append(dateInfo);
            sb.Append(GetSegmentString());

            XAttribute xCrc = new XAttribute("CRC", GetCrc(sb.ToString()));

            xRange.Add(new XAttribute(XNamespace.Xmlns + "xsi", _xsi));
            xRange.Add(new XAttribute(XNamespace.Xmlns + "ns", _ns));
            xRange.Add(new XAttribute(XNamespace.Xmlns + "schemaLocation", _schemaLocation));

            xRange.Add(xInn);
            xRange.Add(xIndexFrom);
            xRange.Add(xDateInfo);
            xRange.Add(xCrc);

            foreach (Segment segment in _segments)
            {
                xRange.Add(segment.ToXmlElement(_ns));
            }

            xDocument.Add(xRange);
            string fileName = GetFileName();
            if (path != null)
            {
                xDocument.Save(Path.Combine(path, fileName));
                return;
            }
            xDocument.Save(fileName);
        }      
    }
}
