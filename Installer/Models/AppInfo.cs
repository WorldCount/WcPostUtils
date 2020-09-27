using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Dropbox.Api;
using Dropbox.Api.Sharing;
using WcApi.Xml;

namespace Installer.Models
{
    public class AppInfo
    {
        public string AppId { get; set; }
        public string RunFile { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Distr { get; set; }
        public string Version { get; set; }
        public string Md5 { get; set; }
        public List<string> Info { get; set; } = new List<string>();

        [XmlIgnore]
        public string DirectoryInstall { get; set; } = Properties.Settings.Default.RepoDir;
        [XmlIgnore]
        public bool Install { get; set; }
        [XmlIgnore]
        public string InstallValue => Install ? "Да" : "Нет";
        [XmlIgnore]
        public bool NeedUpdate { get; set; }
        [XmlIgnore]
        public string NeedUpdateValue => NeedUpdate ? "Да" : "Нет";
        [XmlIgnore]
        public string DistrName
        {
            get
            {
                if (!string.IsNullOrEmpty(Distr))
                {
                    FileInfo fileInfo = new FileInfo(new Uri(Distr).AbsolutePath);
                    return fileInfo.Name;
                }

                return "";
            }
        }
        [XmlIgnore]
        public string InstallPath => Path.Combine(DirectoryInstall, RunFile);

        [XmlIgnore]
        public Bitmap AppIcon
        {
            get
            {
                if(File.Exists(InstallPath))
                    return Icon.ExtractAssociatedIcon(InstallPath)?.ToBitmap();
                return null;
            }
        }

        public AppInfo() { }

        public AppInfo(string appId, string runFile, string name, string description, string distr, string version)
        {
            AppId = appId;
            RunFile = runFile;
            Name = name;
            Description = description;
            Distr = distr;
            Version = version;
        }
    }

    public class AppPackage
    {
        public List<AppInfo> Repo { get; set; } = new List<AppInfo>();

        // ReSharper disable once EmptyConstructor
        public AppPackage()
        {

        }

        public void Add(AppInfo appInfo)
        {
            Repo.Add(appInfo);
        }

        public AppInfo GetAppById(string appId)
        {
            return Repo.First(a => a.AppId.ToUpper() == appId.ToUpper());
        }

        public void Save(string filePath)
        {
            Serializer.Save(filePath, this);
        }

        public static AppPackage Load(string filePath)
        {
            if(!File.Exists(filePath))
                return new AppPackage();
            AppPackage appPackage = Serializer.Load<AppPackage>(filePath);
            return appPackage;
        }

        public static AppPackage Load(Uri uri)
        {
            return Serializer.Load<AppPackage>(uri);
        }

        public static async Task<AppPackage> Load(Token token, string link)
        {
            using (var dbx = new DropboxClient(token.Id))
            {
                using (var response = await dbx.Files.DownloadAsync(link))
                {
                    var s = response.GetContentAsStreamAsync();
                    s.Wait();
                    XmlSerializer serializer = new XmlSerializer(typeof(AppPackage));
                    AppPackage appPackage = (AppPackage) serializer.Deserialize(s.Result);
                    return appPackage;
                }
            }
        }

        public static async Task<AppPackage> LoadAsync(Uri uri)
        {
            return await Serializer.LoadAsync<AppPackage>(uri);
        }
    }
}
