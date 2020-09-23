using SPM.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPM.Helpers
{
    public static class TimeHelpes
    {
        public static DateTime CalculateExpireDateTime(DateTime startDate, int difference, TimeUnitEnum timeUnit, bool endOfDay = false)
        {
            DateTime d;
            switch (timeUnit)
            {
                case TimeUnitEnum.Day:
                    d = startDate.AddDays(difference);
                    break;
                case TimeUnitEnum.Month:
                    d = startDate.AddMonths(difference);
                    break;
                case TimeUnitEnum.Year:
                    d = startDate.AddYears(difference);
                    break;
                default:
                    d = startDate;
                    break;
            }
            if (endOfDay)
            {
                d = d.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            }
            return d;
        }
        public static DateTime CalculateExpireDateTime(DateTime startDate, int difference, int timeUnit, bool endOfDay = false)
        {
            DateTime d;
            switch (timeUnit)
            {
                case 1:
                    d = startDate.AddDays(difference);
                    break;
                case 2:
                    d = startDate.AddMonths(difference);
                    d = new DateTime(d.Year, d.Month, DateTime.DaysInMonth(d.Year, d.Month));
                    break;
                case 3:
                    d = startDate.AddYears(difference);
                    d = new DateTime(d.Year, d.Month, DateTime.DaysInMonth(d.Year, d.Month));
                    break;
                default:
                    d = startDate;
                    break;
            }
            if (endOfDay)
            {
                d = d.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            }
            return d;
        }
        public static int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.UtcNow.Year - dateOfBirth.Year;
            if (DateTime.UtcNow.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;
            return age;
        }
    }
}
