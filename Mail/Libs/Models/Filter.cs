using System.Collections.Generic;
using ServiceStack.DataAnnotations;

namespace Mail.Libs.Models
{
    [Alias("Filter")]
    public class Filter
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Required, Unique]
        public string Name { get; set; }

        [Reference]
        public List<Email> Emails { get; set; } = new List<Email>();
    }
}
