using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay6Assignments
{
    internal class BinaryToDecimal
    {
        public void BToDConversion()
        {
            float fractionalBinary,binaryNumber ,binary,rem, decimalNumber = 0; 
            long factor = 1,integerBinary;
            Console.WriteLine("\nEnter any number : "); 
            binaryNumber =(float.Parse)(Console.ReadLine()); // Reads binary numbers as input
            integerBinary = (int)(binaryNumber); // Store the only Integer part of the input 
            fractionalBinary = binaryNumber - integerBinary; // Store the fraction part of the input
            Console.WriteLine($"\nInteger part of given binary number : {integerBinary}");
            Console.WriteLine($"\nFraction part of given binary number : {fractionalBinary}");
            binary = binaryNumber;
            while(integerBinary>0) // This loop convert the integer part of Binary number to Integer part of Decimal Number
            {
                rem = integerBinary % 10; 
                decimalNumber=decimalNumber + rem * factor; 
                integerBinary = integerBinary / 10;
                factor = factor * 2;
            }
            float p = 0.5F;
            int temp;
            while (fractionalBinary>0) // This loop convert the fraction part of binary input to fraction part of integer and add to decimal integer part
            {
                fractionalBinary *= 10;
                temp = (int)fractionalBinary;
                decimalNumber += temp * p;
                p *= 0.5F;
                fractionalBinary -= temp;
            }
            Console.WriteLine($"\nDecimal Number of {binary} is : {decimalNumber}");
        }
    }
}