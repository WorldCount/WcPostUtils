
namespace Barcodes.Libs.DB.Queryes
{
    public class FirmQuery : Query
    {
        public FirmQuery(Connect connect) : base(connect)
        {
        }

        public new string GetQuery()
        {
            return "select firm_name, inn from FIRMS order by firm_name";
        }
    }
}
