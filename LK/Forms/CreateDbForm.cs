using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
    public partial class CreateDbForm : Form
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private readonly Color _windowBorderColor = Color.Teal;

        private readonly List<Firm> _firms;

        public int WindowBorderWidth { get; set; } = 2;
        public ButtonBorderStyle WindowsBorderStyle { get; set; } = ButtonBorderStyle.Dashed;

        public CreateDbForm()
        {
            InitializeComponent();

            labelDate.Text = $"Делаю копию организаций";
            labelInfo.Text = "";
            coloredProgressBar.Value = 0;

            _firms = Database.GetFirms();

            labelDate.Text = $"Создание БД";
            labelInfo.Text = "";
            coloredProgressBar.Value = 0;

            try
            {
                if (File.Exists(PathManager.DbPath))
                    File.Delete(PathManager.DbPath);
            }
            catch (Exception e)
            {
                Logger.Error($"Ошибка при удалении БД: {e.Message}");
            }
            
        }

        private void SyncForm_Load(object sender, EventArgs e)
        {
            Work();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                _windowBorderColor, WindowBorderWidth, WindowsBorderStyle,
                _windowBorderColor, WindowBorderWidth, WindowsBorderStyle,
                _windowBorderColor, WindowBorderWidth, WindowsBorderStyle,
                _windowBorderColor, WindowBorderWidth, WindowsBorderStyle);
        }

        private void SetInfo(string text, int value, int max = 100)
        {
            labelInfo.Text = text;
            labelInfo.Refresh();

            coloredProgressBar.Maximum = max;
            coloredProgressBar.Value = value;
            coloredProgressBar.Refresh();
        }

        private async void Work()
        {

            int maxInit = 12;

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
                }
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
            }

            Close();
        }
    }
}
