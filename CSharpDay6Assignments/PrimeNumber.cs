using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay6Assignments
{
    internal class PrimeNumber
    {
        public void Prime()
        {
            int prime = 0;
            Console.WriteLine("\nEnter any number you want to find whether is Prime or not : ");
            int no = Convert.ToInt32(Console.ReadLine()); //Reads the number

            if (no == 0 || no == 1) // 0 and 1 is not a prime number
            {
                Console.WriteLine($"{no} is not a Prime Number");
            }
            else
            {
                for (int i = 2; i < no; i++)
                {
                    if ((no % i) == 0) // If any number between 1 to number divides the number ,then numbder is not prime number
                    {
                        prime = 0; 
                        break;
                    }
                    else
                    {
                        prime = 1;
                    }
                }

                if (prime == 1)
                {
                    Console.WriteLine($"{no} is a Prime Number");
                }
                else
                {
                    Console.WriteLine($"{no} is not a Prime Number");
                }
            }
        }
    }
}
