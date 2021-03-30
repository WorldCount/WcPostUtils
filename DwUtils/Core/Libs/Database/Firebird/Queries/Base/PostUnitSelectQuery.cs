using System;
using System.Data;
using DwUtils.Core.Libs.Database.Firebird.Connect;
using FirebirdSql.Data.FirebirdClient;

namespace DwUtils.Core.Libs.Database.Firebird.Queries.Base
{
    public abstract class PostUnitSelectQuery<T> : Query<PostUnitConnect>
    {
        protected PostUnitSelectQuery(PostUnitConnect connect) : base(connect) { }

        public abstract override string GetQuery();

        protected abstract T ParseResponse(FbDataReader reader);

        public T Run()
        {
            string q = GetQuery();
            Logger.Debug($"Запрос в БД: {q}");

            FbConnection fbConnection = null;
            FbDataReader reader = null;
            FbTransaction fbTransaction = null;

            try
            {
                fbConnection = new FbConnection(Connect.ToString());
                if (fbConnection.State == ConnectionState.Closed)
                    fbConnection.Open();

                fbTransaction = fbConnection.BeginTransaction();

                FbCommand selectCommand = new FbCommand(q, fbConnection) { Transaction = fbTransaction };
                reader = selectCommand.ExecuteReader();

                T data = ParseResponse(reader);

                return data;
            }
            catch (Exception e)
            {
                Logger.Error($"Ошибка при запросе: {q}");
                Logger.Error(e);
                Logger.Error(e.Message);

                fbTransaction?.Rollback();
                return default;
            }
            finally
            {
                reader?.Close();
                fbTransaction?.Dispose();
                fbConnection?.Close();
            }
        }
    }
}
