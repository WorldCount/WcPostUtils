using System;

namespace WcApi.Post
{
    public static class Month
    {
        /// <summary>
        /// Возвращает месяц диапазона
        /// </summary>
        /// <param name="date">Дата</param>
        /// <returns>Номер месяца</returns>
        public static int GetMonthRange(DateTime date)
        {
            DateTime startDate = new DateTime(2000, 1, 1);
            if (date < startDate)
                return 0;
            int month = ((date.Year - startDate.Year) * 12) + date.Month - startDate.Month + 1;
            return month;
        }

        public static DateTime GetRangeDate(int rangeNum)
        {
            DateTime startDate = new DateTime(2000, 1, 1);
            return startDate.AddMonths(rangeNum - 1);
        }

        /// <summary>
        /// Возвращает месяц ШПИ
        /// </summary>
        /// <param name="date">Дата</param>
        /// <returns>Номер месяца</returns>
        public static int GetMonthBarcode(DateTime date)
        {
            int month = GetMonthRange(date) % 99;
            return month == 0 ? 99 : month;
        }

        public static int GetMonthBarcode(int monthRange)
        {
            int month = monthRange % 99;
            return month == 0 ? 99 : month;
        }
    }
}
