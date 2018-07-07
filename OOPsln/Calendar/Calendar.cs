using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class Calendar
    {
        // property
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string Date
        {
            // dd/MM/yyyy
            get
            {
                return Day + "/" + Month + "/" + Year;
            }
        }
        // method
        public bool CheckDate()
        {
            if (Year < 0)
            {
                return false;
            }
            if (Month < 1 || Month > 12)
            {
                return false;
            }
            if (Day < 1)
            {
                return false;
            }
            if (Day > DateTime.DaysInMonth(Year, Month))
            {
                return false;
            }
            return true;
        }
        public int GetDateOfWeek()
        {
            if (!CheckDate())
            {
                return 0;
            }
            DateTime date = new DateTime(Year, Month, Day);
            int dayOfWeek = 0;
            switch (date.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    dayOfWeek = 1;
                    break;
                case DayOfWeek.Tuesday:
                    dayOfWeek = 2;
                    break;
                case DayOfWeek.Wednesday:
                    dayOfWeek = 3;
                    break;
                case DayOfWeek.Thursday:
                    dayOfWeek = 4;
                    break;
                case DayOfWeek.Friday:
                    dayOfWeek = 5;
                    break;
                case DayOfWeek.Saturday:
                    dayOfWeek = 6;
                    break;
                case DayOfWeek.Sunday:
                    dayOfWeek = 7;
                    break;
            }
            return dayOfWeek;
        }
    }
}
