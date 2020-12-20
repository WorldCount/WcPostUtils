
namespace PartStat.Core.Libs.Stats.StatObject
{
    public class ServiceData
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public string ValueString => Value.ToString();
    }
}
