using System.Collections.Generic;
using System.Linq;

namespace AOP.Models
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
            get { return Data["Category"]; }
            set { Data["Category"] = value.ToUpper(); }
        }

        public string Comment
        {
            get { return Data["Comment"]; }
            set { Data["Comment"] = value; }
        }

        public string Address
        {
            get { return Data["Address"]; }
            set { Data["Address"] = value; }
        }

        public string City
        {
            get { return Data["City"]; }
            set { Data["City"] = value; }
        }

        public string Region
        {
            get { return Data["Region"]; }
            set { Data["Region"] = value; }
        }

        public string Rcpn
        {
            get { return Data["Rcpn"]; }
            set { Data["Rcpn"] = value; }
        }

        public string Index
        {
            get { return Data["Index"]; }
            set { Data["Index"] = value; }
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
