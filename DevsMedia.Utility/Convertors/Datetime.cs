using System.Globalization;

namespace DevsMedia.Utility.Convertors
{
    public static class Datetime
    {
        public static DateTime ConvertToShamsi(this DateTime dateTime)
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            
            int day = persianCalendar.GetDayOfMonth(dateTime);
            int month = persianCalendar.GetMonth(dateTime);
            int year = persianCalendar.GetYear(dateTime);

            return new DateTime(year, month, day);
        }
    }
}
