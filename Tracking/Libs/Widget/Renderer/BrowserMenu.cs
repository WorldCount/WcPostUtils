using System.Windows.Forms;

namespace Tracking.Libs.Widget.Renderer
{
    public class BrowserMenu : MenuStrip
    {
        public BrowserMenu()
        {
            Renderer = new BrowserMenuRenderer();
        }
    }
}
