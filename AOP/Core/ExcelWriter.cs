using System;
using System.Collections.Generic;
using System.IO;
using AOP.Core.Models.DB;
using NLog;
using NPOI.SS.UserModel;

namespace AOP.Core
{
    public static class ExcelWriter
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public static bool Write(string path, List<Rpo> rpos)
        {
            try
            {
                IWorkbook templateWorkbook;

                using (FileStream templateFile = new FileStream(PathManager.ExcelTemplate, FileMode.Open, FileAccess.Read))
                {
                    templateWorkbook = WorkbookFactory.Create(templateFile);
                }

                ISheet templateWorksheet = templateWorkbook.GetSheetAt(0);

                for (int i = 0; i < rpos.Count; i++)
                {
                    IRow row = templateWorksheet.GetRow(i + 1);

                    Rpo rpo = rpos[i];

                    if (!string.IsNullOrEmpty(rpo.Barcode))
                        row.Cells[0].SetCellValue(rpo.Barcode);


                    if(!string.IsNullOrEmpty(rpo.Index))
                        row.Cells[1].SetCellValue(int.Parse(rpo.Index));
                    else
                        row.Cells[1].SetCellValue(rpo.Index);
                    row.Cells[5].SetCellValue(rpo.Region);
                    row.Cells[7].SetCellValue(rpo.PlaceTo);
                    row.Cells[9].SetCellValue(rpo.Address);
                    row.Cells[17].SetCellValue(rpo.Rcpn);

                    if (rpo.Mass > 0)
                        row.Cells[18].SetCellValue((double)rpo.Mass / 100);

                    row.Cells[24].SetCellValue($" {rpo.Comment}\t");
                }

                using (FileStream resultFile = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    templateWorkbook.Write(resultFile);
                }

                return true;
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
                return false;
            }
        }
    }
}
