using System.Collections.Generic;
using SQLiteNetExtensions.Attributes;

namespace LK.Core.Models.DB
{
    public class Operator
    {
        [SQLite.PrimaryKey, SQLite.AutoIncrement]
        public int Id { get; set; }

        [SQLite.Indexed] 
        public string FullName { get; set; } = "";

        public string LastName { get; set; } = "";
        public string FirstName { get; set; } = "";
        public string MiddleName { get; set; } = "";

        public string ShortName
        {
            get
            {
                if(!string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName))
                    return $"{LastName} {FirstName[0]}. {MiddleName[0]}.";
                return LastName;
            }
        }

        public Operator() { }

        public Operator(string fullName)
        {
            FullName = fullName;
            string[] names = fullName.Split(' ');

            if (names.Length == 3)
            {
                FirstName = names[1];
                LastName = names[0];
                MiddleName = names[2];
            }

            if (names.Length == 2)
            {
                LastName = names[0].ToUpper();
            }
        }

        public override string ToString()
        {
            return ShortName;
        }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<FirmList> FirmLists { get; set; } = new List<FirmList>();

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Rpo> Rpos { get; set; } = new List<Rpo>();
    }
}
