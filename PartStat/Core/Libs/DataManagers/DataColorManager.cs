using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using PartStat.Core.Models;
using WcApi.Xml;

namespace PartStat.Core.Libs.DataManagers
{

    public static class DataColorManager
    {
        public static void Save(List<DataColor> colors)
        {
            Serializer.Save(PathManager.DataColorPath, colors);
        }

        public static List<DataColor> Load()
        {
            if(!File.Exists(PathManager.DataColorPath))
                CreateDefault();
            return Serializer.Load<List<DataColor>>(PathManager.DataColorPath);
        }

        public static DataColor GetDataColorByName(ColorName name)
        {
            List<DataColor> colors = Load();
            return colors.FirstOrDefault(c => c.Name == name);
        }

        public static void CreateDefault()
        {
            DataColor warnBack = new DataColor(ColorName.WarnBack, Color.FromArgb(255, 225, 228, 181));
            DataColor warnFore = new DataColor(ColorName.WarnFore, Color.FromArgb(255, 53, 56, 58));
            DataColor errorBack = new DataColor(ColorName.ErrorBack, Color.IndianRed);
            DataColor errorFore = new DataColor(ColorName.ErrorFore, Color.White);

            List<DataColor> dataColors = new List<DataColor>
            {
                warnBack, warnFore, errorBack, errorFore
            };

            Save(dataColors);
        }
    }
}
