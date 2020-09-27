namespace ListEditor.Models.Part
{
    public class TxtHeader
    {
        private readonly string[] _data;
        public string[] Data => _data;

        public int Count => _data.Length;

        public TxtHeader(string header)
        {
            _data = header.ToUpper().Trim().Split('|');
        }

        public override string ToString()
        {
            return string.Join("|", _data);
        }
    }
}
