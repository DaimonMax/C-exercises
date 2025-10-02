using System;

namespace Task2
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int[] numbers = GenerateRandomArray(10, 1, 100);

            Console.WriteLine("Масив чисел: " + string.Join(", ", numbers));

            Console.WriteLine("Сума: " + GetSum(numbers));
            Console.WriteLine("Середнє: " + GetAverage(numbers));
            Console.WriteLine("Мінімум: " + GetMin(numbers));
            Console.WriteLine("Максимум: " + GetMax(numbers));
        }
        public static int[] GenerateRandomArray(int size, int min, int max)
        {
            Random rnd = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
                arr[i] = rnd.Next(min, max + 1);
            return arr;
        }
        public static int GetSum(int[] numbers)
        {
            int sum = 0;
            foreach (int n in numbers)
                sum += n;
            return sum;
        }
        public static double GetAverage(int[] numbers)
        {
            return (double)GetSum(numbers) / numbers.Length;
        }
        public static int GetMin(int[] numbers)
        {
            int min = numbers[0];
            foreach (int n in numbers)
                if (n < min) min = n;
            return min;
        }
        public static int GetMax(int[] numbers)
        {
            int max = numbers[0];
            foreach (int n in numbers)
                if (n > max) max = n;
            return max;
        }
    }
}


