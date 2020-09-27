using ServiceStack.DataAnnotations;

namespace Mail.Libs.Models
{
    [Alias("Email")]
    public class Email
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required, Unique]
        public string Text { get; set; }

        [Reference]
        public Filter Filter { get; set; }
        public int FilterId { get; set; }
    }
}
