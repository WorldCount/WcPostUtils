using System;
using System.Collections.Generic;
using System.IO;
using LK.Core.Models.Raw;
using LK.Core.Store.Manager.FileManager;
using NLog;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace LK.Core.Store.Parsers
{
    public class LkReportParser
    {
        #region Private fields

        private readonly string _ext;
        private readonly string _filePath;
        private string _error;

        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private readonly bool _loggingMode = Properties.Settings.Default.LoggingMode;

        private readonly ConfigDataFieldManager _configDataFieldManager;

        #endregion

        #region Public Properties

        public string Error => _error;

        #endregion

        public LkReportParser(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            _ext = fileInfo.Extension;
            _filePath = filePath;

            _configDataFieldManager = new ConfigDataFieldManager();
            _configDataFieldManager.Load();
            _configDataFieldManager.DecrementRowNum();
        }

        public List<RawData> Parse()
        {
            IWorkbook workbook;
            List<RawData> datas = new List<RawData>();

            using (FileStream fs = new FileStream(_filePath, FileMode.Open, FileAccess.Read))
            {
                if (_ext == ".xlsx")
                    workbook = new XSSFWorkbook(fs);
                else
                    workbook = new HSSFWorkbook(fs);
            }

            ISheet rpoSheet = workbook.GetSheetAt(1);

            for (int i = 1; i <= rpoSheet.LastRowNum; i++)
            {
                IRow row = rpoSheet.GetRow(i);

                if (row == null)
                    continue;

                try
                {
                    RawData data = new RawData(row, _configDataFieldManager);
                    if (data.Parse() == false)
                    {
                        if(_loggingMode)
                            Logger.Error($"RawRpoData.Parse, Row [{i}]: {data.Exception.Message}");
                        continue;
                    }

                    datas.Add(data);
                }
                catch (Exception e)
                {
                    _error = e.Message;
                    if (_loggingMode)
                        Logger.Error(e);
                    break;
                }
            }

            workbook.Close();
            return datas;
        }
    }
}
