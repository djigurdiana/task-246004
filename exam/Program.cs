using System;



class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введите строку на русском языке:");
        string text = Console.ReadLine();
        string vowelsLower = "аеёиоуыэюя";


        Dictionary<char, int> vowelCounts = new Dictionary<char, int>();
        int totalVowels = 0;

        foreach (char ch in text.ToLower())
        {
            if (vowelsLower.Contains(ch))
            {
                totalVowels++;

                if (vowelCounts.ContainsKey(ch))
                    vowelCounts[ch]++;
                else
                    vowelCounts[ch] = 1;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Подсчёт гласных (без учёта регистра):");

        foreach (var pair in vowelCounts.OrderBy(kvp => kvp.Key))
        {
            Console.WriteLine($"Буква '{pair.Key}': {pair.Value}");
        }

        Console.WriteLine($"Общее количество гласных: {totalVowels}");
    }
}
