using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using DwUtils.Core;
using DwUtils.Core.Libs.Database.Sqlite;
using DwUtils.Core.Models.Sqlite;
using NLog;
using SQLite;
using MailRank = DwUtils.Core.Models.Sqlite.MailRank;

namespace DwUtils.Forms.WorkForms
{
    public partial class CreateDbForm : Form
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private readonly Color _windowBorderColor = Color.FromArgb(255, 101, 109, 120);
        public int WindowBorderWidth { get; set; } = 2;
        public ButtonBorderStyle WindowsBorderStyle { get; set; } = ButtonBorderStyle.Dashed;

        public CreateDbForm()
        {
            InitializeComponent();

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
                    if (!Database.TableExist<MailRank>())
                    {
                        SetInfo("Создаю таблицу почтовых разрядов...", 1, maxInit);
                        await Task.Run(() => db.CreateTable<MailRank>());
                    }

                    if (!Database.TableExist<PostMark>())
                    {
                        SetInfo("Создаю таблицу почтовых отметок...", 2, maxInit);
                        await Task.Run(() => db.CreateTable<PostMark>());
                    }


                    if (!Database.TableExist<Delivery>())
                    {
                        SetInfo("Создаю таблицу видов вручений...", 3, maxInit);
                        await Task.Run(() => db.CreateTable<Delivery>());
                    }

                    if (!Database.TableExist<RpoCategory>())
                    {
                        SetInfo("Создаю таблицу видов отправлений...", 4, maxInit);
                        await Task.Run(() => db.CreateTable<RpoCategory>());
                    }

                    if (!Database.TableExist<Rpo>())
                    {
                        SetInfo("Создаю таблицу организаций...", 5, maxInit);
                        await Task.Run(() => db.CreateTable<Rpo>());
                    }

                    if (!Database.TableExist<Rpo>())
                    {
                        SetInfo("Создаю таблицу рпо...", 5, maxInit);
                        await Task.Run(() => db.CreateTable<Rpo>());
                    }


                    if (!Database.TableExist<Doc>())
                    {
                        SetInfo("Создаю таблицу отметок...", 6, maxInit);
                        await Task.Run(() => db.CreateTable<Doc>());
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
