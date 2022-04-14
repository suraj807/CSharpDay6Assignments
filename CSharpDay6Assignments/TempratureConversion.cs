using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay6Assignments
{
    internal class TempratureConversion
    {
        public void Conversion()
        {
            Console.WriteLine("\nTemperature Converter");
            Console.WriteLine("\n1.Degree in Celsius to Degree in Fahrenheit");
            Console.WriteLine("2.Degree in Fahrenheit to Degree in Celsius");
            Console.WriteLine("Enter choice 1 or 2 : ");
            int ch = Convert.ToInt32(Console.ReadLine()); //reads the user choice
            switch (ch)
            {
                case 1: //Converting temprature in Cel to fah
                    Console.WriteLine("\nEnter any value in celsius you want to convert : ");
                    double c = Convert.ToDouble(Console.ReadLine());
                    double fahrenheit = (c*(9/5))+32;
                    Console.WriteLine($"\n{c} Degree Celsius = {fahrenheit} Degree Fahrenheit");
                    break;
                case 2://Converting temprature in Fah to cel
                    Console.WriteLine("\nEnter any value in fahrenheit you want to convert : ");
                    double f = Convert.ToDouble(Console.ReadLine());
                    double celsius = (f-32)*5/9;
                    Console.WriteLine($"\n{f} Degree Fahrenheit = {celsius} Degree Celsius");
                    break;
                default:
                    Console.WriteLine("Enter valid option");
                    break;
            }
        }
    }
}
