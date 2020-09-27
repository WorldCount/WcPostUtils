using FirebirdSql.Data.FirebirdClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace OpenCloseDU
{
    enum DataBaseState
    {
        Open,
        Close
    }

    public partial class GenearlForm : Form
    {
        private string _path;

        public GenearlForm()
        {
            InitializeComponent();

            labelStatus.Text = "";
            labelDB.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _path = Path.Combine(Application.StartupPath, "POSTITEM.IB");
            if (File.Exists(_path))
            {
                labelDB.Text = "POSTITEM.IB найден.";
                UpdateState();
            }
            else
            {
                labelDB.Text = "POSTITEM.IB не найден.";
            }
        }

        private void UpdateState()
        {
            bool status = CheckStatus();

            if (status)
            {
                btnOpen.Enabled = false;
                btnClose.Enabled = true;
                labelStatus.Text = "БД открыта";
            }
            else
            {
                btnOpen.Enabled = true;
                btnClose.Enabled = false;
                labelStatus.Text = "БД закрыта";
            }
        }

        private string GetConnect()
        {
            FbConnectionStringBuilder fbConnection = new FbConnectionStringBuilder
            {
                UserID = "SYSDBA",
                Password = "masterkey",
                Database = _path,
                DataSource = "localhost",
                ServerType = FbServerType.Default,
                Port = 3050,
                Charset = "WIN1251",
                WireCrypt = FbWireCrypt.Required
            };

            return fbConnection.ToString();
        }

        private bool CheckStatus()
        {
            FbConnection fbConnection = null;
            FbDataReader reader = null;

            try
            {
                fbConnection = new FbConnection(GetConnect());

                if (fbConnection.State == ConnectionState.Closed)
                    fbConnection.Open();

                FbCommand selectCommand = new FbCommand("select vali from setup where setupid = 18", fbConnection);
                reader = selectCommand.ExecuteReader();

                reader.Read();

                bool res = reader.GetInt32(0) == 0;

                reader.Close();
                selectCommand.Dispose();

                return res;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                reader?.Close();
                fbConnection?.Close();
            }
        }

        private bool SetDataBaseState(DataBaseState state)
        {
            FbConnection fbConnection = null;
            FbTransaction fbTransaction = null;

            try
            {
                fbConnection = new FbConnection(GetConnect());

                if (fbConnection.State == ConnectionState.Closed)
                    fbConnection.Open();

                fbTransaction = fbConnection.BeginTransaction();

                FbCommand command = new FbCommand($"update setup set vali = {(int)state} where setupid = 18", fbConnection) { Transaction = fbTransaction };
                int count = command.ExecuteNonQuery();

                command.Dispose();
                fbTransaction.Commit();
                return count == 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                fbTransaction?.Rollback();
                return false;
            }
            finally
            {
                fbTransaction?.Dispose();
                fbConnection?.Close();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (SetDataBaseState(DataBaseState.Open))
                UpdateState();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (SetDataBaseState(DataBaseState.Close))
                UpdateState();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
