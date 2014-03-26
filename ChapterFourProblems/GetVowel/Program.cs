using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            while (true)
            {
                Console.WriteLine("Enter a vowel");
                input = Console.ReadLine().ToLower();

                if (input == "a" || input == "e" || input == "i" || input == "o" || input == "u")
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("Not a Vowel");
                }
                if (input == "!")
                {
                    break;
                }
                    
            }
        }
    }
}
