using System;
using System.Collections.Generic;
using System.Linq;

namespace PartStat.Core.Models.DataReports
{
    public class HandReportList
    {
        private readonly Dictionary<DateTime, HandReport> _data;

        public HandReportList()
        {
            _data = new Dictionary<DateTime, HandReport>();
        }

        public void Add(HandReport report)
        {
            if (_data.ContainsKey(report.Date))
            {
                _data[report.Date].AllCount += report.AllCount;
                _data[report.Date].HandCount += report.HandCount;
                _data[report.Date].NormalCount += report.NormalCount;
                _data[report.Date].PaySum += report.PaySum;
            }
            else
                _data.Add(report.Date, report);
        }

        public void Remove(HandReport report)
        {
            if (_data.ContainsKey(report.Date))
            {
                _data[report.Date].AllCount -= report.AllCount;
                _data[report.Date].HandCount -= report.HandCount;
                _data[report.Date].NormalCount -= report.NormalCount;
                _data[report.Date].PaySum -= report.PaySum;
            }
        }

        public Dictionary<DateTime, HandReport> Data => _data;
        public int Count => _data.Count;

        public List<HandReport> GetHandReports()
        {
            return _data.Select(r => r.Value).ToList();
        }

        public IEnumerator<HandReport> GetEnumerator()
        {
            foreach (HandReport report in _data.Values)
            {
                yield return report;
            }
        }
    }
}
