using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LK.Core.Libs.Configs;
using WcApi.Xml;

namespace LK.Core.Store.Manager
{
    public class ConfigFirmFieldManager : IDisposable
    {
        private List<ConfigFirmField> _configFirmFields;

        #region Свойства

        public List<ConfigFirmField> ConfigFirmFields
        {
            get => _configFirmFields;
            set => _configFirmFields = value;

        }

        public ConfigFirmField ListDate { get; private set; }
        public ConfigFirmField ListNum { get; private set; }

        public ConfigFirmField FirmName { get; private set; }
        public ConfigFirmField Inn { get; private set; }
        public ConfigFirmField Kpp { get; private set; }
        public ConfigFirmField Contract { get; private set; }

        public ConfigFirmField Type { get; private set; }
        public ConfigFirmField Category { get; private set; }
        public ConfigFirmField AllCount { get; private set; }
        public ConfigFirmField FactCount { get; private set; }
        public ConfigFirmField ReturnCount { get; private set; }
        public ConfigFirmField MissCount { get; private set; }

        public ConfigFirmField MassRate { get; private set; }
        public ConfigFirmField AviaRate { get; private set; }
        public ConfigFirmField Value { get; private set; }
        public ConfigFirmField ValueRate { get; private set; }

        public ConfigFirmField ReceptDate { get; private set; }
        public ConfigFirmField Oper { get; private set; }
        public ConfigFirmField OpsIndex { get; private set; }

        #endregion

        public void Save()
        {
            Serializer.Save(PathManager.FirmsFieldsPath, _configFirmFields);
        }

        public void Load()
        {
            if (!File.Exists(PathManager.FirmsFieldsPath))
                CreateDefault();

            _configFirmFields = Serializer.Load<List<ConfigFirmField>>(PathManager.FirmsFieldsPath);

            ConfigsToProperty();
        }

        public async void LoadAsync()
        {
            if (!File.Exists(PathManager.FirmsFieldsPath))
                CreateDefault();

            _configFirmFields = await Serializer.LoadAsync<List<ConfigFirmField>>(PathManager.FirmsFieldsPath);

            ConfigsToProperty();
        }

        public ConfigFirmField GetConfigFirmFieldByType(ConfigRowFirmType type)
        {
            return _configFirmFields.FirstOrDefault(c => c.Type == type);
        }

        public void DecrementRowNum()
        {
            ListDate.NumColumn -= 1;
            ListNum.NumColumn -= 1;

            FirmName.NumColumn -= 1;
            Inn.NumColumn -= 1;
            Kpp.NumColumn -= 1;
            Contract.NumColumn -= 1;

            Type.NumColumn -= 1;
            Category.NumColumn -= 1;
            AllCount.NumColumn -= 1;
            FactCount.NumColumn -= 1;
            ReturnCount.NumColumn -= 1;
            MissCount.NumColumn -= 1;

            MassRate.NumColumn -= 1;
            AviaRate.NumColumn -= 1;
            Value.NumColumn -= 1;
            ValueRate.NumColumn -= 1;

            ReceptDate.NumColumn -= 1;

            Oper.NumColumn -= 1;
            OpsIndex.NumColumn -= 1;
        }

        public void IncrementRowNum()
        {
            ListDate.NumColumn += 1;
            ListNum.NumColumn += 1;

            FirmName.NumColumn += 1;
            Inn.NumColumn += 1;
            Kpp.NumColumn += 1;
            Contract.NumColumn += 1;

            Type.NumColumn += 1;
            Category.NumColumn += 1;
            AllCount.NumColumn += 1;
            FactCount.NumColumn += 1;
            ReturnCount.NumColumn += 1;
            MissCount.NumColumn += 1;

            MassRate.NumColumn += 1;
            AviaRate.NumColumn += 1;
            Value.NumColumn += 1;
            ValueRate.NumColumn += 1;

            ReceptDate.NumColumn += 1;

            Oper.NumColumn += 1;
            OpsIndex.NumColumn += 1;
        }

        private void ConfigsToProperty()
        {
            ListDate = GetConfigFirmFieldByType(ConfigRowFirmType.ListDate);
            ListNum = GetConfigFirmFieldByType(ConfigRowFirmType.ListNum);

            FirmName = GetConfigFirmFieldByType(ConfigRowFirmType.FirmName);
            Inn = GetConfigFirmFieldByType(ConfigRowFirmType.Inn);
            Kpp = GetConfigFirmFieldByType(ConfigRowFirmType.Kpp);
            Contract = GetConfigFirmFieldByType(ConfigRowFirmType.NumDog);

            Type = GetConfigFirmFieldByType(ConfigRowFirmType.Type);
            Category = GetConfigFirmFieldByType(ConfigRowFirmType.Category);
            AllCount = GetConfigFirmFieldByType(ConfigRowFirmType.AllCount);
            FactCount = GetConfigFirmFieldByType(ConfigRowFirmType.FactCount);
            ReturnCount = GetConfigFirmFieldByType(ConfigRowFirmType.ReturnCount);
            MissCount = GetConfigFirmFieldByType(ConfigRowFirmType.MissCount);

            MassRate = GetConfigFirmFieldByType(ConfigRowFirmType.MassRate);
            AviaRate = GetConfigFirmFieldByType(ConfigRowFirmType.AviaRate);
            Value = GetConfigFirmFieldByType(ConfigRowFirmType.Value);
            ValueRate = GetConfigFirmFieldByType(ConfigRowFirmType.ValueRate);

            ReceptDate = GetConfigFirmFieldByType(ConfigRowFirmType.ReceptDate);

            Oper = GetConfigFirmFieldByType(ConfigRowFirmType.Operator);
            OpsIndex = GetConfigFirmFieldByType(ConfigRowFirmType.OpsIndex);
        }

        private void CreateDefault()
        {
            _configFirmFields = GetDefault();
            Save();
        }

        private List<ConfigFirmField> GetDefault()
        {
            List<ConfigFirmField> configFirmFields = new List<ConfigFirmField>();


            ListDate = new ConfigFirmField { Desc = "Дата списка", NumColumn = 1, Type = ConfigRowFirmType.ListDate };
            ListNum = new ConfigFirmField { Desc = "Номер списка", NumColumn = 2, Type = ConfigRowFirmType.ListNum };

            FirmName = new ConfigFirmField { Desc = "Отправитель", NumColumn = 3, Type = ConfigRowFirmType.FirmName };
            Inn = new ConfigFirmField { Desc = "ИНН", NumColumn = 5, Type = ConfigRowFirmType.Inn };
            Kpp = new ConfigFirmField { Desc = "КПП", NumColumn = 6, Type = ConfigRowFirmType.Kpp };
            Contract = new ConfigFirmField { Desc = "Номер договора", NumColumn = 7, Type = ConfigRowFirmType.NumDog };

            Type = new ConfigFirmField {Desc = "Вид ПО", NumColumn = 8, Type = ConfigRowFirmType.Type };
            Category = new ConfigFirmField {Desc = "Категория ПО", NumColumn = 9, Type = ConfigRowFirmType.Category };
            AllCount = new ConfigFirmField {Desc = "Количество отправлений в списке", NumColumn = 10, Type = ConfigRowFirmType.AllCount };
            FactCount = new ConfigFirmField {Desc = "Количество отсканированных отправлений", NumColumn = 11, Type = ConfigRowFirmType.FactCount };
            ReturnCount = new ConfigFirmField {Desc = "Количество отправлений на возврат", NumColumn = 12, Type = ConfigRowFirmType.ReturnCount };
            MissCount = new ConfigFirmField {Desc = "Отсутствует отпрвлений", NumColumn = 13, Type = ConfigRowFirmType.MissCount };

            MassRate = new ConfigFirmField {Desc = "Сумма весового сбора", NumColumn = 14, Type = ConfigRowFirmType.MassRate };
            AviaRate = new ConfigFirmField {Desc = "Сумма авиатарифа", NumColumn = 15, Type = ConfigRowFirmType.AviaRate };
            Value = new ConfigFirmField {Desc = "Сумма объявленной ценности", NumColumn = 16, Type = ConfigRowFirmType.Value };
            ValueRate = new ConfigFirmField {Desc = "Сумма платы за объявленную ценность", NumColumn = 17, Type = ConfigRowFirmType.ValueRate };

            ReceptDate = new ConfigFirmField {Desc = "Дата приема списка", NumColumn = 18, Type = ConfigRowFirmType.ReceptDate };

            Oper = new ConfigFirmField {Desc = "ФИО оператора", NumColumn = 19, Type = ConfigRowFirmType.Operator };
            OpsIndex = new ConfigFirmField {Desc = "Индекс ОПС", NumColumn = 20, Type = ConfigRowFirmType.OpsIndex };

            configFirmFields.AddRange(new List<ConfigFirmField>
            {
                ListDate, ListNum, 
                FirmName, Inn, Kpp, Contract,
                Type, Category, AllCount, FactCount, ReturnCount, MissCount, 
                MassRate, AviaRate, Value, ValueRate, 
                ReceptDate, 
                Oper, OpsIndex
            });

            return configFirmFields;
        }

        public void Dispose()
        {
            
            ListDate = null;
            ListNum = null;

            FirmName = null;
            Inn = null;
            Kpp = null;
            Contract = null;

            Type = null;
            Category = null;
            AllCount = null;
            FactCount = null;
            ReturnCount = null;
            MissCount = null;

            MassRate = null;
            AviaRate = null;
            Value = null;
            ValueRate = null;

            ReceptDate = null;

            Oper = null;
            OpsIndex = null;

            _configFirmFields = null;
        }
    }
}
