using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введит число x:");

            double x;
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Некорректный ввод. Введите число x:");
            }

            Console.WriteLine($"f({x:F2}) = {F(x):F2}");
        }
        static double F(double x)
        {
            if (x>1)
            return 2-x;

            else if (-1 <= x && x <= 1) 
            return x*x;

            else 
            return (1);

            

        }


        
    }
}