using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using LK.Core.Libs.DataManagers;
using LK.Core.Libs.DataManagers.Models;
using LK.Core.Libs.TarifManager.PostTypes;
using LK.Core.Libs.TarifManager.ServerTarif.Object;
using LK.Core.Libs.TarifManager.Tarif;
using Newtonsoft.Json;
using WcApi.Finance;

namespace LK.Core.Libs.TarifManager.ServerTarif
{
    public static class ServerTarificator
    {
        private static readonly HttpClient Client = new HttpClient();

        static ServerTarificator()
        {
            WebRequest.DefaultWebProxy = null;
        }

        #region Public Methods

        // Тарифы на заказные письма
        public static async Task<List<MailTarif>> GetMailTarifs()
        {
            List<MailTarif> mailTarifs = new List<MailTarif>();

            Config stepConfig = ConfigManager.GetConfigByName(ConfigName.Step);
            Config startWeightConfig = ConfigManager.GetConfigByName(ConfigName.MailStartWeight);
            Config endWeightConfig = ConfigManager.GetConfigByName(ConfigName.MailEndWeight);
            Config ndsConfig = ConfigManager.GetConfigByName(ConfigName.Nds);

            int step = 0;
            if (stepConfig != null)
                step = stepConfig.GetIntValue();

            int startWeight = 0;
            if (startWeightConfig != null)
                startWeight = startWeightConfig.GetIntValue();

            int endWeight = 0;
            if (endWeightConfig != null)
                endWeight = endWeightConfig.GetIntValue();

            int nds = 0;
            if (ndsConfig != null)
                nds = ndsConfig.GetIntValue();

            int[] mass = Utils.GetListInt(startWeight, startWeight + step, step).ToArray();

            if (mass.Length == 0)
                return null;

            try
            {
                foreach (int n in mass)
                {
                    string url = $"https://tariff.pochta.ru/tariff/v2/calculate?json&object=2010&weight={n}&from=125993";

                    string data = await Request(url);

                    if (string.IsNullOrEmpty(data))
                        return null;

                    MailTarif mailTarif = JsonConvert.DeserializeObject<MailTarif>(data);
                    mailTarif.Rate /= 100;

                    mailTarifs.Add(mailTarif);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }

            double startRate = mailTarifs[0].Rate;
            double stepRate = mailTarifs[mailTarifs.Count - 1].Rate - mailTarifs[0].Rate;

            mailTarifs = Tarificator.MailTarificate(startRate, stepRate, startWeight, endWeight, step, nds);

            return mailTarifs;
        }

        // Тарифы на заказные бандероли
        public static async Task<List<ParcelTarif>> GetParcelTarifs()
        {
            List<ParcelTarif> parcelTarifs = new List<ParcelTarif>();

            Config stepConfig = ConfigManager.GetConfigByName(ConfigName.Step);
            Config startWeightConfig = ConfigManager.GetConfigByName(ConfigName.ParcelStartWeight);
            Config endWeightConfig = ConfigManager.GetConfigByName(ConfigName.ParcelEndWeight);
            Config ndsConfig = ConfigManager.GetConfigByName(ConfigName.Nds);

            int step = 20;
            if (stepConfig != null)
                step = stepConfig.GetIntValue();

            int startWeight = 100;
            if (startWeightConfig != null)
                startWeight = startWeightConfig.GetIntValue();

            int endWeight = 5000;
            if (endWeightConfig != null)
                endWeight = endWeightConfig.GetIntValue();

            int nds = 0;
            if (ndsConfig != null)
                nds = ndsConfig.GetIntValue();

            int[] mass = Utils.GetListInt(startWeight, startWeight + step, step).ToArray();

            if (mass.Length == 0)
                return null;

            try
            {
                foreach (int n in mass)
                {
                    string url = $"https://tariff.pochta.ru/tariff/v2/calculate?json&object=3010&weight={n}&from=125993";

                    string data = await Request(url);

                    if (string.IsNullOrEmpty(data))
                        return null;

                    ParcelTarif parcelTarif = JsonConvert.DeserializeObject<ParcelTarif>(data);
                    parcelTarif.Rate /= 100;

                    parcelTarifs.Add(parcelTarif);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }

            double startRate = parcelTarifs[0].Rate;
            double stepRate = parcelTarifs[parcelTarifs.Count - 1].Rate - parcelTarifs[0].Rate;

            parcelTarifs = Tarificator.ParcelTarificate(startRate, stepRate, startWeight, endWeight, step, nds);


            return parcelTarifs;
        }

        // Тарифы на уведомления
        public static async Task<List<ServiceTarif>> GetServiceTarifs()
        {
            List<ServiceTarif> serviceTarifs = new List<ServiceTarif>();

            // Простое уведомление
            ServiceTarif simpleNoticeTarif = await GetSimpleNoticeTarif();
            // Заказное уведомление
            ServiceTarif customNoticeTarif = await GetCustomNoticeTarif();
            // Электронное уведомление
            ServiceTarif electronicNoticeTarif = await GetElectronicNoticeTarif();
            // Международное уведомление
            ServiceTarif interNoticeTarif = await GetInterNoticeTarif();
            // Опись
            ServiceTarif inventoryTarif = await GetInventoryTarif();

            if (simpleNoticeTarif != null)
                serviceTarifs.Add(simpleNoticeTarif);

            if(customNoticeTarif != null)
                serviceTarifs.Add(customNoticeTarif);

            if(electronicNoticeTarif != null)
                serviceTarifs.Add(electronicNoticeTarif);

            if(interNoticeTarif != null)
                serviceTarifs.Add(interNoticeTarif);

            if (inventoryTarif != null)
                serviceTarifs.Add(inventoryTarif);

            return serviceTarifs;
        }

        // Тарифы на письма 1-го класса
        public static async Task<List<FirstMailTarif>> GetFirstMailTarifs()
        {
            List<FirstMailTarif> defaulTarifs = FirstMailTarifManager.GetDefault();
            List<FirstMailTarif> tarifs = new List<FirstMailTarif>();

            Config ndsConfig = ConfigManager.GetConfigByName(ConfigName.Nds);

            int nds = 0;
            if (ndsConfig != null)
                nds = ndsConfig.GetIntValue();

            Nds ndsCalc = new Nds(nds);

            foreach (FirstMailTarif defaultTarif in defaulTarifs)
            {
                
                double rate = await GetFirstMailTarifRate(defaultTarif.EndMass);
                defaultTarif.Rate = rate;
                defaultTarif.RateNds = ndsCalc.Plus(rate);
                tarifs.Add(defaultTarif);
            }

            return tarifs;
        }

        // Тарифы на бандероли 1-го класса
        public static async Task<List<FirstParcelTarif>> GetFirstParcelTarifs()
        {
            List<FirstParcelTarif> defaulTarifs = FirstParcelTarifManager.GetDefault();
            List<FirstParcelTarif> tarifs = new List<FirstParcelTarif>();

            Config ndsConfig = ConfigManager.GetConfigByName(ConfigName.Nds);

            int nds = 0;
            if (ndsConfig != null)
                nds = ndsConfig.GetIntValue();

            Nds ndsCalc = new Nds(nds);

            foreach (FirstParcelTarif defaultTarif in defaulTarifs)
            {
                double rate = await GetFirstParcelTarifRate(defaultTarif.EndMass, defaultTarif.TransType);
                defaultTarif.Rate = rate;
                defaultTarif.RateNds = ndsCalc.Plus(rate);
                tarifs.Add(defaultTarif);
            }

            return tarifs;
        }

        // Тарифы на международные письма
        public static async Task<List<InterMailTarif>> GetInterMailTarifs()
        {
            List<InterMailTarif> defaultTarifs = InterMailTarifManager.GetDefault();
            List<InterMailTarif> tarifs = new List<InterMailTarif>();

            Config ndsConfig = ConfigManager.GetConfigByName(ConfigName.Nds);

            int nds = 0;
            if (ndsConfig != null)
                nds = ndsConfig.GetIntValue();

            Nds ndsCalc = new Nds(nds);

            foreach (InterMailTarif defaultTarif in defaultTarifs)
            {
                double rate = await GetInterMailTarifRate(defaultTarif.EndMass, defaultTarif.TransType);
                defaultTarif.Rate = rate;
                defaultTarif.RateNds = ndsCalc.Plus(rate);
                tarifs.Add(defaultTarif);
            }

            return tarifs;
        }

        // Тарифы на международные бандероли
        public static async Task<List<InterParcelTarif>> GetInterParcelTarifs()
        {
            List<InterParcelTarif> defaultTarifs = InterParcelTarifManager.GetDefault();
            List<InterParcelTarif> tarifs = new List<InterParcelTarif>();

            Config ndsConfig = ConfigManager.GetConfigByName(ConfigName.Nds);

            int nds = 0;
            if (ndsConfig != null)
                nds = ndsConfig.GetIntValue();

            Nds ndsCalc = new Nds(nds);

            foreach (InterParcelTarif defaultTarif in defaultTarifs)
            {
                double rate = await GetInterParcelTarifRate(defaultTarif.EndMass, defaultTarif.TransType);
                defaultTarif.Rate = rate;
                defaultTarif.RateNds = ndsCalc.Plus(rate);
                tarifs.Add(defaultTarif);
            }

            return tarifs;
        }

        #endregion

        #region Private Methods

        private static async Task<string> Request(string url)
        {
            HttpResponseMessage response = await Client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                try
                {
                    string data = await response.Content.ReadAsStringAsync();
                    return data;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return null;
                }

            }

            return null;
        }

        private static async Task<double> GetInterMailTarifRate(int mass, TransType transType)
        {
            int isAvia = 0;

            if (transType == TransType.Авиа)
                isAvia = 2;

            string url = $"https://tariff.pochta.ru/tariff/v2/calculate?json&object=2011&from=125993&country=895&weight={mass}&isavia={isAvia}";

            string data = await Request(url);

            if (string.IsNullOrEmpty(data))
                return 0;

            try
            {
                TarifObject tarifObject = JsonConvert.DeserializeObject<TarifObject>(data);
                return tarifObject.Pay / 100;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }

        private static async Task<double> GetInterParcelTarifRate(int mass, TransType transType)
        {
            int isAvia = 0;

            if (transType == TransType.Авиа)
                isAvia = 2;

            string url = $"https://tariff.pochta.ru/tariff/v2/calculate?json&object=3011&from=125993&country=895&weight={mass}&isavia={isAvia}";

            string data = await Request(url);

            if (string.IsNullOrEmpty(data))
                return 0;

            try
            {
                TarifObject tarifObject = JsonConvert.DeserializeObject<TarifObject>(data);
                return tarifObject.Pay / 100;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }

        private static async Task<double> GetFirstParcelTarifRate(int mass, TransType transType)
        {
            int index = 101000;

            if (transType == TransType.Свыше2000Км)
                index = 672000;

            string url = $"https://tariff.pochta.ru/tariff/v2/calculate?json&object=16010&from=125993&to={index}&weight={mass}";

            string data = await Request(url);

            if (string.IsNullOrEmpty(data))
                return 0;

            try
            {
                TarifObject tarifObject = JsonConvert.DeserializeObject<TarifObject>(data);
                return tarifObject.Pay / 100;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }

        private static async Task<double> GetFirstMailTarifRate(int mass)
        {
            string url = $"https://tariff.pochta.ru/tariff/v2/calculate?json&object=15010&from=125993&to=101000&weight={mass}";
            string data = await Request(url);

            if (string.IsNullOrEmpty(data))
                return 0;

            try
            {
                TarifObject tarifObject = JsonConvert.DeserializeObject<TarifObject>(data);
                return tarifObject.Pay / 100;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }

        private static async Task<ServiceTarif> GetServiceTarifByServiceId(string url)
        {
            string data = await Request(url);

            if (string.IsNullOrEmpty(data))
                return null;

            try
            {
                AddServiceObject noticeObject = JsonConvert.DeserializeObject<AddServiceObject>(data);
                ServiceTarif tarif = new ServiceTarif
                {
                    Rate = noticeObject.Service.Pay / 100,
                    RateNds = noticeObject.Service.PayNds / 100
                };

                return tarif;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        private static async Task<ServiceTarif> GetInventoryTarif()
        {
            string url = $"https://tariff.pochta.ru/v2/calculate/tariff?json&object=2020&weight=20&sumoc=100&from=125993&to=125993&service=22";
            ServiceTarif serviceTarif = await GetServiceTarifByServiceId(url);

            if (serviceTarif != null)
            {
                serviceTarif.Name = "Опись";
                serviceTarif.Type = ServiceType.Опись;
                serviceTarif.Code = 0;
            }

            return serviceTarif;
        }

        private static async Task<ServiceTarif> GetSimpleNoticeTarif()
        {
            string url = $"https://tariff.pochta.ru/tariff/v2/calculate?json&object=2010&weight=20&from=125993&to=125993&service=1";

            ServiceTarif serviceTarif = await GetServiceTarifByServiceId(url);

            if (serviceTarif != null)
            {
                serviceTarif.Name = "Простое уведомление";
                serviceTarif.Type = ServiceType.ПростоеУв;
                serviceTarif.Code = 1;
            }

            return serviceTarif;
        }

        private static async Task<ServiceTarif> GetCustomNoticeTarif()
        {
            string url = $"https://tariff.pochta.ru/tariff/v2/calculate?json&object=2010&weight=20&from=125993&to=125993&service=2";

            ServiceTarif serviceTarif = await GetServiceTarifByServiceId(url);

            if (serviceTarif != null)
            {
                serviceTarif.Name = "Заказное уведомление";
                serviceTarif.Type = ServiceType.ЗаказноеУв;
                serviceTarif.Code = 2;
            }

            return serviceTarif;
        }

        private static async Task<ServiceTarif> GetElectronicNoticeTarif()
        {
            string url = $"https://tariff.pochta.ru/tariff/v2/calculate?json&object=2010&weight=20&from=125993&to=125993&service=62";

            ServiceTarif serviceTarif = await GetServiceTarifByServiceId(url);

            if (serviceTarif != null)
            {
                serviceTarif.Name = "Электронное уведомление";
                serviceTarif.Type = ServiceType.ЭлектронноеУв;
                serviceTarif.Code = 16384;
            }

            return serviceTarif;
        }

        private static async Task<ServiceTarif> GetInterNoticeTarif()
        {
            string url = $"https://tariff.pochta.ru/tariff/v2/calculate?json&object=2011&from=125993&country=895&weight=20&service=1";

            ServiceTarif serviceTarif = await GetServiceTarifByServiceId(url);

            if (serviceTarif != null)
            {
                serviceTarif.Name = "Международное уведомление";
                serviceTarif.Type = ServiceType.МеждународноеУв;
                serviceTarif.Code = 1;
            }

            return serviceTarif;
        }

        #endregion

    }
}
