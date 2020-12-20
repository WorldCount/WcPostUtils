using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AOP.Core.Models.DB;
using NLog;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace AOP.Core
{
    public static class ExcelParser
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public static RpoList Parse(string link)
        {
            IWorkbook workbook;

            FileInfo fileInfo = new FileInfo(link);
            string ext = fileInfo.Extension;

            if ((ext != ".xls") && (ext != ".xlsx"))
                return null;

            RpoList rpoList = new RpoList
            {
                Name = fileInfo.Name.Replace(ext, ""),
                Num = int.Parse(new string(fileInfo.Name.Where(char.IsDigit).ToArray()))
            };


            string name = fileInfo.Name.ToUpper();

            if (name.Contains("ЗП") || name.Contains("З-П"))
            {
                rpoList.Type = 2;
                rpoList.Category = 1;
            }
            else if (name.Contains("ЗБ") || name.Contains("З-Б"))
            {
                rpoList.Type = 3;
                rpoList.Category = 1;
            }
            else if (name.Contains("ПП") || name.Contains("П-П"))
            {
                rpoList.Type = 2;
                rpoList.Category = 0;
            }
            else if (name.Contains("ПБ") || name.Contains("П-Б"))
            {
                rpoList.Type = 3;
                rpoList.Category = 0;
            }
            else
            {
                rpoList.Type = 0;
                rpoList.Category = 5;
            }

            using (FileStream fileStream = new FileStream(link, FileMode.Open, FileAccess.Read))
            {
                if (ext == ".xlsx")
                    workbook = new XSSFWorkbook(fileStream);
                else
                    workbook = new HSSFWorkbook(fileStream);
            }

            ISheet sheet = workbook.GetSheetAt(0);
            for (int i = 0; i <= sheet.LastRowNum; i++)
            {
                IRow row = sheet.GetRow(i);

                if (row == null && i > 3)
                    break;

                if (row != null)
                {
                    string d = "";
                    foreach (ICell cell in row.Cells)
                        d += cell.ToString();

                    string dUpper = d.ToUpper();

                    if (string.IsNullOrEmpty(d) && i > 3 || dUpper.Contains("СДАЛ:"))
                        break;

                    if (dUpper.Contains("ДОЛЖНОСТЬ, ФИО") || dUpper.Contains("НАИМЕНОВАНИЕ ОРГАНИЗАЦИИ") || dUpper.Contains("СПИСОК ПОЧТОВЫХ ОТПРАВЛЕНИЙ"))
                        continue;

                    try
                    {
                        string region = row.GetCell(1, MissingCellPolicy.CREATE_NULL_AS_BLANK).ToString();
                        string index = row.GetCell(2, MissingCellPolicy.CREATE_NULL_AS_BLANK).ToString();
                        string place = row.GetCell(4, MissingCellPolicy.CREATE_NULL_AS_BLANK).ToString();
                        string address = row.GetCell(5, MissingCellPolicy.CREATE_NULL_AS_BLANK).ToString();
                        string rcpn = row.GetCell(6, MissingCellPolicy.CREATE_NULL_AS_BLANK).ToString();
                        string comment = row.GetCell(7, MissingCellPolicy.CREATE_NULL_AS_BLANK).ToString();

                        string t = $"{region}{index}{place}{address}{rcpn}{comment}";
                        if (string.IsNullOrEmpty(t))
                            continue;

                        Rpo rpo = new Rpo
                        {
                            Region = region.Trim(),
                            Index = index.Trim(),
                            PlaceTo = place.Trim(),
                            Address = address.Trim(),
                            Rcpn = rcpn.Trim(),
                            Comment = comment.Trim(),
                            Error = false
                        };

                        rpoList.Rpos.Add(rpo);

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show($"Строка: {i + 1} -> пропущена ({row.Cells.Count}):\n{e.Message}");
                        Logger.Error($"Строка: {i + 1} -> пропущена ({row.Cells.Count}):\n{e.Message}");
                        throw;
                    }

                }
            }

            rpoList.Count = rpoList.Rpos.Count;
            rpoList.ErrorCount = rpoList.Rpos.Count(r => r.Error);

            workbook = null;
            GC.Collect();

            return rpoList;
        }

        public static Task<RpoList> ParseAsync(string link)
        {
            return Task.Run(() => Parse(link));
        }
    }
}
