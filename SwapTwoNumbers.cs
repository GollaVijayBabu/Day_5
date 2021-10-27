using System;

namespace DAY_5_Problems
{
    public class SwapTwoNumbers
    {
        public int a, b;

        public void Swap()
        {
            Console.WriteLine("Enter the value of first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of second number");
            b = Convert.ToInt32(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Value of first number after swap is: " + a);
            Console.WriteLine("Value of second number after swap is: " + b);

        }
    }
}
