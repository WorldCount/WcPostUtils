using System.Xml.Serialization;

namespace WcPostApi.Ranges
{
    /// <summary>
    /// Часть диапазона
    /// </summary>
    [XmlRoot("Segment", Namespace = "http://russianpost.org")]
    public class Segment
    {
        private string _mailTypePref;
        private int _numMonth;

        [XmlAttributeAttribute("NumMonth")]
        public int NumMonth
        {
            get => _numMonth;
            set
            {
                if (value != 0)
                    MailTypePref = "";
                _numMonth = value;
            }
        }

        [XmlIgnore]
        public bool NumMonthSpecified => NumMonth != 0;

        [XmlAttributeAttribute("NumBeg")]
        public int NumBeg { get; set; }

        [XmlAttributeAttribute("NumEnd")]
        public int NumEnd { get; set; }

        [XmlIgnore]
        public StateRange State { get; set; }

        [XmlAttributeAttribute("State")]
        public int StateNum
        {
            get => (int) State;
            set => State = (StateRange) value;
        }

        [XmlAttributeAttribute("MailTypePref")]
        public string MailTypePref
        {
            get => _mailTypePref;
            set
            {
                if (!string.IsNullOrEmpty(value))
                    NumMonth = 0;
                _mailTypePref = value;
            }
        }

        [XmlIgnore]
        public bool MailTypePrefSpecified => !string.IsNullOrEmpty(MailTypePref);

        [XmlIgnore]
        public int Count => NumEnd - NumBeg + 1;

        [XmlIgnore]
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

        public override string ToString()
        {
            if (NumBeg > 99999)
                return $"0{NumBeg}{NumEnd}{(int)State}";
            return $"{NumMonth}{NumBeg}{NumEnd}{(int)State}";
        }
    }
}
