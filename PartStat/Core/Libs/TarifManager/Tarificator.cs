using System.Collections.Generic;
using PartStat.Core.Models.Tarifs;

namespace PartStat.Core.Libs.TarifManager
{
    public static class Tarificator
    {
        public static List<MailTarif> MailTarificate(double startRate, double stepRate, int startMass, int endMass, int step)
        {
            List<MailTarif> mailTarifs = new List<MailTarif>();

            for (int i = startMass; i <= endMass; i += step)
            {
                MailTarif tarif = new MailTarif()
                {
                    Mass = i.ToString(),
                    // ReSharper disable once PossibleLossOfFraction
                    Rate = startRate + (i - startMass) / step * stepRate
                };

                mailTarifs.Add(tarif);
            }

            return mailTarifs;
        }

        public static List<ParcelTarif> ParcelTarificate(double startRate, double stepRate, int startMass, int endMass, int step)
        {
            List<ParcelTarif> parcelTarifs = new List<ParcelTarif>();

            for (int i = startMass; i <= endMass; i += step)
            {
                ParcelTarif tarif = new ParcelTarif
                {
                    Mass = i.ToString(),
                    // ReSharper disable once PossibleLossOfFraction
                    Rate = startRate + (i - startMass) / step * stepRate
                };

                parcelTarifs.Add(tarif);
            }

            return parcelTarifs;
        }
    }
}
