using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay6Assignments
{
    internal class ReverseNumber
    {
        public void Reverse()
        {
            Console.WriteLine("\nEnter any number you want to find reverse : ");
            int number = Convert.ToInt32(Console.ReadLine()); //Reads te number

            int reverse = 0, actualnumber;
            actualnumber = number;
            while (number > 0) //this loops will continue till number is greater than 0
            {
                reverse = (reverse * 10);//Extracting last digit of number
                reverse = reverse + (number % 10);//Storing the extracted number one by one
                number = number / 10;//Removing last element
            }
            Console.WriteLine($"\nThe reverse of {actualnumber} is : {reverse}");
        }
    }
}
