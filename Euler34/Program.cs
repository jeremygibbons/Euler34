using System;
using System.Collections.Generic;
using System.Linq;

namespace Euler34
{
    class Program
    {

        static int[] factorials = new int[] {1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880 };

        static void Main(string[] args)
        {
            List<int> results = new List<int>();
            int n = 10;
            while(n < 10000000)
            {
                int p = n;
                int sum = 0;
                while(p > 0)
                {
                    sum += factorials[p % 10];
                    p = p / 10;
                }
                if(sum == n)
                {
                    Console.WriteLine(n);
                    results.Add(n);
                }
                n++;
            }
            Console.WriteLine(results.Sum());
            Console.ReadLine();
        }
    }
}
