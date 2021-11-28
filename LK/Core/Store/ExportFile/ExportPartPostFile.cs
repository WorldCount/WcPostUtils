using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LK.Core.Store.ExportFile
{
    public class ExportPartPostFile
    {
        private string _header = "OperType|OperDate|Barcode|IndexTo|MailDirect|TransType|MailType|MailCtg|MailRank|SendCtg|PostMark|Mass|Payment|Value|PayType|MassRate|InsrRate|AirRate|AdValTax|SaleTax|Rate|OperAttr|IndexOper|IndexNext|Comment|SNDRAddressData|RCPNAddressData|NotifyAddressData|NotificationRCPN|EmployeeData|ByProxy|MPODeclaration";
        private readonly List<ExportFileString> _data;
        private string _name = "12599302.09F";

        public ExportPartPostFile()
        {
            _data = new List<ExportFileString>();
        }

        public void Add(ExportFileString exportFileString)
        {
            _data.Add(exportFileString);
        }

        public void ExportToFile(string path)
        {
            if (!File.Exists(path))
                Directory.CreateDirectory(path);

            string exportFilePath = Path.Combine(path, _name);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(_header);
            foreach (ExportFileString exportFileString in _data)
                sb.AppendLine(exportFileString.ToExport());

            File.WriteAllText(exportFilePath, sb.ToString(), Encoding.GetEncoding("cp866"));
        }
    }
}
