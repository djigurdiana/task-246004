using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            var n = long.Parse(Console.ReadLine());

            long lastDigit = n % 10;
            long count = 0;
            long temp = n;

                    while (temp > 0)
        {
            long digit = temp % 10;   
            if (digit == lastDigit)  
                count++;

            temp /= 10;            
        }

        Console.WriteLine($"Цифра {lastDigit} встречается {count} раз.");


        }
    }
}