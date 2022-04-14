using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay6Assignments
{
    internal class FibonacciSeries
    {
        public void Fibonacci()
        {
            int firstNumber = 0, secondNumber = 1, sum = 0;
            Console.WriteLine("\nEnter the number you want the series to be : ");
            int check = Convert.ToInt32(Console.ReadLine()); // Reads the input from user
            Console.Write("\nFibonacci Series is : ");
            Console.Write($" {firstNumber} {secondNumber} ");
            for (int i = 2; i < check; i++)
            {
                sum = firstNumber + secondNumber; // Finds the sum of last two digits
                Console.Write($"{sum} "); // Displaying sum 
                firstNumber = secondNumber; // Now second number is consider as first number for to sum of last two digit
                secondNumber = sum;// and sum is consider as second number for to sum of last two digit
            }
        }
    }
}
