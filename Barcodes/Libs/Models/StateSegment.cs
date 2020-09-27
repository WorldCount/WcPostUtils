
namespace Barcodes.Libs.Models
{
    public class StateSegment
    {
        public int Value { get; set; }
        public string Name { get; set; }

        public StateSegment(int value, string name)
        {
            Value = value;
            Name = name;
        }
    }
}
