using System;
using System.Drawing;
using Microsoft.Exchange.WebServices.Data;

namespace Mail.Libs.Views
{
    public class MailView
    {
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int AttachCount { get; set; }
        public ItemId Id { get; set; }
        public Image Picture { get; set; }
        public bool IsRead { get; set; }
    }
}
