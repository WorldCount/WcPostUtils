using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace WcApi.Net
{
    public static class Host
    {
        public static string GetIp()
        {
            string host = Dns.GetHostName();
            List<IPAddress> ipAddresses = Dns.GetHostAddresses(host).Where(a => a.AddressFamily == AddressFamily.InterNetwork).ToList();
            return ipAddresses.Count > 0 ? ipAddresses[0].ToString() : "localhost";
        }
    }
}
