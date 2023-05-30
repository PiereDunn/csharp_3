using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину послеовательности: ");
            int count = Convert.ToInt32(Console.ReadLine());
            int minNum = int.MaxValue;
            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine($"Введите число {i}: ");
                int num = Convert.ToInt32(Console.ReadLine());
                
                if(num < minNum)
                {
                    minNum = num;
                }
            }
            Console.WriteLine($"Наименьшее число: {minNum}");
            Console.ReadKey();
        }
    }
}
