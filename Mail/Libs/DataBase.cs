using Mail.Libs.Models;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail.Libs
{
    public static class DataBase
    {
        public static List<Filter> LoadAllFilters(OrmLiteConnectionFactory dbFactory)
        {
            using (var db = dbFactory.Open())
            {
                List<Filter> filters = db.LoadSelect<Filter>().OrderBy(f => f.Name).ToList();
                return filters;
            }
        }
    }
}
