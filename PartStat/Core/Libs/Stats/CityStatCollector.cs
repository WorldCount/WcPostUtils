using System.Collections.Generic;
using PartStat.Core.Models.DB;
using PartStat.Core.Models.DB.Queries;

namespace PartStat.Core.Libs.Stats
{
    public class CityStatCollector
    {
        public int SumCount { get; private set; }

        public int CityCount { get; private set; }

        public int MoscowCount { get; private set; }

        public int UnkownCount { get; private set; }

        public int InterCount { get; private set; }

        public CityStatCollector () { }

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
                        InterCount += rpo.Count;
                        return;
                    }
                    else
                    {

                        if (index >= 150000)
                            CityCount += rpo.Count;
                        else
                            MoscowCount += rpo.Count;
                    }
                }
                catch
                {
                    UnkownCount += rpo.Count;
                }
            }
            else
            {
                UnkownCount += rpo.Count;
            }

            SumCount += rpo.Count;
        }
    }
}
