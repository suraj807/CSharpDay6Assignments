using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay6Assignments
{
    internal class MonthlyPayment
    {
        public void Payment()
        {
            double principleAmount,year,rate,n,r,monthPayAmount;
            Console.WriteLine("\nEnter Principal Loan Amount : "); 
            principleAmount = Convert.ToDouble(Console.ReadLine()); // Reads the total Loan Number
            Console.WriteLine("\nHow many years to pay off Principle Amount : "); 
            year = Convert.ToDouble(Console.ReadLine());  // Reads the year
            Console.WriteLine("\nEnter rate of interest per year : ");
            rate = Convert.ToDouble(Console.ReadLine()); // Reads th rate
            //Applying formula to calculate the monthly payment
            n = 12 * year;
            r = rate/(12*100);
            monthPayAmount = (principleAmount*r)/(1-Math.Pow(1+r, -n));
            Console.WriteLine($"\nMonthly Payment you have to pay off {principleAmount} Loan Amount over {year} years is : {monthPayAmount}");
        }
    }
}
