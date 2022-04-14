using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay6Assignments
{
    internal class CouponNumber
    {
        public void Coupon()
        {
            Console.WriteLine("\nHow many numbers you want to add as distinct coupon numbers : ");
            int no = Convert.ToInt32(Console.ReadLine()); // Read the number as how many number user want to add as distinct coupon number
            int[] distinctCouponNumbers = new int[no]; // Creating array of distinct coupon numbers
            Console.WriteLine($"\nEnter any {no} numbers you want to add as coupon number : ");
            for(int i = 0; i < no; i++) 
            {
                int a = Convert.ToInt32(Console.ReadLine()); // Reads the distinct coupon numbers from user
                while (true) // This loop will continue until all array elements to be fill with distinct numbers
                {
                    if (Array.Exists(distinctCouponNumbers, x => x == a)) // checks if number given by user is already present in arry or not
                    {
                        Console.WriteLine($"\n{a} is already exists");
                        Console.WriteLine("\nPlease enter again");
                        a = Convert.ToInt32(Console.ReadLine()); // If already present then reads input again
                    }
                    else
                    {
                        distinctCouponNumbers[i] = a; // If it's distinct coupon number then store it in array
                        break;
                    }
                }              
            }
            Console.WriteLine("\nYour entered Distinct Numbers are : ");
            for (int i = 0; i < distinctCouponNumbers.Length; i++) // This loop just printing all distinct coupon numbers enter by user
            {
                Console.Write(distinctCouponNumbers[i]+" ");
            }
            int count = 0;
            Random random = new Random(); // creating Random class object
            Console.WriteLine("\n");
            while (true) //This loop continue till all the distinct numbers will cover
            {               
                int randomNumber = random.Next(distinctCouponNumbers.Min(), distinctCouponNumbers.Max()); // Generating Random Number
                count++; // Counting how many random number are generated
                Console.WriteLine($"Generated Random number is : {randomNumber}");
                if (Array.Exists(distinctCouponNumbers, x => x == randomNumber)) // checks if random number is already present in arry or not
                {
                    int item = randomNumber;
                    distinctCouponNumbers = distinctCouponNumbers.Where(e => e != item).ToArray(); // If present then remove this element from array
                    if (distinctCouponNumbers.Length == 0) // If array length is zero that means all elements are covered then break
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"\n\nTotal random numbers generated to get the all dictinct coupon numbers are : {count}"); 
        }
    }
}
