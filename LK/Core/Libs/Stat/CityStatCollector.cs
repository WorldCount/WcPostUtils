using System.Collections.Generic;
using LK.Core.Models.DB;

namespace LK.Core.Libs.Stat
{
    public class CityStatCollector
    {
        public int SumCount { get; private set; }

        public int CityCount { get; private set; }

        public int MoscowCount { get; private set; }

        public int UnkownCount { get; private set; }

        public int InterCount { get; private set; }

        public CityStatCollector() { }

        public CityStatCollector(List<Rpo> rpos)
        {
            foreach (Rpo rpo in rpos)
            {
                Add(rpo);
            }
        }

        public void Add(Rpo rpo)
        {
            if (rpo.Index.Length == 6)
            {
                try
                {
                    int index = int.Parse(rpo.Index);

                    if (rpo.IsInter())
                    {
                        InterCount += 1;
                        return;
                    }
                    else
                    {

                        if (index >= 150000)
                            CityCount += 1;
                        else
                            MoscowCount += 1;
                    }
                }
                catch
                {
                    UnkownCount += 1;
                }
            }
            else
            {
                UnkownCount += 1;
            }

            SumCount += 1;
        }
    }
}
