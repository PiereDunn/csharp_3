using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int tryCount = 0;
            int userNum;
            Console.WriteLine("Введите максимальное число для последовательности: ");
            int maxCount = Convert.ToInt32(Console.ReadLine());
            int trueNum = rand.Next(0, maxCount + 1);

            while (true)
            {
                Console.Write($"Введите число от 0 до {maxCount}: ");
                userNum = Convert.ToInt32(Console.ReadLine());
                tryCount++;
                if(userNum < trueNum)
                {
                    Console.WriteLine("Введенное число меньше загаданного!");
                }
                else if(userNum > trueNum)
                {
                    Console.WriteLine("Введенное число больше загаданного!");
                }
                else
                {
                    Console.WriteLine($"Число угадано! Попытки: {tryCount}") ;
                    Console.ReadKey();
                    break;
                }

                if(Console.ReadLine() == string.Empty)
                {
                    Console.WriteLine($"Загаданное число: {trueNum}");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
