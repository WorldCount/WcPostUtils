using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using LK.Core;
using LK.Core.Models.DB;
using LK.Core.Models.DB.Types;
using LK.Core.Store;
using NLog;
using SQLite;

namespace LK.Forms
{
    public partial class NewDbForm : Form
    {
        #region System

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect,
            int nBottomRect, int nWidthEllipse, int nHeigthEllipse);

        #endregion

        #region Private Fields

        #region Логирование

        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private readonly bool _loggingMode = Properties.Settings.Default.LoggingMode;

        #endregion

        #region Данные

        private readonly List<Firm> _firms;
        private readonly List<Group> _groups;

        #endregion

        #endregion


        public NewDbForm()
        {
            InitializeComponent();

            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 5, 5));

            _firms = Database.GetFirms();
            _groups = Database.GetGroups();

            try
            {
                if (File.Exists(PathManager.DbPath))
                    File.Delete(PathManager.DbPath);
            }
            catch (Exception e)
            {
                if (_loggingMode)
                    Logger.Error($"Ошибка при удалении БД: {e.Message}");
            }

        }

        #region Private Methods

        private async void Work()
        {

            int maxInit = 17;
            SetInfo("Инициализация БД...", 0, maxInit);

            try
            {
                using (var db = new SQLiteConnection(PathManager.DbPath))
                {
                    if (!Database.TableExist<Operator>())
                    {
                        SetInfo("Создаю таблицу операторов...", 1, maxInit);
                        await Task.Run(() => db.CreateTable<Operator>());
                    }


                    if (!Database.TableExist<Status>())
                    {
                        SetInfo("Создаю таблицу статусов...", 2, maxInit);
                        await Task.Run(() => db.CreateTable<Status>());

                        SetInfo("Заполняю таблицу статусов...", 3, maxInit);
                        await Task.Run(DatabaseData.FillStatusTable);
                    }


                    if (!Database.TableExist<MailCategory>())
                    {
                        SetInfo("Создаю таблицу категорий...", 4, maxInit);
                        await Task.Run(() => db.CreateTable<MailCategory>());

                        SetInfo("Заполняю таблицу категорий...", 5, maxInit);
                        await Task.Run(DatabaseData.FillMailCategoryTable);
                    }


                    if (!Database.TableExist<MailType>())
                    {
                        SetInfo("Создаю таблицу типов...", 6, maxInit);
                        await Task.Run(() => db.CreateTable<MailType>());

                        SetInfo("Заполняю таблицу типов...", 7, maxInit);
                        await Task.Run(DatabaseData.FillMailTypeTable);
                    }


                    if (!Database.TableExist<Notice>())
                    {
                        SetInfo("Создаю таблицу отметок...", 8, maxInit);
                        await Task.Run(() => db.CreateTable<Notice>());

                        SetInfo("Заполняю таблицу отметок...", 9, maxInit);
                        await Task.Run(DatabaseData.FillNoticeTable);
                    }


                    if (!Database.TableExist<Firm>())
                    {
                        SetInfo("Создаю таблицу организаций...", 10, maxInit);
                        await Task.Run(() => db.CreateTable<Firm>());

                        SetInfo("Заполняю таблицу организаций...", 11, maxInit);
                        await Task.Run(() => DatabaseData.FillFirmsTable(_firms));
                    }


                    if (!Database.TableExist<FirmList>())
                    {
                        SetInfo("Создаю таблицу списков организаций...", 12, maxInit);
                        await Task.Run(() => db.CreateTable<FirmList>());
                    }


                    if (!Database.TableExist<Rpo>())
                    {
                        SetInfo("Создаю таблицу рпо...", 13, maxInit);
                        await Task.Run(() => db.CreateTable<Rpo>());
                    }


                    if (!Database.TableExist<Group>())
                    {
                        SetInfo("Создаю таблицу групп...", 14, maxInit);
                        await Task.Run(() => db.CreateTable<Group>());

                        SetInfo("Заполняю таблицу групп...", 15, maxInit);
                        await Task.Run(() => DatabaseData.FillGroupTable(_groups));
                    }


                    if (!Database.TableExist<PayType>())
                    {
                        SetInfo("Создаю таблицу видов оплаты...", 16, maxInit);
                        await Task.Run(() => db.CreateTable<PayType>());

                        SetInfo("Заполняю таблицу видов оплаты...", 17, maxInit);
                        await Task.Run(DatabaseData.FillPayTypeTable);
                    }
                }
            }
            catch (Exception e)
            {
                if (_loggingMode)
                    Logger.Error(e.Message);
            }

            Close();
        }

        private void SetInfo(string text, int value = 25, int max = 100, 
            string progressText = "", ProgressBarStyle style = ProgressBarStyle.Continuous)
        {
            labelInfo.Text = text;
            labelInfo.Refresh();

            circularProgressBar.Text = progressText;

            circularProgressBar.Style = style;
            circularProgressBar.Maximum = max;
            circularProgressBar.Value = value;

            circularProgressBar.Refresh();
        }

        private void ContinuousProgress()
        {
            circularProgressBar.Style = ProgressBarStyle.Continuous;
            circularProgressBar.Refresh();
        }

        private void MarqueeProgress()
        {
            circularProgressBar.Value = 50;
            circularProgressBar.Maximum = 100;
            circularProgressBar.Style = ProgressBarStyle.Marquee;
            circularProgressBar.Refresh();
        }

        #endregion

        #region Form Event

        private void LoadFileForm_Load(object sender, EventArgs e)
        {
            Work();
        }

        private void LoadFileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
        }

        #endregion


    }
}
