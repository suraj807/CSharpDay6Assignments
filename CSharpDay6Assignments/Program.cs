using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay6Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day 6 Assignments Problems");
            Console.WriteLine("\nProblem 1 : Fiboacci Series\nProblem 2 : Perfect Number\nProblem 3 : Prime Number");
            Console.WriteLine("Problem 4 : Reverse a Number\nProblem 5 : Coupon Number Number");
            Console.WriteLine("Problem 6 : StopWatch\nProblem 7 : Vending Machine\nProblem 8 : Find week day of any date");
            Console.WriteLine("Problem 9 : Temprature Conversion\nProblem 10 : Monthly Payment Calculation\nProblem 11 : Find SquareRoot pf any number ");
            Console.WriteLine("Problem 12 : Decimal to Binary Conversion\nProblem 13 : Binary to Decimal Conversion\n");

            Console.WriteLine("Enter your choice : ");
            int a = Convert.ToInt32(Console.ReadLine());
            //Use switch case to run any particular program which user wants
            switch (a)
            {
                case 1:
                    FibonacciSeries series = new FibonacciSeries();
                    series.Fibonacci();
                    break;
                case 2:
                    PerfectNumber perfectNumber = new PerfectNumber();
                    perfectNumber.Perfect();
                    break;
                case 3:
                    PrimeNumber primeNumber = new PrimeNumber();
                    primeNumber.Prime();
                    break;
                case 4:
                    ReverseNumber reverseNumber = new ReverseNumber();
                    reverseNumber.Reverse();
                    break;
                case 5:
                    CouponNumber couponNumber = new CouponNumber();
                    couponNumber.Coupon();
                    break;
                case 6:
                    StopWatch stopWatch = new StopWatch();
                    stopWatch.TimeElapsed();
                    break;
                case 7:
                    VendingMachine vendingMachine = new VendingMachine();
                    vendingMachine.ChangeMoney();
                    break;
                case 8:
                    DayOfWeek dayOfWeek = new DayOfWeek();
                    dayOfWeek.Day();
                    break;
                case 9:
                    TempratureConversion temperatureConversion = new TempratureConversion();
                    temperatureConversion.Conversion();
                    break;
                case 10:
                    MonthlyPayment monthlyPayment = new MonthlyPayment();
                    monthlyPayment.Payment();
                    break;
                case 11:
                    SquareRoot squareRoot = new SquareRoot();
                    squareRoot.FindSqrt();
                    break;
                case 12:
                    DecimalToBinary decimalToBinary = new DecimalToBinary();
                    decimalToBinary.DToBConversion();
                    break;
                case 13:
                    BinaryToDecimal binaryToDecimal = new BinaryToDecimal();
                    binaryToDecimal.BToDConversion();
                    break;
            }
            Console.ReadLine();
        }
    }
}
