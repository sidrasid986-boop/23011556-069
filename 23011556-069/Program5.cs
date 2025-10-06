using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_069
{
    internal class Program5
    {
        public static void Mutiplication()
        {
            Console.WriteLine("Enter the Number Of u want Table:");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 1;
            while (a <= 10)
            {
                Console.WriteLine($"{n} * {a} = {n * a}");
                a++;
            }
        }
    }
}