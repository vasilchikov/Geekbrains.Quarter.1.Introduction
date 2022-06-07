using System;

namespace Lesson._2.Task._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число для проверки четности:");
            decimal.TryParse(Console.ReadLine(), out decimal num);
            Console.Write(CheckNum(num));
        }
        public static string CheckNum(decimal num)
        {
            return num == 0 ? "Введите числовое значение не равное нулю" 
                : num % 2 == 0 ? "Число четное" : "Число не четное"; 
        }
    }
}
