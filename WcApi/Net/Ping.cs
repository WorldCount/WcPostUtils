using System.Diagnostics;
using System.Text;

namespace WcApi.Net
{
    public static class Ping
    {
        public static bool GetPing(string host)
        {
            Process cmd = new Process
            {
                StartInfo =
                {
                    StandardOutputEncoding = Encoding.GetEncoding("cp866"),
                    FileName = "cmd.exe",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    UseShellExecute = false
                }
            };
            cmd.Start();

            cmd.StandardInput.WriteLine($"ping -n 1 -w 1 {host}");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();

            string result = cmd.StandardOutput.ReadToEnd();
            return result.ToUpper().Contains("TTL");
        }
    }
}
