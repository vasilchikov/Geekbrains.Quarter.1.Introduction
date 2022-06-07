using System;

namespace Lesson._2.Task._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] requests = { "Введите температуру утром: ", "Введите температуру днем: ", "Введите температуру вечером: " };
            Console.WriteLine($"Средняя температура за сутки: {GetAverage(requests)}\n");

            string[] requests2 = { "Введите инимальную температуру за сутки: ", "Введите максимальную температуру за сутки: " };
            Console.WriteLine($"Средняя температура за сутки: {GetAverage(requests2)}\n");
        }
        public static double GetAverage(string[] requests, int sum = 0)
        {
            foreach (string req in requests)
            {
                Console.Write(req);
                sum += Convert.ToInt16(Console.ReadLine());
            }
            return sum != 0 ? sum / requests.Length : 0;
        }
    }
}
