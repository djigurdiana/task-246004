using System;
namespace task10_6

{
    internal class Program
    { static void Main(string[] args)
        { 
        Console.Write("Введите натуральное число n: ");
        int n = int.Parse(Console.ReadLine());

        int SumOfDivisors(int x)
        {
            int sum = 0;
            for (int i = 1; i * i <= x; i++)
            {
                if (x % i == 0)
                {
                    sum += i;
                    int d2 = x / i;

                    if (d2 != x && d2 != i)
                        sum += d2;
                }
            }

            return sum;
        }

        Console.WriteLine("Дружественные пары чисел меньше n:");

        for (int a = 2; a < n; a++)
        {
            int b = SumOfDivisors(a);

            if (b > a && b < n) 
            {
                if (SumOfDivisors(b) == a)
                {
                    Console.WriteLine($"{a} и {b}");
                }
            }
        }
    }
}

        
    }




