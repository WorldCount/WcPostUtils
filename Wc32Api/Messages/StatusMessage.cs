using System;
using System.Drawing;
using System.Windows.Forms;

namespace Wc32Api.Messages
{
    public class StatusMessage
    {
        #region Private Fields

        private readonly ToolStripStatusLabel _label;
        private readonly MessageColorTable _colorTable;
        private readonly Timer _timer;

        #endregion

        public StatusMessage(ToolStripStatusLabel label, MessageColorTable colorTable = null)
        {
            _label = label;

            _colorTable = colorTable ?? new MessageColorTable();

            _timer = new Timer { Interval = 3000 };
            _timer.Tick += _timer_Tick;
        }

        #region Events

        private void _timer_Tick(object sender, EventArgs e)
        {
            _label.Text = "";
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Отправляет сообщение в статус
        /// </summary>
        /// <param name="message"></param>
        /// <param name="color"></param>
        // ReSharper disable once MemberCanBePrivate.Global
        public void SendMessage(string message, Color color)
        {
            if (_label != null)
            {
                _label.ForeColor = color;
                _label.Text = message;
                _timer.Start();
            }
        }

        // Сообщение: обычное
        // ReSharper disable once UnusedMember.Global
        public void NormalMessage(string message)
        {
            SendMessage(message, _colorTable.Normal);
        }

        // Сообщение: успех
        public void SuccessMessage(string message)
        {
            SendMessage(message, _colorTable.Success);
        }

        // Сообщение: ошибка
        public void ErrorMessage(string message)
        {
            SendMessage(message, _colorTable.Error);
        }

        // Сообщение: предупреждение
        public void WarningMessage(string message)
        {
            SendMessage(message, _colorTable.Warning);
        }

        // Сообщение: информация
        public void InfoMessage(string message)
        {
            SendMessage(message, _colorTable.Info);
        }

        #endregion
    }
}
