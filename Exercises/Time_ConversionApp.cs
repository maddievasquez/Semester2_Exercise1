using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Exercises
{
    public class Time_ConversionApp
    {

        // Constructor
        public Time_ConversionApp()
        {

        }
        public void MinutesToHours()
        {
            int minutes = 0;  /* given number of minutes */
            int hrs;          /* number of hours (to be computed) */
            int mins;        /* number of minutes (to be computed) */
            Console.WriteLine("Minute convertion app");
            int minutesInHour = 60;      /* number of minutes in an hour */


            hrs = minutes / minutesInHour;
            mins = (minutes % minutesInHour);


            Console.WriteLine("$Hour: {hrs} Minute: {mins}");
        }
    }
}
