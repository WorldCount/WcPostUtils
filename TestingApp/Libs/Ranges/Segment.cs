using System.Xml.Serialization;

namespace TestingApp.Libs.Ranges
{
    [XmlRoot("Segment", Namespace = "http://russianpost.org")]
    public class Segment
    {
        private string _mailTypePref;
        private int _numMonth;

        [XmlAttributeAttribute("NumMonth")]
        public int NumMonth { 
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
        public State State { get; set; }

        [XmlAttributeAttribute("State")]
        public int StateNum
        {
            get => (int) State;
            set => State = (State) value;
        }

        [XmlAttributeAttribute("MailTypePref")]
        public string MailTypePref {
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
                    case State.Free:
                        return "Свободен";

                    case State.Busy:
                        return "Использован";

                    case State.Used:
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
