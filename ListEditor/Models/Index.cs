using System.ComponentModel;
using System.Text.RegularExpressions;
using SQLite;

namespace ListEditor.Models
{
    public class Index
    {
        [PrimaryKey, AutoIncrement]
        [Browsable(false)]
        public int Id { get; set; }
        [DisplayName(@"Индекс")]
        public string Num { get; set; }
        [DisplayName(@"Имя")]
        public string Name { get; set; }
        [DisplayName(@"Тип")]
        public string Type { get; set; }
        [DisplayName(@"Подчинен")]
        public string Sub { get; set; }
        [DisplayName(@"Регион")]
        public string Region { get; set; }

        // ReSharper disable once InconsistentNaming
        public void DBFParse(object num, object name, object type, object sub, object region)
        {
            try
            {
                Num = ((string) num).Trim().ToUpper();
            }
            catch
            {
                Num = "";
            }

            try
            {
                Name = ((string) name).Trim().ToUpper();
            }
            catch
            {
                Name = "";
            }

            try
            {
                Type = ((string)type).Trim().ToUpper();
            }
            catch
            {
                Type = "";
            }

            try
            {
                Sub = ((string) sub).Trim().ToUpper();

            }
            catch
            {
                Sub = "";
            }

            try
            {
                Region = ((string) region).Trim().ToUpper();
            }
            catch
            {
                Region = "";
            }
        }

        public string GetName()
        {
            return Regex.Replace(Name, @"[\d]", string.Empty);
        }
    }
}
