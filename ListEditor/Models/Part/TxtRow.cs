using System.Collections.Generic;
using System.Linq;


namespace ListEditor.Models.Part
{
    public class TxtRow
    {
        public Dictionary<string, string> Data;
        public int Count => Data.Count;

        public TxtRow(TxtHeader header, string data, bool checkError = false)
        {
            string[] row = data.Split('|');
            Data = header.Data.Zip(row, (s, i) => new {s, i}).ToDictionary(item => item.s, item => item.i);
        }
    }
}
