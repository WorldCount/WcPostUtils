using System.Windows.Forms;

namespace Mail.Widgets
{
    public partial class NoAutoScrollPanel : TableLayoutPanel
    {
        public NoAutoScrollPanel()
        {
            Enter += PanelNoScrollOnFocus_Enter;
            Leave += PanelNoScrollOnFocus_Leave;
        }

        void PanelNoScrollOnFocus_Enter(object sender, System.EventArgs e)
        {
        }

        void PanelNoScrollOnFocus_Leave(object sender, System.EventArgs e)
        {
        }

        protected override System.Drawing.Point ScrollToControl(Control activeControl)
        {
            return DisplayRectangle.Location;
        }
    }
}
