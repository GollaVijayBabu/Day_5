using System;

namespace DAY_5_Problems
{
    public class HarmonicNumber
    {
        public int N;
        public float Sum = 1;

        public void Series()
        {
            Console.WriteLine("Enter the nth Harmonic Number");
            N = Convert.ToInt32(Console.ReadLine());
            if (N != 0 && N > 0)
            {
                for (float i = 2; i <= N; i++)
                {
                    Sum += 1 / i;
                }
                Console.WriteLine("nth Harmonic Nuber is: " + Sum);
            }
            else
            {
                Console.WriteLine("Enter nth Harmonic Number Greater than Zero");
            }
        }

    }
}
