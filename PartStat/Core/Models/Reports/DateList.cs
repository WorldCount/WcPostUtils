using System;
using System.Collections.Generic;
using System.Linq;
using PartStat.Core.Models.DB;

namespace PartStat.Core.Models.Reports
{
    public class DateList
    {
        public DateTime Date { get; set; }
        public List<int> NumsList { get; set; }

        public int Count => NumsList.Count;

        public string NumsToString()
        {
            return string.Join(", ", NumsList);
        }

        public DateList() { }

        public DateList(FirmList firmList)
        {
            Date = firmList.Date;
            NumsList = new List<int>{firmList.Num};
        }

        public DateList(List<FirmList> firmLists)
        {
            if (firmLists.Count > 0)
            {
                Date = firmLists[0].Date;
                NumsList = firmLists.OrderBy(f => f.Num).Select(f => f.Num).ToList();
            }
        }
    }


}
