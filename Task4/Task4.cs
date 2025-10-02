using System;

namespace Task4
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введіть сторону a: ");
            string? input_a = Console.ReadLine();
            if (double.TryParse(input_a, out double a))
            {
                Console.WriteLine($"Сторона а = {a}");
            }
            else 
            {
                Console.WriteLine("Сторона має бути числом!");
                Environment.Exit(0);
            }

            Console.Write("Введіть сторону b: ");
            string? input_b = Console.ReadLine();
            if (double.TryParse(input_b, out double b))
            {
                Console.WriteLine($"Сторона b = {b}");
            }
            else
            {
                Console.WriteLine("Сторона має бути числом!");
                Environment.Exit(0);
            }

            Console.Write("Введіть сторону c: ");
            string? input_c = Console.ReadLine();
            if (double.TryParse(input_c, out double c))
            {
                Console.WriteLine($"Сторона c = {c}");
            }
            else
            {
                Console.WriteLine("Сторона має бути числом!");
                Environment.Exit(0);
            }

            if (IsValidTriangle(a, b, c))
            {
                Console.WriteLine("Периметр: " + GetPerimeter(a, b, c));
                Console.WriteLine("Площа: " + GetArea(a, b, c));
                Console.WriteLine("Тип трикутника: " + GetTriangleType(a, b, c));
            }
            else
            {
                Console.WriteLine("Трикутник не існує!");
            }
        }

        public static bool IsValidTriangle(double a, double b, double c)
        {
            return a > 0 && b > 0 && c > 0 &&
                   a + b > c && a + c > b && b + c > a;
        }

        public static double GetPerimeter(double a, double b, double c)
        {
            return a + b + c;
        }

        public static double GetArea(double a, double b, double c)
        {
            double p = GetPerimeter(a, b, c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public static string GetTriangleType(double a, double b, double c)
        {
            if (a == b && b == c)
                return "Рівносторонній";
            else if (a == b || b == c || a == c)
                return "Рівнобедрений";
            else if (((a * a + b * b - c * c) == 0) || ((a * a + c * c - b * b) == 0) || ((b * b + c * c - a * a) == 0))
                return "Прямокутний";
            else
                return "Довільний";
        }
    }
}

