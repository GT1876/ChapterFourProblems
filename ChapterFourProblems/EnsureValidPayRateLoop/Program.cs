using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnsureValidPayRateLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double n;
            while (true)
            {
                Console.WriteLine("Enter a Hourly Pay Rate");
                {
                    input = Console.ReadLine();
                    n = Convert.ToDouble(input);

                   
                }
                if (n < 5.65 || n > 49.99)
                {
                    break;
                }
            }

        }
    }
}
