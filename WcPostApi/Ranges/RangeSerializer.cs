using System.IO;

namespace WcPostApi.Ranges
{
    public static class RangeSerializer
    {
        public static void Save(Range range, string path)
        {
            Serializer.Save(path, range);
        }

        public static Range Load(string path)
        {
            if (!File.Exists(path))
                return null;
            return Serializer.Load<Range>(path);
        }
    }
}
