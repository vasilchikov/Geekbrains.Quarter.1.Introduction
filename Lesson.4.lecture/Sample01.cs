using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson._4.lecture
{
    internal class Sample01
    {
        static void Swap(ref int a, ref int b)
        {
            a = b + a;
            b = a - b;
            a = a - b;
        }
        static bool DoProcess(out int a)
        {
            a = 100;
            return true;
        }
        static void Main(string[] args)
        {
            int m = 10;
            DoProcess(out m);

            int a = 5;
            int b = 3;

            Console.WriteLine($"a -> {a}");
            Console.WriteLine($"b -> {b}");
            Console.WriteLine();

            int c = a;
            a = b;
            b = c;

            Console.WriteLine($"a -> {a}");
            Console.WriteLine($"b -> {b}");
            Console.WriteLine();

            a = b + a;
            b = a - b;
            a = a - b;

            Console.WriteLine($"a -> {a}");
            Console.WriteLine($"b -> {b}");
            Console.WriteLine();

            Swap(ref a, ref b);

            Console.WriteLine($"a -> {a}");
            Console.WriteLine($"b -> {b}");
            Console.WriteLine();

            Console.Write("Введите первое целое число:");
            //int firstNumber;
            if(int.TryParse(Console.ReadLine(), out int firstNumber))
            {
                Console.WriteLine($"Вы ввели число: {firstNumber}");
            }
            else
            {
                Console.WriteLine("Вы ввели некорректное число");
                Console.WriteLine("Завершение работы программы...");
                Console.ReadKey(true);
                return;
            }

            Console.Write("Введите второе целое число:");
            if (int.TryParse(Console.ReadLine(), out int secondNumber))
            {
                Console.WriteLine($"Вы ввели число: {secondNumber}");
            }
            else
            {
                Console.WriteLine("Вы ввели некорректное число");
                Console.WriteLine("Завершение работы программы...");
                Console.ReadKey(true);
                return;
            }
            int max;
            if(firstNumber > secondNumber)
            {
                max = firstNumber;
            }
            else
            {
                max = secondNumber;
            }
            Console.WriteLine($"Максимальное число: {max}");

            //if - then - else
            max = firstNumber > secondNumber ? firstNumber : secondNumber;
            Console.WriteLine($"Максимальное число: {max}");

            Console.WriteLine("Максимальное число: {0}", firstNumber > secondNumber ? firstNumber : secondNumber);

            Console.WriteLine($"Максимальное число: {(firstNumber > secondNumber ? firstNumber : secondNumber)}");

            Console.WriteLine("{0} {1} {2} {3} {4}", 10, 'c', true, 10.5, "abc");

            Console.WriteLine($"Сумма чисел: {Sum(1, 2, 3, 4, 5, 6, 7, 8, 9)}");

            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int[] arr2 = { 7, 8, 9, 10, 11 };

            Console.WriteLine($"Сумма чисел: {Sum(arr)}");
            Console.WriteLine("Числа в массиве: {0}", arr2);

            Console.ReadKey(true);
        }
        static int Sum(params int[] numbers)
        {
            int res = 0;
            foreach(int number in numbers)
            {
                res += number;
            }
            return res;
        }
    }
}
