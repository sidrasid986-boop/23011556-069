using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_069
{
    internal class Program7
    {
        public static void Reverse()
        {
            Console.WriteLine("Enter Number U want to reverse:");
            int num = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;
            while (num != 0)
            {
                int r = num % 10;
                reverse = reverse * 10 + r;
                num = num / 10;
            }
            Console.WriteLine($"Reverse Number is {reverse}");
        }
    }
}
