using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountSundayInMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            //0 => 'Sunday',
            //1 => 'Monday',
            //2 => 'Tuesday',
            //3 => 'Wednesday',
            //4 => 'Thursday',
            //5 => 'Friday',
            //6 => 'Saturday'

            int y = 0;
            int count = 0;
            for (int years = 1901; years <= 2000; years++)
            {                
                for (int month = 1; month <= 12; month++)
                {
                    y = CountSandays(years, month);
                    count += y;
                }                
            }
            Console.Write("Number of Sundays in the 20th century {0}", count);
            Console.ReadLine();
        }

        //The function counts all Sundays for the year 
        private static int CountSandays(int year, int month)
        {
            var firstDay = new DateTime(year, month, 1);

            var day29 = firstDay.AddDays(28);
            var day30 = firstDay.AddDays(29);
            var day31 = firstDay.AddDays(30);

            if ((day29.Month == month && day29.DayOfWeek == DayOfWeek.Sunday)
                || (day30.Month == month && day30.DayOfWeek == DayOfWeek.Sunday)
                || (day31.Month == month && day31.DayOfWeek == DayOfWeek.Sunday))
            {
                return 5;
            }
            else
            {
                return 4;
            }
        }
    }
}
