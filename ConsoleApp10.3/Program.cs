using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace task10_3;


internal class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите натуральное число:");
        double n = double.Parse(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("Ошибка ввода");
            return;
        }
        int i = 1;
        for (int i = 1; i <= n; i++)
        {
            while (i * i <= n) ;

        }
        Console.WriteLine("i");
        i++;




    }

}
