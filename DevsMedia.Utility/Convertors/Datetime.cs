using System.Globalization;

namespace DevsMedia.Utility.Convertors
{
    public static class Datetime
    {
        public static string ConvertToShamsi(this DateTime dateTime)
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            
            int day = persianCalendar.GetDayOfMonth(dateTime);
            int month = persianCalendar.GetMonth(dateTime);
            int year = persianCalendar.GetYear(dateTime);

            return $"{year}/{month.ToString("00")}/{day.ToString("00")}";
        }
    }
}
