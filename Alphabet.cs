using System;

namespace DAY_5_Problems
{
    public class Alphabet
    {
        public Char ch;

        public void VowelOrConsonant()
        {
            Console.WriteLine("Please Input an Alphabet (A-Z or a-z)");
            ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u'
                || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine(ch + " is an Vowel");
            }
            else
            {
                Console.WriteLine(ch + " is a Consonant");
            }
        }
    }
}
