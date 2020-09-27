using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace WcApi.Database
{
    // ReSharper disable once InconsistentNaming
    public class DBF
    {
        private readonly OdbcConnection _connection;

        public DBF(string path)
        {
            _connection = new OdbcConnection
            {
                ConnectionString = @"Driver={Microsoft dBase Driver (*.dbf)};" + $"DBQ={path};" +@"SourceType=DBF;Exclusive=No;Collate=Machine;NULL=NO;DELETED=NO;BACKGROUNDFETCH=NO;"
            };
        }

        public DataTable Execute(string command)
        {
            DataTable dt = null;
            if (_connection != null)
            {
                try
                {
                    _connection.Open();
                    dt = new DataTable();
                    OdbcCommand cmd = _connection.CreateCommand();
                    cmd.CommandText = command;
                    dt.Load(cmd.ExecuteReader());
                    _connection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "DBF: Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return dt;
        }

        public DataTable GetAll(string dbPath)
        {
            return Execute($"select * from {dbPath}");
        }
    }
}
