using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Installer.Models
{
    public class AppData
    {
        public List<AppInfo> RepoAppInfos { get; set; } = new List<AppInfo>();
        public List<AppInfo> InstallAppInfos { get; set; } = new List<AppInfo>();
    }
}
