using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplierLib
{
    public class DateHandler
    {
        public int DaysBetweenDates(DateTime firstDate, DateTime secondDate)
        {
            var timeSpan = secondDate - firstDate;
            return timeSpan.Days;
        }

        public DateTime Add1000Days(DateTime theDate)
        {
            var addDays = theDate.AddDays(1000);
            return addDays;
        }
    }
}