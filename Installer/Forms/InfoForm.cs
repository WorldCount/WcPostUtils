using System.Drawing;
using System.Windows.Forms;
using Installer.Models;

namespace Installer.Forms
{
    public partial class InfoForm : Form
    {
        private readonly AppInfo _appInfo;
        private readonly Color _versionColor = Color.DodgerBlue;
        private readonly Color _addColor = Color.SeaGreen;
        private readonly Color _delColor = Color.Firebrick;
        private readonly Color _infoColor = Color.DarkOrange;
        private readonly Color _warnColor = Color.OrangeRed;

        private int _posStart = 0;
        private int _posAdd = 0;
        private int _posDel = 0;
        private int _posInfo = 0;
        private int _posWarn = 0;

        public InfoForm(AppInfo appInfo)
        {
            InitializeComponent();
            _appInfo = appInfo;
        }

        private void InfoForm_Load(object sender, System.EventArgs e)
        {
            lblAppName.Text = $"{_appInfo.Name} {_appInfo.Version}";
            foreach (string s in _appInfo.Info)
            {
                tbInfo.AppendText($"{s}\n");
                FindVersion();
                _posInfo = SelectChar(tbInfo, _posInfo, '*', _infoColor);
                _posAdd = SelectChar(tbInfo, _posAdd, '+', _addColor);
                _posDel = SelectChar(tbInfo, _posDel, '-', _delColor);
                _posWarn = SelectChar(tbInfo, _posWarn, '!', _warnColor);
                _posInfo = SelectChar(tbInfo, _posInfo, '*', _infoColor);
            }
            
        }

        private void FindVersion()
        {
            SelectText(tbInfo);
            tbInfo.SelectionColor = _versionColor;
        }

        private int SelectChar(RichTextBox richTextBox, int posStart, char c, Color color)
        {
            int pos = richTextBox.Text.IndexOf(c, posStart);
            if (pos < 0)
            {
                richTextBox.Select(0, 0);
                return 0;
            }
            else
            {
                richTextBox.Select(pos, 1);
                richTextBox.SelectionColor = color;
                richTextBox.SelectionFont = new Font(tbInfo.Font, FontStyle.Bold);
                return pos + 1;
            }
        }

        private void SelectText(RichTextBox richTextBox, char o = '[', char c = ']')
        {
            int posOpen = richTextBox.Text.IndexOf(o, _posStart);
            int posClose = richTextBox.Text.IndexOf(c, _posStart);
            int len = posClose - posOpen + 1;
            if (posOpen < 0 || posClose < 0 || len <= 0)
            {
                richTextBox.Select(0, 0);
            }
            else
            {
                richTextBox.Select(posOpen, len);
                _posStart = posOpen + len;
            }
        }

        private void buttonAccept_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
