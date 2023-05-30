using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nВведите число: ");
            int count = Convert.ToInt32(Console.ReadLine());

            if(count % 2 == 0)
            {
                Console.WriteLine($"Число четное!");
            }
            else
            {
                Console.WriteLine($"Число нечетное!");
            }

            Console.ReadKey();
        }
    }
}
