using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_069
{
    internal class Program2
    {
        public static void Calculator()
        {
            Console.WriteLine("Enter 1 Number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2 Number:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Operator u want to apply operations on number:");
            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    Console.WriteLine($"{a} + {b}={a + b}");
                    break;
                case "-":
                    Console.WriteLine($"{a} - {b}={a - b}");
                    break;
                case "*":
                    Console.WriteLine($"{a} * {b}={a * b}");
                    break;
                case "/":
                    Console.WriteLine($"{a} / {b}={a / b}");
                    break;
                default:
                    Console.WriteLine("This operation not Available");
                    break;
            }
        }
    }
}
