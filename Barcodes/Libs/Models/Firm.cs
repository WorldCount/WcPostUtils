
namespace Barcodes.Libs.Models
{
    public class Firm
    {
        public string Inn { get; set; }
        public string Name { get; set; }

        public Firm() { }

        public Firm(string inn, string name)
        {
            Inn = inn;
            Name = name;
        }
    }
}
