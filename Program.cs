using System;

namespace DAY_5_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FlipCoin");

            FlipCoin flip = new FlipCoin();
            flip.Coin();

            LeapYear year = new LeapYear();
            year.Year();

            Tables number = new Tables();
            number.Power();

            HarmonicNumber harmonic = new HarmonicNumber();
            harmonic.Series();

            PrimeFactors prime = new PrimeFactors();
            prime.Factor();

            QuotientAndRemainder qr = new QuotientAndRemainder();
            qr.compute();

            SwapTwoNumbers numbers = new SwapTwoNumbers();
            numbers.Swap();

            EvenOrOdd evenOrOdd = new EvenOrOdd();
            evenOrOdd.evenOdd();

            Alphabet leter = new Alphabet();
            leter.VowelOrConsonant();

            LargestNumber largest = new LargestNumber();
            largest.Max();
        }
    }
}
