using System.Collections.Generic;
using PartStat.Core.Models;

namespace PartStat.Core.Libs.DataManagers
{
    public static class InterTypeManager
    {
        public static List<InterType> InterTypes;

        static InterTypeManager()
        {
            InterTypes = new List<InterType>
            {
                new InterType{Code = -1, Name = "ВСЕ"},
                new InterType {Code = 643, Name = "Внутренняя"},
                new InterType{Code = 0, Name = "Международная"}
            };
        }
    }
}
