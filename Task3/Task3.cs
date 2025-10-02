using System;

namespace Task3
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введіть ваш вік: ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int age))
            {
                Console.WriteLine($"Ваш вік: {age}");
                Console.WriteLine(ClassifyAge(age));
            }
            else
            {
                Console.WriteLine("Вік має бути цілим числом!");
            }
        }

        public static string ClassifyAge(int age)
        {
            if (age < 0 || age > 120)
                return "Нереальний вік";
            else if (age < 12)
                return "Ви дитина";
            else if (age <= 17)
                return "Підліток";
            else if (age <= 59)
                return "Дорослий";
            else
                return "Пенсіонер";
        }
    }
}

