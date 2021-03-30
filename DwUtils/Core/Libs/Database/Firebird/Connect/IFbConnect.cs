namespace DwUtils.Core.Libs.Database.Firebird.Connect
{
    public interface IFbConnect
    {
        string Host { get; set; }
        string Path { get; set; }
        int Port { get; set; }
        string Login { get; set; }
        string Password { get; set; }
        int ServerType { get; set; }
        string Charset { get; set; }
        int WireCrypt { get; set; }

        string ToString();
    }
}
