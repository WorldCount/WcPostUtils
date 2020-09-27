using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using PartStat.Core.Models;
using WcApi.Xml;

namespace PartStat.Core.Libs.DataManagers
{
    public static class ConfigManager
    {
        public static void Save(List<Config> configs)
        {
            Serializer.Save(PathManager.ConfigPath, configs);
        }

        public static List<Config> Load()
        {
            if(!File.Exists(PathManager.ConfigPath))
                CreateDefault();
            return Serializer.Load<List<Config>>(PathManager.ConfigPath);
        }

        public static Config GetConfigByName(ConfigName configName)
        {
            List<Config> configs = Load();
            return configs.FirstOrDefault(c => c.Name == configName);
        }

        public static void CreateDefault()
        {
            Config configNds = CreateDefaultNds();
            Config configValue = CreateDefaultValue();
            Config configStep = CreateDefaultStep();
            Config configMailStartWeight = CreateDefaultMailStartWeight();
            Config configMailEndWeight = CreateDefaulMailEndWeight();
            Config configParcelStartWeight = CreateDefaultParcelStartWeight();
            Config configParcelEndWeight = CreateDefaultParcelEndWeight();
            Config configLastLoadReportDate = CreateDefaultLastLoadReportDate();
            Config configDefaultPrinterName = CreateDefaultPrinterName();

            List<Config> configs = new List<Config>
            {
                configNds,
                configValue,
                configStep,
                configMailStartWeight,
                configMailEndWeight,
                configParcelStartWeight,
                configParcelEndWeight,
                configLastLoadReportDate,
                configDefaultPrinterName
            };

            Save(configs);
        }

        public static void Update(ConfigName configName, Config config)
        {
            List<Config> configs = Load();
            int index = configs.FindIndex(c => c.Name == configName);
            if (index > -1)
                configs[index] = config;
            else
                configs.Add(config);
            Save(configs);
        }

        #region Default Config

        public static Config CreateDefaultNds()
        {
            return new Config(ConfigName.Nds, "20");
        }

        public static Config CreateDefaultValue()
        {
            return new Config(ConfigName.Value, "3");
        }


        public static Config CreateDefaultStep()
        {
            return new Config(ConfigName.Step, "20");
        }

        public static Config CreateDefaultMailStartWeight()
        {
            return new Config(ConfigName.MailStartWeight, "20");
        }

        public static Config CreateDefaulMailEndWeight()
        {
            return new Config(ConfigName.MailEndWeight, "100");
        }


        public static Config CreateDefaultParcelStartWeight()
        {
            return new Config(ConfigName.ParcelStartWeight, "100");
        }

        public static Config CreateDefaultParcelEndWeight()
        {
            return new Config(ConfigName.ParcelEndWeight, "5000");
        }
        public static Config CreateDefaultLastLoadReportDate()
        {
            return new Config(ConfigName.LastLoadReportDate, DateTime.Today.ToString(CultureInfo.InvariantCulture));
        }

        public static Config CreateDefaultPrinterName()
        {
            PrinterSettings settings = new PrinterSettings();
            return new Config(ConfigName.DefaultPrinterName, settings.PrinterName);
        }

        #endregion
    }
}
