using System.Collections.Generic;
using System.IO;
using System.Linq;
using LK.Core.Models.Reports;
using WcApi.Xml;

namespace LK.Core.Store.Manager
{
    public static class ReportManager
    {
        public static void Save(List<Report> reports)
        {
            Serializer.Save(PathManager.FirmReportPath, reports);
        }

        public static void SaveOrUpdate(Report report)
        {
            List<Report> reports = Load();
            int ind = reports.FindIndex(r => r.Id == report.Id);

            if (ind >= 0)
                reports[ind] = report;
            else
                reports.Add(report);
            Save(reports);
        }

        public static List<Report> Load()
        {
            if (!File.Exists(PathManager.FirmReportPath))
                return new List<Report>();
            return Serializer.Load<List<Report>>(PathManager.FirmReportPath);
        }

        public static List<Report> GetEnabled()
        {
            List<Report> reports = Load();
            return reports.Where(r => r.Enable).ToList();
        }

        public static Report GetById(int id)
        {
            List<Report> reports = Load();
            return reports.FirstOrDefault(r => r.Id == id);
        }

        public static int GetLastId()
        {
            List<Report> reports = Load();
            Report lastReport = reports.OrderBy(r => r.Id).LastOrDefault();
            if (lastReport != null)
                return lastReport.Id;
            return 0;
        }
    }
}
