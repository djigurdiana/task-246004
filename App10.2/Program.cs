using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Task10_1
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел");
            int n;
            if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Ошибка ввода");
                return;
            }

            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите число {i}:");
                double ai;
                if (!double.TryParse(Console.ReadLine(), out ai))
                {
                    Console.WriteLine("Ошибка ввода");
                    return;

                }

                if ((i - 1) % 4 < 2)
                    sum += ai;
                else
                    sum -= ai;

            }
            Console.WriteLine($"Результат: {sum}");




        }

    }
}
