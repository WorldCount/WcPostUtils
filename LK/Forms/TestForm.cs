using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LK.Core.Libs.Auth;
using LK.Core.Libs.Auth.Model;
using LK.Core.Libs.Auth.Types;
using WcApi.Cryptography;

namespace LK.Forms
{
    public partial class TestForm : Form
    {
        private LkAuth _lkAuth;
        private Token _token;
        private Auth _auth;

        public TestForm(Auth auth)
        {
            InitializeComponent();

            _auth = auth;
        }

        private Task Auth()
        {
            return Task.Run(() =>
            {
                _lkAuth = new LkAuth(_auth);
                string code = _lkAuth.Auth().Result;
                _token = _lkAuth.GetToken(code).Result;
            });
        }

        private async void btnRun_Click(object sender, EventArgs e)
        {

            richTextBox.Clear();

            await Auth();

            DateTime date = new DateTime(2021, 11, 1);

            if (_token.IsExist())
            {
                List<DocPayType> pays = new List<DocPayType>();
                List<DocStatus> statuses = new List<DocStatus>();

                DateTime start = dateTimePickerStart.Value;
                DateTime end = dateTimePickerEnd.Value;

                List<ReceiveDoc> docs = await _lkAuth.ReceiveDocResponse(_token, start, end);

                foreach (ReceiveDoc receiveDoc in docs)
                {
                    if(!pays.Contains(receiveDoc.PaymentMethods))
                        pays.Add(receiveDoc.PaymentMethods);

                    if(!statuses.Contains(receiveDoc.BatchStatus))
                        statuses.Add(receiveDoc.BatchStatus);
                }

                foreach (DocPayType pay in pays)
                {
                    richTextBox.AppendText($"{pay}\r\n");
                }

                richTextBox.AppendText($"\r\n");

                foreach (DocStatus status in statuses)
                {
                    richTextBox.AppendText($"{status}\r\n");
                }

                richTextBox.AppendText($"\r\n");

                foreach (DocPayType pay in pays)
                {
                    richTextBox.AppendText($"{pay}:\r\n");
                    List<string> firmNames = new List<string>();

                    List<ReceiveDoc> filter = docs.Where(d => d.PaymentMethods == pay).ToList();
                    foreach (ReceiveDoc receiveDoc in filter)
                    {
                        if(!firmNames.Contains(receiveDoc.OrgName))
                            firmNames.Add(receiveDoc.OrgName);
                    }

                    foreach (string firmName in firmNames)
                    {
                        richTextBox.AppendText($"{firmName}\r\n");
                    }

                    richTextBox.AppendText($"\r\n");
                }
            }
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerEnd.Value = dateTimePickerStart.Value;
        }
    }
}
