using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay6Assignments
{
    internal class DecimalToBinary
    {
        public void DToBConversion()
        {
            double fractional, no, number;
            long integer, rem, i = 0;
            long[] integerBinary = new long[100];
            Console.WriteLine("Enter any number : ");
            number = Convert.ToDouble(Console.ReadLine()); // Reads Decimal numbers as input
            no = number;
            integer = Convert.ToInt32(no); // Store the only Integer part of the input 
            fractional = no - integer; // Store the fraction part of the input
            while (integer > 0) // This loop convert the integer part of Decimal number to Integer part of Binary Number
            {
                rem = integer % 2;
                integer /= 2;
                integerBinary[i] = rem;
                i++;
            }
            for (long j = i - 1; j >= 0; j--) // Displaying only Integer part of Binary
            {
                Console.Write(integerBinary[j]);
            }
            Console.Write(".");
            for (long k = 1; k<=8; k++) // This loop convert the fraction part of decimal input to fraction part of Binary
            {           
                fractional=fractional*2;
                double temp = fractional;
                int fractionalBinary = (int)(temp);
                if (fractionalBinary>1)
                    break;
                Console.Write(fractionalBinary);
                if (temp==1)
                    fractional=fractional-temp;
            }
        }
    }
}
