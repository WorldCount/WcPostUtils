﻿using PartStat.Core.Models.PostTypes;

namespace PartStat.Core.Models.Tarifs
{
    public class InterMailTarif
    {
        public string Name { get; set; } = "Письмо Мжд";
        public TransType TransType { get; set; }
        public double Rate { get; set; }
        public int StartMass { get; set; }
        public int EndMass { get; set; }


        public int Type { get; set; } = 2;
        public int Category { get; set; } = 1;
        public int CodeCountry { get; set; } = 0;

        public string Mass => $"{EndMass}";
    }
}
