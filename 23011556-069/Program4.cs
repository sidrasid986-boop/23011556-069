using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_069
{
    internal class Program4
    {
        public static void sum()
        {
            Console.WriteLine("Enter a number to calculate the sum from 1 to that number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            for (int a = 1; a <= n; a++)
            {
                s = s + a;

            }
            Console.WriteLine($"Sum is {s}");
        }
    }
}