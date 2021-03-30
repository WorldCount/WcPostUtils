namespace DwUtils.Core.Models.Firebird
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsValid { get; set; }
        public bool IsAdmin { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
