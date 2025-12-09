using System;

namespace Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целые значения первого члена арифметической прогрессии");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите разность прогрессии");
            var d = int.Parse(Console.ReadLine());

            int[] array = new int[10];
            for(int i = 0; i < 10; i++) 
            {
                array[i] = a + i * d;  
            }

            PrintArray(array);
            
            Console.WriteLine("Введите число k");
            var k = int.Parse(Console.ReadLine());

            for(int i = 0; i < array.Length; i++)
            {
                array[i] += k;
            }

            PrintArray(array);
            CountOddNumbers(array);
            CountDegree(array);
        }

        static void PrintArray(int[] arr) 
        {
            Console.WriteLine(string.Join(", ", arr));
        }

        static void CountOddNumbers(int[] arr)
        {
            int countOdd = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] % 2 != 0)
                {
                    countOdd++;
                }
            }
            Console.WriteLine(countOdd);
        }

        static void CountDegree(int[] arr)
        {
            Console.WriteLine("Введите степень:");
            var degree = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = (int)Math.Pow(arr[i], degree);
            }
            
            PrintArray(arr);
        }
    }
}
