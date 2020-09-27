using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Threading.Tasks;
using Barcodes.Libs.DB.Queryes;
using Barcodes.Libs.Models;
using FirebirdSql.Data.FirebirdClient;
using WcApi.Xml;

namespace Barcodes.Libs.DB
{
    public static class DataBase
    {
        public static Connect GetConnect(string path)
        {
            if (!File.Exists(path))
                return new Connect();

            Connect connect = Serializer.Load<Connect>(path);
            return connect;
        }

        public static void SaveConnect(Connect connect, string path)
        {
            Serializer.Save(path, connect);
        }

        public static List<Firm> GetFirms(FirmQuery firmQuery)
        {
            List<Firm> firms = new List<Firm>();
            FbConnection fbConnection = null;
            FbDataReader reader = null;
            FbTransaction fbTransaction = null;

            try
            {
                fbConnection = new FbConnection(firmQuery.Connect.ToString());
                if (fbConnection.State == ConnectionState.Closed)
                    fbConnection.Open();

                fbTransaction = fbConnection.BeginTransaction();
                FbCommand selectCommand = new FbCommand(firmQuery.GetQuery(), fbConnection)
                    {Transaction = fbTransaction};
                reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Firm firm = new Firm {Name = reader.GetString(0), Inn = reader.GetString(1)};
                    firms.Add(firm);
                }

                reader.Close();
                selectCommand.Dispose();
                fbTransaction.Commit();
                return firms;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                fbTransaction?.Rollback();
                return null;
            }
            finally
            {
                reader?.Close();
                fbTransaction?.Dispose();
                fbConnection?.Close();
            }
        }

        public static async Task<List<Firm>> GetFirmsAsync(FirmQuery firmQuery)
        {
            return await Task.Run(() => GetFirms(firmQuery));
        }
    }
}
