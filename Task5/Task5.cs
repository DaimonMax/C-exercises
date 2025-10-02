using System;

namespace Task5
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int[][] groups = new int[][]
            {
            new int[] {10, 15, 25, 35, 55},
            new int[] {65, 70, 75, 50, 95},
            new int[] {100, 90, 60, 40, 25}
            };

            PrintGroupResult(groups);
        }

        public static double GetAverage(int[] marks)
        {
            int sum = 0;
            foreach (int mark in marks)
                sum += mark;
            return (double)sum / marks.Length;
        }

        public static int GetMin(int[] marks)
        {
            int min = marks[0];
            foreach (int mark in marks)
                if (mark < min) min = mark;
            return min;
        }

        public static int GetMax(int[] marks)
        {
            int max = marks[0];
            foreach (int mark in marks)
                if (mark > max) max = mark;
            return max;
        }

        public static void PrintGroupResult(int[][] groups)
        {
            for (int i = 0; i < groups.Length; i++)
            {
                Console.WriteLine(
                    $"Група {i + 1}: Середній = {GetAverage(groups[i]):F2}, " + $"Мінімальний = {GetMin(groups[i])}, " + 
                    $"Максимальний = {GetMax(groups[i])}");
            }
        }
    }
}
