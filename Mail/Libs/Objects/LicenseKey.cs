using System.Windows.Forms;

namespace Mail.Libs.Objects
{
    public static class LicenseKey
    {
        public static string Key = WcApi.Cryptography.Md5Hash.GetMd5Hash($"{WcApi.Net.Host.GetIp()}{AuthKey.Key}{Application.ProductName}");
    }
}
