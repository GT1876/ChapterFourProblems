using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Perfect
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 1000; i++)
            {
                int sum = 0;

                for(int n = 1; n < i; n++)
                {

                    if (i % n == 0)
                    {

                        sum = sum + n;

                    }

                }
                if (sum == i)
                    Console.WriteLine(sum);
            }
        }
    }
}
