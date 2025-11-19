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
            Console.WriteLine("Введите действительное число а");
            int b;
            Console.WriteLine("Введите шаг h");
            double h;
            if (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Ошибка ввода");
                return;
            }
            if (b == 0)
            {
                Console.WriteLine("Число не должно быть равно 0");
                return;
            }
            if (!double.TryParse(Console.ReadLine(), out h))
            {
                Console.WriteLine("Ошибка ввода");
                return;
            }

            double lowBorder = 1;
            double hinches = h;
            for (double a = lowBorder; a <= b; a += hinches)

            {
                double cm = a * 2.54;
                Console.WriteLine("{0} дюймов = {1} см", a, cm);
                Console.WriteLine("{0} дюймов = {1:f2} см", a, cm);
            }

        }
    }
}
