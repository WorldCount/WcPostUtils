using System.Xml.Linq;

namespace WcApi.Post.Ranges
{
    /// <summary>
    /// Часть диапазона
    /// </summary>
    public class Segment
    {
        // Номер месяца
        public int NumMonth { get; set; }
        // Начальный номер
        public int NumBeg { get; set; }
        // Конечный номер
        public int NumEnd { get; set; }
        // Статус диапазона
        public StateRange State { get; set; }
        // Вид международного отправления
        public string MailTypePref { get; set; } = "RA";

        public int Count => NumEnd - NumBeg + 1;

        public string InterInfo
        {
            get
            {
                if (NumEnd > 99999 || NumBeg > 99999)
                    return MailTypePref.ToString();
                return "Нет";
            }
        }

        public string StateInfo
        {
            get
            {
                switch (State)
                {
                    case StateRange.Free:
                        return "Свободен";
                        
                    case StateRange.Busy:
                        return "Использован";
                       
                    case StateRange.Used:
                        return "Занят";
                        
                    default:
                        return "Неверный";
                }
            }
        }

        public int MonthInfo => Month.GetMonthBarcode(NumMonth);

        /// <summary>
        /// Преобразует объект Segment в Xml элемент
        /// </summary>
        /// <param name="ns">Название области</param>
        /// <returns>Xml элемент</returns>
        public XElement ToXmlElement(XNamespace ns)
        {
            XElement xSegment = new XElement(ns + "Segment");

            XAttribute xMailTypePref = new XAttribute("MailTypePref", MailTypePref);
            XAttribute xNumMonth = new XAttribute("NumMonth", NumMonth);
            XAttribute xNumBeg = new XAttribute("NumBeg", NumBeg);
            XAttribute xNumEnd = new XAttribute("NumEnd", NumEnd);
            XAttribute xState = new XAttribute("State", (int)State);

            xSegment.Add(NumBeg > 99999 ? xMailTypePref : xNumMonth);
            xSegment.Add(xNumBeg);
            xSegment.Add(xNumEnd);
            xSegment.Add(xState);

            return xSegment;
        }

        /// <summary>
        /// Преобразует объект Segment в строку
        /// </summary>
        /// <returns>Строка</returns>
        public override string ToString()
        {
            if (NumBeg > 99999)
                return $"0{NumBeg}{NumEnd}{(int)State}";
            return $"{NumMonth}{NumBeg}{NumEnd}{(int)State}";
        }
    }
}
