using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nВведите число: ");
            int count = Convert.ToInt32(Console.ReadLine());
            int num = 2;
            bool simpleNumCheck = false;

            while (count > num)
            {
                if (count % num == 0)
                {
                    simpleNumCheck = true;
                }
                //Console.WriteLine($"{num}");
                //Console.WriteLine($"{simpleNumCheck}");
                num++;
            }

            if(simpleNumCheck == false)
            {
                Console.WriteLine($"Число простое!");
            }
            else if(simpleNumCheck)
            {
                Console.WriteLine($"Число не является простым!");
            }

            Console.ReadKey();
        }
    }
}
