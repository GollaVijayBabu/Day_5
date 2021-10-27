using System;

namespace DAY_5_Problems
{
    public class Tables
    {
        public int N, X;

        public void Power()
        {
            Console.WriteLine("Enter the Number");
            X = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the last number to print tables");
            N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(X + " * " + i + " = " + X * i + "\n");
            }

        }
    }
}
