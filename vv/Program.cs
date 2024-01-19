using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureDay
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter today's day of the week (Sunday is 0, Monday is 1, ..., Saturday is 6): ");
            int today = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of days after today: ");
            int daysAfter = int.Parse(Console.ReadLine());

            FutureDay.DisplayFutureDay(today, daysAfter); 
        }
    }
}
