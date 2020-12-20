using System.Drawing;

namespace LK.Core.Libs.PrintDocuments
{
    public static class PrintPens
    {
        // Кисти
        public static SolidBrush ForeBrush { get; } = new SolidBrush(Color.Black);
        public static Pen BorderBrush { get; } = Pens.Black;
        // Шрифты
        public static Font BoldFont { get; } = new Font("Segoe Ui", 10, FontStyle.Bold);
        public static Font DateFont { get; } = new Font("Segoe Ui", 9, FontStyle.Regular);
        public static Font CellFont { get; } = new Font("Segoe Ui", 10, FontStyle.Regular);
        // Заголовок
        public static Font HeaderFont { get; } = new Font("Segoe Ui", 10, FontStyle.Regular, GraphicsUnit.Point);
        public static Font HeaderBoldFont { get; } = new Font("Segoe Ui", 12, FontStyle.Bold, GraphicsUnit.Point);
    }
}
