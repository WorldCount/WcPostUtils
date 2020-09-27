using System;
using System.Collections.Generic;
using SQLite;
using SQLiteNetExtensions.Attributes;
using WcApi.Post.Types;

namespace AOP.Models
{
    [Table("List")]
    public class RpoList
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
        public long Category { get; set; } = 0;
        public int Count { get; set; } = 0;

        [Indexed]
        public DateTime Date { get; set; } = DateTime.Today;
        [OneToMany(CascadeOperations =  CascadeOperation.All)]
        public List<Rpo> Rpos { get; set; } = new List<Rpo>();

        [Ignore] public string CategoryName => MailCategories.GetById(Category).Name;
    }
}
