using System.Collections.Generic;
using WcPostApi.Tafirs.Types;

namespace WcPostApi.Tafirs
{
    public static class Tarificator
    {
        public static List<CustomMailTarif> MailTarificate(double startRate, double stepRate, int startMass = 20, int endMass = 100, int step = 20)
        {
            List<CustomMailTarif> mailTarifs = new List<CustomMailTarif>();

            for (int i = startMass; i <= endMass; i += step)
            {
                CustomMailTarif tarif = new CustomMailTarif()
                {
                    Mass = i,
                    // ReSharper disable once PossibleLossOfFraction
                    Rate = startRate + (i - startMass) / step * stepRate
                };

                mailTarifs.Add(tarif);
            }

            return mailTarifs;
        }

        public static List<CustomParcelTarif> ParcelTarificate(double startRate, double stepRate, int startMass = 100, int endMass = 5000, int step = 20)
        {
            List<CustomParcelTarif> parcelTarifs = new List<CustomParcelTarif>();

            for (int i = startMass; i <= endMass; i += step)
            {
                CustomParcelTarif tarif = new CustomParcelTarif
                {
                    Mass = i,
                    // ReSharper disable once PossibleLossOfFraction
                    Rate = startRate + (i - startMass) / step * stepRate
                };

                parcelTarifs.Add(tarif);
            }

            return parcelTarifs;
        }
    }
}
