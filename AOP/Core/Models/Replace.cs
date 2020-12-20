using System.Collections.Generic;
using System.Linq;
using AOP.Core.Models.DB;

namespace AOP.Core.Models
{
    public class Replace
    {
        public Dictionary<string, string> Data = new Dictionary<string, string>
        {
            {"Category", "ПРОСТОЕ" },
            {"Comment", "" },
            {"Address", "" },
            {"City", "" },
            {"Region", "" },
            {"Rcpn", "" },
            {"Index", "" }
        };

        #region Поля

        public string Category
        {
            get => Data["Category"];
            set => Data["Category"] = value.ToUpper();
        }

        public string Comment
        {
            get => Data["Comment"];
            set => Data["Comment"] = value;
        }

        public string Address
        {
            get => Data["Address"];
            set => Data["Address"] = value;
        }

        public string City
        {
            get => Data["City"];
            set => Data["City"] = value;
        }

        public string Region
        {
            get => Data["Region"];
            set => Data["Region"] = value;
        }

        public string Rcpn
        {
            get => Data["Rcpn"];
            set => Data["Rcpn"] = value;
        }

        public string Index
        {
            get => Data["Index"];
            set => Data["Index"] = value;
        }

        #endregion

        public string[] Keys => Data.Keys.ToArray();

        public Replace() { }

        public Replace(Rpo rpo, string category = "ПРОСТОЕ")
        {
            Category = category;
            Comment = rpo.Comment;
            Address = rpo.Address;
            City = rpo.PlaceTo;
            Region = rpo.Region;
            Rcpn = rpo.Rcpn;
            Index = rpo.Index;
        }
    }
}
