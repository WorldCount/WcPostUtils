using System;
using System.Collections.Generic;
using PartStat.Core.Models;
using PartStat.Core.Models.PostTypes;

namespace PartStat.Core.Libs.DataManagers
{
    public static class ErrorListManager
    {
        public static List<ErrorList> ErrorLists;

        static ErrorListManager()
        {
            ErrorLists = new List<ErrorList>
            {
                new ErrorList{ErrorType = ErrorType.ВСЕ, Name = ErrorType.ВСЕ.ToString()},
                new ErrorList{ErrorType = ErrorType.Замечания, Name = ErrorType.Замечания.ToString()},
                new ErrorList{ErrorType = ErrorType.Выбывшие, Name = ErrorType.Выбывшие.ToString()},
                new ErrorList{ErrorType = ErrorType.Нет, Name = ErrorType.Нет.ToString()},
            };
        }
    }
}
