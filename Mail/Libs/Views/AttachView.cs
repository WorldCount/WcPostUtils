using System;
using System.Drawing;

namespace Mail.Libs.Views
{

    public class AttachView
    {
        public string Name { get; set; }
        public string Ext { get; set; }
        public Image Picture { get; set; }
        public DateTime Date { get; set; }
        public string Id { get; set; }
    }
}
