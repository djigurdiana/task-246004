using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите имя: ");
        string name = Console.ReadLine();
        Console.WriteLine("Введите возраст: ");
        int age = int.Parse(Console.ReadLine());
        

        var person = (имя: name, возраст: age);

        if (person.возраст >= 18)
        {
            Console.WriteLine($"Добро пожаловать, {person.имя}!");
        }
        else
        {
            Console.WriteLine($"Привет, {person.имя}! Доступ ограничен.");
        }

        var (имя, возраст) = person;
        Console.WriteLine($"Информация о вас: {имя}, {возраст} лет.");

        string category = возраст switch
        {
            < 18 => "несовершеннолетний",
            >= 18 => "совершеннолетний",
            
        };
        Console.WriteLine($"Категория: {category}");

        



        
    }
}


