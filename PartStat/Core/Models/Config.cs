using System;
using System.Globalization;

namespace PartStat.Core.Models
{
    public enum ConfigName
    {
        Nds,
        Value,
        Step,
        MailStartWeight,
        MailEndWeight,
        ParcelStartWeight,
        ParcelEndWeight,
        LastLoadReportDate
    }

    public class Config
    {
        public ConfigName Name { get; set; }
        public string Value { get; set; }

        public Config() { }

        public Config(ConfigName name, string value = null)
        {
            Name = name;
            Value = value;
        }

        public int GetIntValue()
        {
            try
            {
                return int.Parse(Value);
            }
            catch
            {
                return 0;
            }
        }

        public DateTime GetDateTimeValue()
        {
            try
            {
                return DateTime.Parse(Value, CultureInfo.InvariantCulture);
            }
            catch
            { 
                return DateTime.Today;
            }
        }
    }
}
