using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LK.Core.Models.DB;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace LK.Core.Libs.Parse
{

    public class XmlParser : IDisposable
    {
        private readonly string _link;
        private readonly IWorkbook _workbook;

        private ParseData _parseData;


        public XmlParser(string link)
        {
            _link = link;

            _parseData = new ParseData();

            using (FileStream fs = new FileStream(_link, FileMode.Open, FileAccess.Read))
            {
                FileInfo fileInfo = new FileInfo(_link);
                if (fileInfo.Extension == ".xlsx")
                    _workbook = new XSSFWorkbook(fs);
                else
                    _workbook = new HSSFWorkbook(fs);
            }
        }

        public void ParseList()
        {
            if(_workbook == null)
                return;

            ISheet sheet = _workbook.GetSheetAt(0);

            for (int i = 1; i <= sheet.LastRowNum; i++)
            {

            }
        }


        public void Dispose()
        {
            _workbook?.Close();
        }
    }
}
