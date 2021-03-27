using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using PartStat.Core.Libs.DataManagers;
using PartStat.Core.Libs.ServerTarif.Object;
using PartStat.Core.Libs.TarifManager;
using PartStat.Core.Models;
using PartStat.Core.Models.PostTypes;
using PartStat.Core.Models.Tarifs;

namespace PartStat.Core.Libs.ServerTarif
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

            int step = 0;
            if (stepConfig != null)
                step = stepConfig.GetIntValue();

            int startWeight = 0;
            if (startWeightConfig != null)
                startWeight = startWeightConfig.GetIntValue();

            int endWeight = 0;
            if (endWeightConfig != null)
                endWeight = endWeightConfig.GetIntValue();

            int[] mass = Utils.GetListInt(startWeight, startWeight + step, step).ToArray();

            if (mass.Length == 0)
                return null;

            try
            {
                foreach (int n in mass)
                {
                    string url = $"https://tariff.pochta.ru/tariff/v1/calculate?json&object=2010&weight={n}&from=125993";

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

            mailTarifs = Tarificator.MailTarificate(startRate, stepRate, startWeight, endWeight, step);


            return mailTarifs;
        }

        // Тарифы на заказные бандероли
        public static async Task<List<ParcelTarif>> GetParcelTarifs()
        {
            List<ParcelTarif> parcelTarifs = new List<ParcelTarif>();

            Config stepConfig = ConfigManager.GetConfigByName(ConfigName.Step);
            Config startWeightConfig = ConfigManager.GetConfigByName(ConfigName.ParcelStartWeight);
            Config endWeightConfig = ConfigManager.GetConfigByName(ConfigName.ParcelEndWeight);

            int step = 20;
            if (stepConfig != null)
                step = stepConfig.GetIntValue();

            int startWeight = 100;
            if (startWeightConfig != null)
                startWeight = startWeightConfig.GetIntValue();

            int endWeight = 5000;
            if (endWeightConfig != null)
                endWeight = endWeightConfig.GetIntValue();

            int[] mass = Utils.GetListInt(startWeight, startWeight + step, step).ToArray();

            if (mass.Length == 0)
                return null;

            try
            {
                foreach (int n in mass)
                {
                    string url = $"https://tariff.pochta.ru/tariff/v1/calculate?json&object=3010&weight={n}&from=125993";

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

            parcelTarifs = Tarificator.ParcelTarificate(startRate, stepRate, startWeight, endWeight, step);


            return parcelTarifs;
        }

        // Тарифы на уведомления
        public static async Task<List<NoticeTarif>> GetNoticeTarifs()
        {
            List<NoticeTarif> noticeTarifs = new List<NoticeTarif>();

            // Простое уведомление
            NoticeTarif simpleNoticeTarif = await GetSimpleNoticeTarif();
            // Заказное уведомление
            NoticeTarif customNoticeTarif = await GetCustomNoticeTarif();
            // Электронное уведомление
            NoticeTarif electronicNoticeTarif = await GetElectronicNoticeTarif();
            // Международное уведомление
            NoticeTarif interNoticeTarif = await GetInterNoticeTarif();

            if (simpleNoticeTarif != null)
                noticeTarifs.Add(simpleNoticeTarif);

            if(customNoticeTarif != null)
                noticeTarifs.Add(customNoticeTarif);

            if(electronicNoticeTarif != null)
                noticeTarifs.Add(electronicNoticeTarif);

            if(interNoticeTarif != null)
                noticeTarifs.Add(interNoticeTarif);

            return noticeTarifs;
        }

        // Тарифы на письма 1-го класса
        public static async Task<List<FirstMailTarif>> GetFirstMailTarifs()
        {
            List<FirstMailTarif> defaulTarifs = FirstMailTarifManager.GetDefault();
            List<FirstMailTarif> tarifs = new List<FirstMailTarif>();

            foreach (FirstMailTarif defaulTarif in defaulTarifs)
            {
                
                double rate = await GetFirstMailTarifRate(defaulTarif.EndMass);
                defaulTarif.Rate = rate;
                tarifs.Add(defaulTarif);
            }

            return tarifs;
        }

        // Тарифы на бандероли 1-го класса
        public static async Task<List<FirstParcelTarif>> GetFirstParcelTarifs()
        {
            List<FirstParcelTarif> defaulTarifs = FirstParcelTarifManager.GetDefault();
            List<FirstParcelTarif> tarifs = new List<FirstParcelTarif>();

            foreach (FirstParcelTarif defaulTarif in defaulTarifs)
            {
                double rate = await GetFirstParcelTarifRate(defaulTarif.EndMass, defaulTarif.TransType);
                defaulTarif.Rate = rate;
                tarifs.Add(defaulTarif);
            }

            return tarifs;
        }

        // Тарифы на международные письма
        public static async Task<List<InterMailTarif>> GetInterMailTarifs()
        {
            List<InterMailTarif> defaultTarifs = InterMailTarifManager.GetDefault();
            List<InterMailTarif> tarifs = new List<InterMailTarif>();

            foreach (InterMailTarif defaultTarif in defaultTarifs)
            {
                double rate = await GetInterMailTarifRate(defaultTarif.EndMass, defaultTarif.TransType);
                defaultTarif.Rate = rate;
                tarifs.Add(defaultTarif);
            }

            return tarifs;
        }

        // Тарифы на международные бандероли
        public static async Task<List<InterParcelTarif>> GetInterParcelTarifs()
        {
            List<InterParcelTarif> defaultTarifs = InterParcelTarifManager.GetDefault();
            List<InterParcelTarif> tarifs = new List<InterParcelTarif>();

            foreach (InterParcelTarif defaultTarif in defaultTarifs)
            {
                double rate = await GetInterParcelTarifRate(defaultTarif.EndMass, defaultTarif.TransType);
                defaultTarif.Rate = rate;
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

            string url = $"https://tariff.pochta.ru/tariff/v1/calculate?json&object=2011&from=125993&country=895&weight={mass}&isavia={isAvia}";

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

            string url = $"https://tariff.pochta.ru/tariff/v1/calculate?json&object=3011&from=125993&country=895&weight={mass}&isavia={isAvia}";

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

            string url = $"https://tariff.pochta.ru/tariff/v1/calculate?json&object=16010&from=125993&to={index}&weight={mass}";

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
            string url = $"https://tariff.pochta.ru/tariff/v1/calculate?json&object=15010&from=125993&weight={mass}";
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

        private static async Task<NoticeTarif> GetNoticeTarifByServiceId(string url)
        {
            string data = await Request(url);

            if (string.IsNullOrEmpty(data))
                return null;

            try
            {
                NoticeObject noticeObject = JsonConvert.DeserializeObject<NoticeObject>(data);
                NoticeTarif tarif = new NoticeTarif
                {
                    Rate = noticeObject.Service.Pay / 100,
                };

                return tarif;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        private static async Task<NoticeTarif> GetSimpleNoticeTarif()
        {
            string url = $"https://tariff.pochta.ru/tariff/v1/calculate?json&object=2010&weight=20&from=125993&to=125993&service=1";

            NoticeTarif noticeTarif = await GetNoticeTarifByServiceId(url);

            if (noticeTarif != null)
            {
                noticeTarif.Name = "Простое уведомление";
                noticeTarif.Type = NoticeType.Простое;
            }

            return noticeTarif;
        }

        private static async Task<NoticeTarif> GetCustomNoticeTarif()
        {
            string url = $"https://tariff.pochta.ru/tariff/v1/calculate?json&object=2010&weight=20&from=125993&to=125993&service=2";

            NoticeTarif noticeTarif = await GetNoticeTarifByServiceId(url);

            if (noticeTarif != null)
            {
                noticeTarif.Name = "Заказное уведомление";
                noticeTarif.Type = NoticeType.Заказное;
            }

            return noticeTarif;
        }

        private static async Task<NoticeTarif> GetElectronicNoticeTarif()
        {
            string url = $"https://tariff.pochta.ru/tariff/v1/calculate?json&object=2010&weight=20&from=125993&to=125993&service=62";

            NoticeTarif noticeTarif = await GetNoticeTarifByServiceId(url);

            if (noticeTarif != null)
            {
                noticeTarif.Name = "Электронное уведомление";
                noticeTarif.Type = NoticeType.Электронное;
            }

            return noticeTarif;
        }

        private static async Task<NoticeTarif> GetInterNoticeTarif()
        {
            string url = $"https://tariff.pochta.ru/tariff/v1/calculate?json&object=2011&from=125993&country=895&weight=20&service=1";

            NoticeTarif noticeTarif = await GetNoticeTarifByServiceId(url);

            if (noticeTarif != null)
            {
                noticeTarif.Name = "Международное уведомление";
                noticeTarif.Type = NoticeType.Международное;
            }

            return noticeTarif;
        }

        #endregion

    }
}
