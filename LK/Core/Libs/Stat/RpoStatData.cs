using LK.Core.Libs.TarifManager.PostTypes;

namespace LK.Core.Libs.Stat
{
    public class RpoStatData
    {
        public string Mass { get; set; } = "0";
        public double Rate { get; set; }
        public int Count { get; set; }
        public int MailType { get; set; }
        public int MailCategory { get; set; }
        public bool InterCode { get; set; }
        public string Name { get; set; }
        public bool SimpleNotice { get; set; } = false;
        public TransType TransType { get; set; } = TransType.Нет;
        public string SubName { get; set; }

        public int MassInt => int.Parse(Mass);
    }
}
