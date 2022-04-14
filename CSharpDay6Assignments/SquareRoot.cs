using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay6Assignments
{
    internal class SquareRoot
    {
        public void FindSqrt()
        {
            Console.WriteLine("\nEnter number you want to find Square Root of this : ");
            double c = Convert.ToDouble(Console.ReadLine()); //Reads the number
            double t = c; //initialize t = c         
            double EPSILON = 1e-15;  
            while (Math.Abs(t*t - c) > EPSILON) // repeat until desired accuracy reached
            {
                t = (c/t + t) / 2.0; //replace t with the average of c/t and t
            }
            Console.WriteLine($"\nSquare Root of {c} : {t}");
        }
    }
}
