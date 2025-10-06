using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_069 
{
    internal class Program1
    {
        public static void CheckEvenOdd()
        {
            Console.WriteLine("Enter Number:");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
        }
    }
}
