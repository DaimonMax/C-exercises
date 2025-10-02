using System;

namespace Task1
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введіть ціле число: ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                Console.WriteLine($"Ваше число: {number}");
                Console.WriteLine(GetMessage(number));
            }
            else
            {
                Console.WriteLine("Це не ціле число!");
            }
        }
        

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static string GetMessage(int number)
        {
            if (IsEven(number))
                return "Двері відкриваються!";
            else
                return "Двері зачинені...";
        }
    }
}

