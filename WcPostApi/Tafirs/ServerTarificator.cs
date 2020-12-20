using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcPostApi.Tafirs.Manager;
using WcPostApi.Tafirs.TarifObject;
using WcPostApi.Tafirs.Types;
using WcPostApi.Types;

namespace WcPostApi.Tafirs
{
    public static class ServerTarificator
    {
        private static readonly HttpClient Client = new HttpClient();

        static ServerTarificator()
        {
            WebRequest.DefaultWebProxy = null;
        }

        #region Публичные методы

        // Тарифы на заказные письма
        public static async Task<List<CustomMailTarif>> GetCustomMailTarifs(int step, int startWeight, int endWeight)
        {
            List<CustomMailTarif> mailTarifs = new List<CustomMailTarif>();

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

                    CustomMailTarif mailTarif = new CustomMailTarif();

                    Tarif tarifObject = JsonSerializer.Deserialize<Tarif>(data);
                    mailTarif.Rate = tarifObject.Pay / 100;
                    mailTarif.Mass = tarifObject.Mass;

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
        public static async Task<List<CustomParcelTarif>> GetCustomParcelTarifs(int step, int startWeight, int endWeight)
        {
            List<CustomParcelTarif> parcelTarifs = new List<CustomParcelTarif>();

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

                    CustomParcelTarif parcelTarif = new CustomParcelTarif();

                    Tarif tarifObject = JsonSerializer.Deserialize<Tarif>(data);
                    parcelTarif.Rate = tarifObject.Pay / 100;
                    parcelTarif.Mass = tarifObject.Mass;

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

            if (customNoticeTarif != null)
                noticeTarifs.Add(customNoticeTarif);

            if (electronicNoticeTarif != null)
                noticeTarifs.Add(electronicNoticeTarif);

            if (interNoticeTarif != null)
                noticeTarifs.Add(interNoticeTarif);

            return noticeTarifs;
        }

        // Тарифы на письма 1-го класса
        public static async Task<List<CustomFirstMail>> GetCustomFirstMailTarifs()
        {
            List<CustomFirstMail> defaulTarifs = CustomFirstMailTarifManager.GetDefault();
            List<CustomFirstMail> tarifs = new List<CustomFirstMail>();

            foreach (CustomFirstMail defaulTarif in defaulTarifs)
            {

                double rate = await GetFirstMailTarifRate(defaulTarif.Mass);
                defaulTarif.Rate = rate;
                tarifs.Add(defaulTarif);
            }

            return tarifs;
        }

        // Тарифы на бандероли 1-го класса
        public static async Task<List<CustomFirstParcel>> GetCustomFirstParcelTarifs()
        {
            List<CustomFirstParcel> defaulTarifs = CustomFistParcelTarifManager.GetDefault();
            List<CustomFirstParcel> tarifs = new List<CustomFirstParcel>();

            foreach (CustomFirstParcel defaulTarif in defaulTarifs)
            {
                double rate = await GetFirstParcelTarifRate(defaulTarif.Mass, defaulTarif.TransType);
                defaulTarif.Rate = rate;
                tarifs.Add(defaulTarif);
            }

            return tarifs;
        }

        // Тарифы на международные письма
        public static async Task<List<InterCustomMailTarif>> GetInterCustomMailTarifs()
        {
            List<InterCustomMailTarif> defaultTarifs = InterCustomMailTarifManager.GetDefault();
            List<InterCustomMailTarif> tarifs = new List<InterCustomMailTarif>();

            foreach (InterCustomMailTarif defaultTarif in defaultTarifs)
            {
                double rate = await GetInterMailTarifRate(defaultTarif.Mass, defaultTarif.TransType);
                defaultTarif.Rate = rate;
                tarifs.Add(defaultTarif);
            }

            return tarifs;
        }

        // Тарифы на международные бандероли
        public static async Task<List<InterCustomParcelTarif>> GetInterCustomParcelTarifs()
        {
            List<InterCustomParcelTarif> defaultTarifs = InterCustomParcelTarifManager.GetDefault();
            List<InterCustomParcelTarif> tarifs = new List<InterCustomParcelTarif>();

            foreach (InterCustomParcelTarif defaultTarif in defaultTarifs)
            {
                double rate = await GetInterParcelTarifRate(defaultTarif.Mass, defaultTarif.TransType);
                defaultTarif.Rate = rate;
                tarifs.Add(defaultTarif);
            }

            return tarifs;
        }


        #endregion

        #region Вспомогательные методы

        public static async Task<string> Request(string url)
        {
            HttpResponseMessage response = await Client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                try
                {
                    string data = await response.Content.ReadAsStringAsync();
                    return data;
                }
                catch
                {
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
                Tarif tarifObject = JsonSerializer.Deserialize<Tarif>(data);
                return tarifObject.Pay / 100;
            }
            catch
            {
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
                Tarif tarifObject = JsonSerializer.Deserialize<Tarif>(data);
                return tarifObject.Pay / 100;
            }
            catch
            {
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
                Tarif tarifObject = JsonSerializer.Deserialize<Tarif>(data);
                return tarifObject.Pay / 100;
            }
            catch
            {
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
                Tarif tarifObject = JsonSerializer.Deserialize<Tarif>(data);
                return tarifObject.Pay / 100;
            }
            catch
            {
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
                Notice noticeObject = JsonSerializer.Deserialize<Notice>(data);
                NoticeTarif tarif = new NoticeTarif
                {
                    Rate = noticeObject.Service.Pay / 100,
                };

                return tarif;
            }
            catch
            {
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
            string url = $"https://tariff.pochta.ru/tariff/v1/calculate?json&object=2011&from=125993&country=895&weight=20&date=20200531&service=1";

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
