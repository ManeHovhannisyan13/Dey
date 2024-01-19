using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureDay
{
    public class FutureDay
    {
        public static void DisplayFutureDay(int today, int daysAfter)
        {
            string[] daysOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            int futureDayIndex = (today + daysAfter) % 7;
            string todayName = daysOfWeek[today];
            string futureDayName = daysOfWeek[futureDayIndex];

            Console.WriteLine($"Today is {todayName} and the next day is {futureDayName}");
        }
    }
}
