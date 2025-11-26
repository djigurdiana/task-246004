using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace task10_5

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите сколько км лыжник пробежал в первый день");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("Напишите процент увелиения пробегаемого расстояния");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine("Конечная цель в км");
            double k = double.Parse(Console.ReadLine());

            int day = 1;
            double distance = n;

            while (distance <= k)
            {
                distance *= (1 + m/100);
                day++;
            }
            Console.WriteLine($"Лыжник пробежить больше {k} километров в {day} день");





        }
    }
}

