using System;

namespace DAY_5_Problems
{
    public class EvenOrOdd
    {
        public int N;

        public void evenOdd()
        {
            Console.WriteLine("Enter the value of Number");
            N = Convert.ToInt32(Console.ReadLine());

            if (N % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
    }
}


