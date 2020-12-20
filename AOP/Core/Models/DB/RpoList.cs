using System;
using System.Collections.Generic;
using SQLite;
using SQLiteNetExtensions.Attributes;
using WcApi.Post.Types;

namespace AOP.Core.Models.DB
{
    public class RpoList
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public int Num { get; set; }
        public string Name { get; set; }
        public long Type { get; set; } = 1;
        public long Category { get; set; } = 0;
        public int Count { get; set; } = 0;
        public int ErrorCount { get; set; } = 0;

        [Indexed]
        public DateTime Date { get; set; } = DateTime.Today;

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Rpo> Rpos { get; set; } = new List<Rpo>();

        [Ignore] public bool Check { get; set; } = true;
        [Ignore] public string CategoryName => MailCategories.GetById(Category).Name;
        [Ignore] public string TypeName => MailTypes.GetById(Type).Name;

        public string GetFileName()
        {
            string s = $"{CategoryName[0]}{TypeName[0]}".ToUpper();
            string r = $"{Date.ToShortDateString()} АОП Сп {Num} {s}";
            return r;
        }

        public string GetFileNameExcel()
        {
            return $"{GetFileName()}.xls";
        }

        public string GetFileNameWord(string format = "C5")
        {
            return $"{GetFileName()} {format}.doc";
        }
    }
}
