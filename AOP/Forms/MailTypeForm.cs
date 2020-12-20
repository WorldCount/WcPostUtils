using AOP.Core;
using System.Collections.Generic;
using WcPostApi.Forms.MailForms;
using WcPostApi.Types;

namespace AOP.Forms
{
    public sealed partial class MailTypeForm : WcMailTypeForm
    {
        public MailTypeForm()
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName}: Виды отправлений";

            // Хук двойной буфферизации для таблицы
            WcApi.Win32.DrawingControl.SetDoubleBuffered(dataGridView);

            InitTable();

            MailTypes = LoadData();
            UpdateData();
        }

        public override List<MailType> LoadData()
        {
            return DataManager.MailTypeManager.Load();
        }

        public override List<MailType> LoadDataServer()
        {
            return DataManager.MailTypeManager.GetDefault();
        }

        public override void SaveData()
        {
            DataManager.MailTypeManager.Save(MailTypes);
        }
    }
}
