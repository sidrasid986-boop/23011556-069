using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_069
{
    internal class Program6
    {
        public static void Factorial()
        {
            Console.WriteLine("Enter the Number of U want Factorial");
            int n = Convert.ToInt32(Console.ReadLine());
            int f = 1, a = 1;
            while (a <= n)
            {
                f = f * a;
                a++;
            }
            Console.WriteLine($"Factorial of {n} is {f}");

        }
    }
}
