using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LK.Core.Libs.Configs;
using WcApi.Xml;

namespace LK.Core.Store.Manager.FileManager
{
    public class ConfigDataFieldManager : IDisposable
    {
        #region Private Fields

        private List<ConfigDataField> _configDataFields;

        #endregion

        #region Public Properties

        public List<ConfigDataField> ConfigDataFields
        {
            get => _configDataFields;
            set => _configDataFields = value;
        }

        public ConfigDataField ListDate { get; private set; }
        public ConfigDataField ListNum { get; private set; }
        public ConfigDataField TransType { get; private set; }

        public ConfigDataField FirmName { get; private set; }
        public ConfigDataField Inn { get; private set; }
        public ConfigDataField Kpp { get; private set; }
        public ConfigDataField Contract { get; private set; }
        public ConfigDataField Barcode { get; private set; }

        public ConfigDataField Type { get; private set; }
        public ConfigDataField Category { get; private set; }

        public ConfigDataField MassRate { get; private set; }
        public ConfigDataField NoticeRate { get; private set; }
        public ConfigDataField AviaRate { get; private set; }
        public ConfigDataField Value { get; private set; }
        public ConfigDataField ValueRate { get; private set; }

        public ConfigDataField Status { get; private set; }
        public ConfigDataField StatusMessage { get; private set; }

        public ConfigDataField ReceptDate { get; private set; }
        public ConfigDataField Oper { get; private set; }
        public ConfigDataField Ops { get; private set; }
        public ConfigDataField Index { get; private set; }
        public ConfigDataField Address { get; private set; }

        #endregion

        #region Public Methods

        public void Save()
        {
            Serializer.Save(PathManager.DataFieldsPath, _configDataFields);
        }

        public void Load()
        {
            if (!File.Exists(PathManager.DataFieldsPath))
                CreateDefault();

            _configDataFields = Serializer.Load<List<ConfigDataField>>(PathManager.DataFieldsPath);

            ConfigsToProperty();
        }

        public async void LoadAsync()
        {
            if (!File.Exists(PathManager.DataFieldsPath))
                CreateDefault();

            _configDataFields = await Serializer.LoadAsync<List<ConfigDataField>>(PathManager.DataFieldsPath);

            ConfigsToProperty();
        }

        public ConfigDataField GetConfigDataByType(ConfigDataFieldType type)
        {
            return _configDataFields.FirstOrDefault(c => c.Type == type);
        }

        public void DecrementRowNum()
        {
            ListDate.NumColumn -= 1;
            ListNum.NumColumn -= 1;
            TransType.NumColumn -= 1;

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
            TransType.NumColumn += 1;

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

        #endregion

        #region Private Methods

        private void ConfigsToProperty()
        {
            ListDate = GetConfigDataByType(ConfigDataFieldType.ListDate);
            ListNum = GetConfigDataByType(ConfigDataFieldType.ListNum);
            TransType = GetConfigDataByType(ConfigDataFieldType.TransType);

            FirmName = GetConfigDataByType(ConfigDataFieldType.FirmName);
            Inn = GetConfigDataByType(ConfigDataFieldType.Inn);
            Kpp = GetConfigDataByType(ConfigDataFieldType.Kpp);
            Contract = GetConfigDataByType(ConfigDataFieldType.NumDog);

            Barcode = GetConfigDataByType(ConfigDataFieldType.Barcode);

            Type = GetConfigDataByType(ConfigDataFieldType.Type);
            Category = GetConfigDataByType(ConfigDataFieldType.Category);

            MassRate = GetConfigDataByType(ConfigDataFieldType.MassRate);
            NoticeRate = GetConfigDataByType(ConfigDataFieldType.NoticeRate);
            AviaRate = GetConfigDataByType(ConfigDataFieldType.AviaRate);
            Value = GetConfigDataByType(ConfigDataFieldType.Value);
            ValueRate = GetConfigDataByType(ConfigDataFieldType.ValueRate);

            Status = GetConfigDataByType(ConfigDataFieldType.Status);
            StatusMessage = GetConfigDataByType(ConfigDataFieldType.StatusMessage);

            ReceptDate = GetConfigDataByType(ConfigDataFieldType.ReceptDate);

            Oper = GetConfigDataByType(ConfigDataFieldType.Operator);
            Ops = GetConfigDataByType(ConfigDataFieldType.Ops);
            Index = GetConfigDataByType(ConfigDataFieldType.Index);
            Address = GetConfigDataByType(ConfigDataFieldType.Address);
        }

        private void CreateDefault()
        {
            _configDataFields = GetDefault();
            Save();
        }

        private List<ConfigDataField> GetDefault()
        {
            List<ConfigDataField> configDataFields = new List<ConfigDataField>();


            ListDate = new ConfigDataField { Desc = "Дата списка", NumColumn = 1, Type = ConfigDataFieldType.ListDate };
            ListNum = new ConfigDataField { Desc = "Номер списка", NumColumn = 2, Type = ConfigDataFieldType.ListNum };

            FirmName = new ConfigDataField { Desc = "Отправитель", NumColumn = 3, Type = ConfigDataFieldType.FirmName };
            Inn = new ConfigDataField { Desc = "ИНН", NumColumn = 4, Type = ConfigDataFieldType.Inn };
            Kpp = new ConfigDataField { Desc = "КПП", NumColumn = 5, Type = ConfigDataFieldType.Kpp };
            Contract = new ConfigDataField { Desc = "Номер договора", NumColumn = 6, Type = ConfigDataFieldType.NumDog };

            Barcode = new ConfigDataField { Desc = "ШПИ отправления", NumColumn = 7, Type = ConfigDataFieldType.Barcode };

            Type = new ConfigDataField { Desc = "Вид ПО", NumColumn = 8, Type = ConfigDataFieldType.Type };
            Category = new ConfigDataField { Desc = "Категория ПО", NumColumn = 9, Type = ConfigDataFieldType.Category };
            TransType = new ConfigDataField { Desc = "Направление", NumColumn = 10, Type = ConfigDataFieldType.TransType };

            MassRate = new ConfigDataField { Desc = "Сумма весового сбора", NumColumn = 11, Type = ConfigDataFieldType.MassRate };
            NoticeRate = new ConfigDataField { Desc = "Плата за доп. услуги", NumColumn = 12, Type = ConfigDataFieldType.NoticeRate };
            AviaRate = new ConfigDataField { Desc = "Сумма авиатарифа", NumColumn = 13, Type = ConfigDataFieldType.AviaRate };
            Value = new ConfigDataField { Desc = "Сумма объявленной ценности", NumColumn = 14, Type = ConfigDataFieldType.Value };
            ValueRate = new ConfigDataField { Desc = "Сумма платы за объявленную ценность", NumColumn = 15, Type = ConfigDataFieldType.ValueRate };

            Status = new ConfigDataField { Desc = "Статус отправления", NumColumn = 16, Type = ConfigDataFieldType.Status };
            StatusMessage = new ConfigDataField { Desc = "Причина брака", NumColumn = 17, Type = ConfigDataFieldType.StatusMessage };

            ReceptDate = new ConfigDataField { Desc = "Дата приема списка", NumColumn = 18, Type = ConfigDataFieldType.ReceptDate };

            Oper = new ConfigDataField { Desc = "ФИО оператора", NumColumn = 19, Type = ConfigDataFieldType.Operator };
            Ops = new ConfigDataField { Desc = "Индекс ОПС", NumColumn = 20, Type = ConfigDataFieldType.Ops };
            Index = new ConfigDataField { Desc = "Индекс назначения", NumColumn = 21, Type = ConfigDataFieldType.Index };
            Address = new ConfigDataField { Desc = "Адрес назначения", NumColumn = 22, Type = ConfigDataFieldType.Address };

            configDataFields.AddRange(new List<ConfigDataField>
            {
                ListDate, ListNum,
                FirmName, Inn, Kpp, Contract, Barcode,
                Type, Category, TransType,
                MassRate, NoticeRate, AviaRate, Value, ValueRate,
                Status, StatusMessage,
                ReceptDate,
                Oper, Ops, Index, Address
            });

            return configDataFields;
        }

        #endregion

        #region Ovverrides Methods

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
            TransType = null;

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

            _configDataFields = null;
        }

        #endregion
    }
}
