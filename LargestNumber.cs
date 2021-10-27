using System;

namespace DAY_5_Problems
{
    public class LargestNumber
    {
        public int a, b, c;

        public void Max()
        {
            Console.WriteLine("Please enter the value of first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the value of second number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the value of third number");
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("Largest number is: " + a);
            }
            else if (b > c)
            {
                Console.WriteLine("Largest number is: " + b);
            }
            else
            {
                Console.WriteLine("Largest number is: " + c);
            }

        }
    }
}

