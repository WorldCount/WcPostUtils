
using System;

namespace LK.Core.Models.Reports
{
    public class OperStatInfo
    {
        public string OperFullName { get; set; }
        public string OperLastName { get; set; }
        public string OperFirstName { get; set; }
        public string OperMiddleName { get; set; }

        public int FirmCount { get; set; }
        public int ListCount { get; set; }
        public int RpoCount { get; set; }
        public int ScanCount { get; set; }

        public double ScanPercent => Math.Round(((double)ScanCount / RpoCount) * 100, 0);

        public string ShortName
        {
            get
            {
                if (!string.IsNullOrEmpty(OperFirstName) && !string.IsNullOrEmpty(OperLastName))
                    return $"{OperLastName} {OperFirstName[0]}. {OperMiddleName[0]}.";
                return OperLastName;
            }
        }
    }
}
