
namespace LK.Core.Store.ExportFile
{
    public class ExportFileString
    {
        public string OperType { get; set; } = "1";
        public string OperDate { get; set; }
        public string Barcode { get; set; }
        public string IndexTo { get; set; }
        public string MailDirect { get; set; } = "643";
        public string TransType { get; set; } = "1";
        public string MailType { get; set; }
        public string MailCtg { get; set; }
        public string MailRank { get; set; } = "0";
        public string SendCtg { get; set; } = "3";
        public string PostMark { get; set; } = "0";
        public string Mass { get; set; }
        public string Payment { get; set; } = "0";
        public string Value { get; set; } = "0";
        public string PayType { get; set; } = "2";
        public string MassRate { get; set; }
        public string InsrRate { get; set; } = "0";
        public string AirRate { get; set; } = "0";
        public string AdValTax { get; set; } = "0";
        public string SaleTax { get; set; } = "0";
        public string Rate { get; set; } = "0";
        public string OperAttr { get; set; } = "2";
        public string IndexOper { get; set; } = "125993";
        public string IndexNext { get; set; } = "";
        public string Comment { get; set; } = "P1.34.01.01;";
        // ReSharper disable once InconsistentNaming
        public string SNDRAddressData { get; set; } = "";
        // ReSharper disable once InconsistentNaming
        public string RCPNAddressData { get; set; } = "";
        public string NotifyAddressData { get; set; } = "";
        // ReSharper disable once InconsistentNaming
        public string NotificationRCPN { get; set; } = "";
        public string EmployeeData { get; set; } = "";
        public string ByProxy { get; set; } = "";
        // ReSharper disable once InconsistentNaming
        public string MPODeclaration { get; set; } = "";

        public override string ToString()
        {
            return Barcode;
        }

        public string ToExport()
        {
            string[] d = {OperType, OperDate, Barcode, IndexTo, MailDirect, TransType, MailType, MailCtg, MailRank, SendCtg, PostMark, 
                Mass, Payment, Value, PayType, MassRate, InsrRate, AirRate, AdValTax, SaleTax, Rate, OperAttr, IndexOper, IndexNext, 
                Comment, SNDRAddressData, RCPNAddressData, NotifyAddressData, NotificationRCPN, EmployeeData, ByProxy, MPODeclaration};

            return string.Join("|", d);
        }
    }
}
