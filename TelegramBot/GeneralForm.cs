using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Message = Telegram.Bot.Types.Message;

namespace TelegramBot
{
    public partial class GeneralForm : Form
    {
        private BackgroundWorker _bw;
        private Queue<int> queue = new Queue<int>();

        public GeneralForm()
        {
            InitializeComponent();

            _bw = new BackgroundWorker();
            _bw.DoWork += _bw_DoWork;
        }

        private async void _bw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            string key = e.Argument as string;

            try
            {
                TelegramBotClient bot = new Telegram.Bot.TelegramBotClient(key);
                await bot.SetWebhookAsync("");

                int offset = 0;

                while (true)
                {
                    Telegram.Bot.Types.Update[] updates = await bot.GetUpdatesAsync(offset);

                    foreach (Update update in updates)
                    {
                        Message message = update.Message;
                        if (message.Type == MessageType.Text)
                        {
                            if (message.Text == "/id")
                            {
                                await bot.SendTextMessageAsync(message.Chat.Id, $"Id чата: {message.Chat.Id}",
                                    replyToMessageId: message.MessageId);
                            }
                        }

                        offset = update.Id + 1;
                    }
                }
            }
            catch (Telegram.Bot.Exceptions.ApiRequestException ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            string text = textBoxKey.Text;

            // Если воркер не запущен - запускаем
            if (_bw.IsBusy != true)
                _bw.RunWorkerAsync(text);
        }
    }
}
