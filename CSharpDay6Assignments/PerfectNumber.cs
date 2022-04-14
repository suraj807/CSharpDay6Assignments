using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay6Assignments
{
    internal class PerfectNumber
    {
        public void Perfect()
        {
            int sum = 0, actualnum;
            Console.WriteLine("Enter any number you want to find whether is Perfect or not : ");
            int no = Convert.ToInt32(Console.ReadLine()); // Reads the number
            actualnum = no;
            for (int i = 1; i < no; i++)//this loop will contine to number 
            {
                if (no % i == 0) // If any number between 1 to number divides the number
                {
                    sum = sum + i;//then add this number to sum
                }
            }
            if (sum == actualnum) // If final sum is equal to number then it's perfect number othewise not
            {
                Console.WriteLine($"\n{actualnum} number is a perfect number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"\n{actualnum} number is not a perfect number");
                Console.ReadLine();
            }
        }
    }
}
