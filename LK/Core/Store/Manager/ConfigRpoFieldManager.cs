using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LK.Core.Libs.Configs;
using WcApi.Xml;

namespace LK.Core.Store.Manager
{
    public class ConfigRpoFieldManager : IDisposable
    {
        private List<ConfigRpoField> _configRpoFields;

        #region Свойства

        public List<ConfigRpoField> ConfigRpoFields
        {
            get => _configRpoFields;
            set => _configRpoFields = value;
        }

        public ConfigRpoField ListDate { get; private set; }
        public ConfigRpoField ListNum { get; private set; }

        public ConfigRpoField FirmName { get; private set; }
        public ConfigRpoField Inn { get; private set; }
        public ConfigRpoField Kpp { get; private set; }
        public ConfigRpoField Contract { get; private set; }
        public ConfigRpoField Barcode { get; private set; }

        public ConfigRpoField Type { get; private set; }
        public ConfigRpoField Category { get; private set; }

        public ConfigRpoField MassRate { get; private set; }
        public ConfigRpoField NoticeRate { get; private set; }
        public ConfigRpoField AviaRate { get; private set; }
        public ConfigRpoField Value { get; private set; }
        public ConfigRpoField ValueRate { get; private set; }

        public ConfigRpoField Status { get; private set; }
        public ConfigRpoField StatusMessage { get; private set; }

        public ConfigRpoField ReceptDate { get; private set; }
        public ConfigRpoField Oper { get; private set; }
        public ConfigRpoField Ops { get; private set; }
        public ConfigRpoField Index { get; private set; }
        public ConfigRpoField Address { get; private set; }

        #endregion

        public void Save()
        {
            Serializer.Save(PathManager.RposFieldsPath, _configRpoFields);
        }

        public void Load()
        {
            if (!File.Exists(PathManager.RposFieldsPath))
                CreateDefault();

            _configRpoFields = Serializer.Load<List<ConfigRpoField>>(PathManager.RposFieldsPath);

            ConfigsToProperty();
        }

        public async void LoadAsync()
        {
            if (!File.Exists(PathManager.RposFieldsPath))
                CreateDefault();

            _configRpoFields = await Serializer.LoadAsync<List<ConfigRpoField>>(PathManager.RposFieldsPath);

            ConfigsToProperty();
        }

        public ConfigRpoField GetConfigRpoFieldByType(ConfigRowRpoType type)
        {
            return _configRpoFields.FirstOrDefault(c => c.Type == type);
        }

        public void DecrementRowNum()
        {
            ListDate.NumColumn -= 1;
            ListNum.NumColumn -= 1;

            FirmName.NumColumn -= 1;
            Inn.NumColumn -= 1;
            Kpp.NumColumn -= 1;
            Contract.NumColumn -= 1;

            Barcode.NumColumn -= 1;

            Type.NumColumn -= 1;
            Category.NumColumn -= 1;

            MassRate.NumColumn -= 1;
            NoticeRate.NumColumn -= 1;
            AviaRate.NumColumn -= 1;
            Value.NumColumn -= 1;
            ValueRate.NumColumn -= 1;

            Status.NumColumn -= 1;
            StatusMessage.NumColumn -= 1;

            ReceptDate.NumColumn -= 1;

            Oper.NumColumn -= 1;
            Ops.NumColumn -= 1;
            Index.NumColumn -= 1;
            Address.NumColumn -= 1;
        }

        public void IncrementRowNum()
        {
            ListDate.NumColumn += 1;
            ListNum.NumColumn += 1;

            FirmName.NumColumn += 1;
            Inn.NumColumn += 1;
            Kpp.NumColumn += 1;
            Contract.NumColumn += 1;

            Barcode.NumColumn += 1;

            Type.NumColumn += 1;
            Category.NumColumn += 1;

            MassRate.NumColumn += 1;
            NoticeRate.NumColumn += 1;
            AviaRate.NumColumn += 1;
            Value.NumColumn += 1;
            ValueRate.NumColumn += 1;

            Status.NumColumn += 1;
            StatusMessage.NumColumn += 1;

            ReceptDate.NumColumn += 1;

            Oper.NumColumn += 1;
            Ops.NumColumn += 1;
            Index.NumColumn += 1;
            Address.NumColumn += 1;
        }

        private void ConfigsToProperty()
        {
            ListDate = GetConfigRpoFieldByType(ConfigRowRpoType.ListDate);
            ListNum = GetConfigRpoFieldByType(ConfigRowRpoType.ListNum);

            FirmName = GetConfigRpoFieldByType(ConfigRowRpoType.FirmName);
            Inn = GetConfigRpoFieldByType(ConfigRowRpoType.Inn);
            Kpp = GetConfigRpoFieldByType(ConfigRowRpoType.Kpp);
            Contract = GetConfigRpoFieldByType(ConfigRowRpoType.NumDog);

            Barcode = GetConfigRpoFieldByType(ConfigRowRpoType.Barcode);

            Type = GetConfigRpoFieldByType(ConfigRowRpoType.Type);
            Category = GetConfigRpoFieldByType(ConfigRowRpoType.Category);

            MassRate = GetConfigRpoFieldByType(ConfigRowRpoType.MassRate);
            NoticeRate = GetConfigRpoFieldByType(ConfigRowRpoType.NoticeRate);
            AviaRate = GetConfigRpoFieldByType(ConfigRowRpoType.AviaRate);
            Value = GetConfigRpoFieldByType(ConfigRowRpoType.Value);
            ValueRate = GetConfigRpoFieldByType(ConfigRowRpoType.ValueRate);

            Status = GetConfigRpoFieldByType(ConfigRowRpoType.Status);
            StatusMessage = GetConfigRpoFieldByType(ConfigRowRpoType.StatusMessage);

            ReceptDate = GetConfigRpoFieldByType(ConfigRowRpoType.ReceptDate);

            Oper = GetConfigRpoFieldByType(ConfigRowRpoType.Operator);
            Ops = GetConfigRpoFieldByType(ConfigRowRpoType.Ops);
            Index = GetConfigRpoFieldByType(ConfigRowRpoType.Index);
            Address = GetConfigRpoFieldByType(ConfigRowRpoType.Address);
        }

        private void CreateDefault()
        {
            _configRpoFields = GetDefault();
            Save();
        }

        private List<ConfigRpoField> GetDefault()
        {
            List<ConfigRpoField> configRpoFields = new List<ConfigRpoField>();


            ListDate = new ConfigRpoField { Desc = "Дата списка", NumColumn = 1, Type = ConfigRowRpoType.ListDate };
            ListNum = new ConfigRpoField { Desc = "Номер списка", NumColumn = 2, Type = ConfigRowRpoType.ListNum };

            FirmName = new ConfigRpoField { Desc = "Отправитель", NumColumn = 3, Type = ConfigRowRpoType.FirmName };
            Inn = new ConfigRpoField { Desc = "ИНН", NumColumn = 4, Type = ConfigRowRpoType.Inn };
            Kpp = new ConfigRpoField { Desc = "КПП", NumColumn = 5, Type = ConfigRowRpoType.Kpp };
            Contract = new ConfigRpoField { Desc = "Номер договора", NumColumn = 6, Type = ConfigRowRpoType.NumDog };

            Barcode = new ConfigRpoField { Desc = "ШПИ отправления", NumColumn = 7, Type = ConfigRowRpoType.Barcode };

            Type = new ConfigRpoField { Desc = "Вид ПО", NumColumn = 8, Type = ConfigRowRpoType.Type };
            Category = new ConfigRpoField { Desc = "Категория ПО", NumColumn = 9, Type = ConfigRowRpoType.Category };

            MassRate = new ConfigRpoField { Desc = "Сумма весового сбора", NumColumn = 11, Type = ConfigRowRpoType.MassRate };
            NoticeRate = new ConfigRpoField { Desc = "Плата за доп. услуги", NumColumn = 12, Type = ConfigRowRpoType.NoticeRate };
            AviaRate = new ConfigRpoField { Desc = "Сумма авиатарифа", NumColumn = 13, Type = ConfigRowRpoType.AviaRate };
            Value = new ConfigRpoField { Desc = "Сумма объявленной ценности", NumColumn = 14, Type = ConfigRowRpoType.Value };
            ValueRate = new ConfigRpoField { Desc = "Сумма платы за объявленную ценность", NumColumn = 15, Type = ConfigRowRpoType.ValueRate };

            Status = new ConfigRpoField { Desc = "Статус отправления", NumColumn = 16, Type = ConfigRowRpoType.Status };
            StatusMessage = new ConfigRpoField { Desc = "Причина брака", NumColumn = 17, Type = ConfigRowRpoType.StatusMessage };

            ReceptDate = new ConfigRpoField { Desc = "Дата приема списка", NumColumn = 18, Type = ConfigRowRpoType.ReceptDate };

            Oper = new ConfigRpoField { Desc = "ФИО оператора", NumColumn = 19, Type = ConfigRowRpoType.Operator };
            Ops = new ConfigRpoField { Desc = "Индекс ОПС", NumColumn = 20, Type = ConfigRowRpoType.Ops };
            Index = new ConfigRpoField { Desc = "Индекс назначения", NumColumn = 21, Type = ConfigRowRpoType.Index };
            Address = new ConfigRpoField { Desc = "Адрес назначения", NumColumn = 22, Type = ConfigRowRpoType.Address };

            configRpoFields.AddRange(new List<ConfigRpoField>
            {
                ListDate, ListNum,
                FirmName, Inn, Kpp, Contract, Barcode,
                Type, Category, 
                MassRate, NoticeRate, AviaRate, Value, ValueRate,
                Status, StatusMessage,
                ReceptDate,
                Oper, Ops, Index, Address
            });

            return configRpoFields;
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

            MassRate = null;
            NoticeRate = null;
            AviaRate = null;
            Value = null;
            ValueRate = null;

            Status = null;
            StatusMessage = null;

            ReceptDate = null;

            Oper = null;
            Ops = null;
            Index = null;
            Address = null;

            _configRpoFields = null;
        }
    }
}
