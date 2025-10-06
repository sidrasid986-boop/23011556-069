using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_069
{
    internal class Program10
    {
        public static void Search()
        {
            Console.WriteLine("Write HOw many Numbets u want to enter in array:");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[a];

            Console.WriteLine("Enter Numbers:");
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine($"Enter NUmber {i + 1}");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enetr number u want to search:");
            int s = Convert.ToInt32(Console.ReadLine());
            for (int b = 0; b < a; b++)
            {
                if (num[a] == s)
                {
                    Console.WriteLine("NUmber exist in arrry");
                }
                else
                {
                    Console.WriteLine("Number does't exist in array");
                }
            }
        }
    }
}
