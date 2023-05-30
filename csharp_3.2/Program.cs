using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите колличество карт: ");
            int cardTotal = int.Parse(Console.ReadLine());
            int sum = 0;
            string j = "J";
            string q = "Q";
            string k = "K";
            string t = "T";
            for (int i = 1; i <= cardTotal; i++)
            {
                Console.Write($"Введите номинал карты {i} : ");
                string card = Console.ReadLine();

                // Не понял, почему то в свиче не приравнивается
                //switch (card)
                //{
                //    case j: sum = sum + 10; break;
                //    case q: sum = sum + 10; break;
                //    case k: sum = sum + 10; break;
                //    case t: sum = sum + 10; break;

                //    default: int value = int.Parse(card); sum = sum + value; break;
                //}

                if (card == j || card == q || card == k || card == t)
                {
                    sum = sum + 10;
                }
                else
                {
                    int value = int.Parse(card); sum = sum + value;
                }
            }
            Console.Write($"Сумма карт : { sum}");
            Console.ReadKey();
        }
    }
}
