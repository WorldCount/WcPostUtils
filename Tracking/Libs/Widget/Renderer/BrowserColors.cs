using System.Drawing;
using System.Windows.Forms;

namespace Tracking.Libs.Widget.Renderer
{
    public class BrowserColors : ProfessionalColorTable
    {
        public override Color MenuItemPressedGradientBegin => Color.FromArgb(53, 56, 58);
        public override Color MenuItemPressedGradientEnd => Color.FromArgb(53, 56, 58);
        public override Color MenuItemSelected => Color.FromArgb(30, 30, 30);
        public override Color MenuItemBorder => Color.FromArgb(30, 30, 30);
        public override Color MenuItemSelectedGradientBegin => Color.FromArgb(30, 30, 30);
        public override Color MenuItemSelectedGradientEnd => Color.FromArgb(30, 30, 30);
    }
}
