using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Installer.Models
{
    public class Token
    {
        public string Id { get; set; }

        public Token() { }

        public Token(string id)
        {
            Id = id;
        }
    }
}
