using System.ComponentModel;

namespace ListEditor.Models
{
    public class Error
    {
        [DisplayName("Сообщение")]
        public string Message { get; set; }

        public Error()
        {

        }

        public Error(string message)
        {
            Message = message;
        }
    }
}
