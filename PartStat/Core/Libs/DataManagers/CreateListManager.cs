using System;
using System.Collections.Generic;
using PartStat.Core.Models;
using PartStat.Core.Models.PostTypes;

namespace PartStat.Core.Libs.DataManagers
{
    public static class CreateListManager
    {
        public static List<CreateList> CreateLists;

        static CreateListManager()
        {
            CreateLists = new List<CreateList>
            {
                new CreateList {Name = CreateListType.ВСЕ.ToString(), Type = CreateListType.ВСЕ},
                new CreateList {Name = CreateListType.Ручка.ToString(), Type = CreateListType.Ручка},
                new CreateList {Name = CreateListType.Файлы.ToString(), Type = CreateListType.Файлы}
            };
        } 
    }
}
