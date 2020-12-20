using System.Collections.Generic;
using LK.Core.Libs.TarifManager.Tarif;
using WcApi.Finance;

namespace LK.Core.Libs.TarifManager
{
    public static class Tarificator
    {
        public static List<MailTarif> MailTarificate(double startRate, double stepRate, int startMass, int endMass, int step, int nds = 20)
        {
            List<MailTarif> mailTarifs = new List<MailTarif>();
            Nds ndsCalc = new Nds(nds);

            for (int i = startMass; i <= endMass; i += step)
            {
                MailTarif tarif = new MailTarif()
                {
                    Mass = i.ToString(),
                    // ReSharper disable once PossibleLossOfFraction
                    Rate = startRate + (i - startMass) / step * stepRate
                };
                tarif.RateNds = ndsCalc.Plus(tarif.Rate);

                mailTarifs.Add(tarif);
            }

            return mailTarifs;
        }

        public static List<ParcelTarif> ParcelTarificate(double startRate, double stepRate, int startMass, int endMass, int step, int nds = 20)
        {
            List<ParcelTarif> parcelTarifs = new List<ParcelTarif>();
            Nds ndsCalc = new Nds(nds);

            for (int i = startMass; i <= endMass; i += step)
            {
                ParcelTarif tarif = new ParcelTarif
                {
                    Mass = i.ToString(),
                    // ReSharper disable once PossibleLossOfFraction
                    Rate = startRate + (i - startMass) / step * stepRate
                };
                tarif.RateNds = ndsCalc.Plus(tarif.Rate);

                parcelTarifs.Add(tarif);
            }

            return parcelTarifs;
        }
    }
}
