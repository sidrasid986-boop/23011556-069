using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_069
{
    internal class Program3
    {
        public static void Grades()
        {
            Console.WriteLine("Enter Your Numbers for finding Grades:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num >= 85)
            {
                Console.WriteLine("Grade A");
            }
            else if (num >= 70)
            {
                Console.WriteLine("Grade B");
            }
            else if (num >= 55)
            {
                Console.WriteLine("Grade C");
            }
            else if (num >= 40)
            {
                Console.WriteLine("Grade D");
            }
            else
            {
                Console.WriteLine("Grade F");
            }
        }
    }
}
