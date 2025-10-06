using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_069
{
    internal class Program8
    {
        public static void MaxorMin()
        {
            int[] arr = new int[10];

            Console.WriteLine("Enter 10 integers:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Element {i + 1}: ");
                string? input = Console.ReadLine();
                arr[i] = int.Parse(input ?? "0");
            }

            int max = arr[0];
            int min = arr[0];

            for (int i = 1; i < 10; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
                if (arr[i] < min)
                    min = arr[i];
            }

            Console.WriteLine($"\nMaximum value: {max}");
            Console.WriteLine($"Minimum value: {min}");
        }
    }
    
}
