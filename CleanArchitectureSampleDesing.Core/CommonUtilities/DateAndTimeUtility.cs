using System;
using System.Collections.Generic;
using System.Text;

namespace LTMS.Core.CommonUtilities
{
    public static class DateAndTimeUtility
    {
        public static string GetPersianDate(this DateTime date)
        {
            System.Globalization.PersianCalendar cal = new System.Globalization.PersianCalendar();
            int year = cal.GetYear(date);
            int month = cal.GetMonth(date);
            int day = cal.GetDayOfMonth(date);

            return String.Format("{0}/{1}/{2}", year, (month < 10) ? "0" + month.ToString() : month.ToString(), (day < 10) ? "0" + day.ToString() : day.ToString());
        }
        public static DateTime? GetMiladiDateTime(this String Persaindate)
        {
            try
            {
                string[] splitetDate = null;
                splitetDate = Persaindate.Split('/');
                if (splitetDate == null) splitetDate = Persaindate.Split('-');
                System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
                Int32 year = Convert.ToInt32(splitetDate[0]);
                Int32 month = Convert.ToInt32(splitetDate[1]);
                Int32 day = Convert.ToInt32(splitetDate[2]);
                return pc.ToDateTime(year, month, day, 0, 0, 0, 0);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
