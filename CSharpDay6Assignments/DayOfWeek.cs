using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay6Assignments
{
    internal class DayOfWeek
    {
        public void Day()
        {
            int monthNumber = 0, year, d;
            string monthName;
            Console.WriteLine("Enter Year : ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month name : ");
            monthName = Console.ReadLine();
            Console.WriteLine("Enter Date : ");
            d = Convert.ToInt32(Console.ReadLine());
            monthNumber= DateTime.ParseExact(monthName, "MMMM", CultureInfo.CurrentCulture).Month; // Coonvert Month name to Month number
            Console.WriteLine("Month num : "+monthNumber);
            int y, x, m, day;
            // Applyting Formula to find day of week from Given month ,date and year
            y = year - (14 - monthNumber)/ 12;
            x = y + y/4 - y/100 + y/400;
            m = monthNumber + 12 * ((14 - monthNumber) / 12) - 2;
            day = (d + x + (31*m)/12)%7; // Day is in form of digit 

            Console.WriteLine("\nDay number is : " + day);

            switch (day) // To find Day name from day number
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;                
                default:
                    break;
            }
        }
    }
}