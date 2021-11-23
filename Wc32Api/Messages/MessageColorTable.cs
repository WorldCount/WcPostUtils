using System.Drawing;

namespace Wc32Api.Messages
{
    public class MessageColorTable
    {
        public Color Normal { get; set; } = Color.DimGray;
        public Color Success { get; set; } = Color.Green;
        public Color Error { get; set; } = Color.Firebrick;
        public Color Warning { get; set; } = Color.DarkOrange;
        public Color Info { get; set; } = Color.DodgerBlue;
    }
}
