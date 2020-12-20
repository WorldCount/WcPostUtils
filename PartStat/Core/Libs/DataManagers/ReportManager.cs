using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PartStat.Core.Models.Report;
using WcApi.Xml;

namespace PartStat.Core.Libs.DataManagers
{
    public static class ReportManager
    {
        public static void Save(List<Report> reports)
        {
            Serializer.Save(PathManager.ReportPath, reports);
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
            if(!File.Exists(PathManager.ReportPath))
                return new List<Report>();
            return Serializer.Load<List<Report>>(PathManager.ReportPath);
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
            Report lastReport =  reports.OrderBy(r => r.Id).LastOrDefault();
            if (lastReport != null)
                return lastReport.Id;
            return 0;
        }
    }
}
