using System;

namespace Lesson._2.Task._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string numMomthStr;
            decimal numMomthDec;
            bool Ex = false;
            do
            {
                if (Ex) Console.WriteLine("Вы ввели некорректное значение. ");
                Console.Write("Введите номер месяца который Вы хотите увидеть (целое число в интервале от 1 до 12): ");
                numMomthStr = Console.ReadLine();
            }
            while (Ex = ((decimal.TryParse(numMomthStr, out numMomthDec)) == false) | numMomthDec < 1 | numMomthDec > 12);
            Console.WriteLine("Название месяца под номером {0} - {1}", numMomthStr, new DateTime().AddMonths(Convert.ToInt32(numMomthDec - 1)).ToString("MMMM"));
        }
    }
}
