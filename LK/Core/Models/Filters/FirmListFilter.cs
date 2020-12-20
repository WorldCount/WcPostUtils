using System;
using LK.Core.Models.Types;

namespace LK.Core.Models.Filters
{
    public class FirmListFilter
    {
        private DateTime _startDate;
        private DateTime _endDate;

        public int FirmId { get; set; }

        public DateTime StartDate
        {
            get => _startDate;
            set => _startDate = new DateTime(value.Year, value.Month, value.Day, 0, 0, 0);
        }
        public DateTime EndDate
        {
            get => _endDate;
            set => _endDate = new DateTime(value.Year, value.Month, value.Day, 23, 59, 59);
        }

        public int StartNum { get; set; }
        public int EndNum { get; set; }


        public int MailTypeId { get; set; }
        public int MailCategoryId { get; set; }
        public MailClass MailClass { get; set; }


        public ErrorType ErrorType { get; set; }
        public int OperatorId { get; set; }

    }
}
