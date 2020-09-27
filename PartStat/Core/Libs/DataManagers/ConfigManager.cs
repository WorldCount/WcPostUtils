using System;
using System.Collections.Generic;
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
            Config configNds = new Config(ConfigName.Nds, "20");
            Config configValue = new Config(ConfigName.Value, "3");
            Config configStep = new Config(ConfigName.Step, "20");
            Config configMailStartWeight = new Config(ConfigName.MailStartWeight, "20");
            Config configMailEndWeight = new Config(ConfigName.MailEndWeight, "100");
            Config configParcelStartWeight = new Config(ConfigName.ParcelStartWeight, "100");
            Config configParcelEndWeight = new Config(ConfigName.ParcelEndWeight, "5000");
            Config configLastLoadReportDate = new Config(ConfigName.LastLoadReportDate, DateTime.Today.ToString(CultureInfo.InvariantCulture));

            List<Config> configs = new List<Config>
            {
                configNds,
                configValue,
                configStep,
                configMailStartWeight,
                configMailEndWeight,
                configParcelStartWeight,
                configParcelEndWeight,
                configLastLoadReportDate
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
    }
}
