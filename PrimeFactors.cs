﻿using System;

namespace DAY_5_Problems
{
    public class PrimeFactors
    {
        public int N;

        public void Factor()
        {
            Console.WriteLine("Enter The Number To Find It's Prime Factors");
            N = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; N > 1; i++)
            {
                while (N % i == 0)
                {
                    N = N / i;
                    Console.WriteLine("Prime Factors are: " + i);
                }
            }
        }

    }
}
