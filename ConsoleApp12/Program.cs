using System;

namespace task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0, m = 0;
            while (true)
            {
                Console.WriteLine("Введите два числа от 5-20 m и n");
                var input = Console.ReadLine();
                if (input == string.Empty)
                    return;

                var parts = input.Split();
                if (parts.Length == 2 &&
                    int.TryParse(parts[0], out m) &&
                    int.TryParse(parts[1], out n) &&
                    m >= 5 && m <= 20 &&
                    n >= 5 && n <= 20)
                    break;

                Console.WriteLine("Ошибка ввода");
            }

            var matrix = new int[m, n];
            var rnd = new Random();
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    matrix[i, j] = rnd.Next(0, 99);

            PrintTable(matrix);
            GetintNumber(matrix);
        }

        static void PrintTable(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i, j] + "\t");
                Console.WriteLine();
            }
        }

        static void GetintNumber(int[,] table)
        {
            Console.WriteLine("Введите цифру");
            if (!int.TryParse(Console.ReadLine(), out int g) || g < 0 || g > 9)
            {
                Console.WriteLine("Ошибка ввода цифры (0-9)");
                return;
            }

            int rows = table.GetLength(0);
            int cols = table.GetLength(1);
            bool found = false;


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int lastDigit = table[i, j] % 10;
                    if (lastDigit == g)
                    {
                        Console.WriteLine($"Найдено число {table[i, j]} с индексами [{i}, {j}]");
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine($"В массиве нет чисел, заканчивающихся на цифру {g}");
            }
            else
            {
                Console.WriteLine("Поиск завершен.");
            }
        }


    }
}
