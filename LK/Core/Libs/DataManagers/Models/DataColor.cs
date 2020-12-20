using System.Drawing;

namespace LK.Core.Libs.DataManagers.Models
{
    public enum ColorName
    {
        WarnFore,
        WarnBack,
        ErrorFore,
        ErrorBack
    }

    public class DataColor
    {
        public ColorName Name { get; set; }
        public int A { get; set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

        public DataColor() { }

        public DataColor(ColorName name)
        {
            Name = name;
        }

        public DataColor(ColorName name, Color color)
        {
            Name = name;
            SetColor(color);
        }

        public Color GetColor()
        {
            return Color.FromArgb(A, R, G, B);
        }

        public void SetColor(Color color)
        {
            A = color.A;
            R = color.R;
            G = color.G;
            B = color.B;
        }
    }
}
