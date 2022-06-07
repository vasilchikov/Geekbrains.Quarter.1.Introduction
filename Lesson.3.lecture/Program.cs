using System;

namespace Lesson._3.lecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 3, 2, 4, 6, 5, 4, 6, 4, 6, 9 };
            int e = 3;
            PrintArray(arr);
            Console.WriteLine($"Элемент {e} найден по индексу {FindElement(arr, e)}");

            Array.Sort(arr);
            PrintArray(arr);
            Console.WriteLine($"Элемент {e} найден по индексу {Array.BinarySearch(arr, e)}");

            int[,] arr2 = new int[5, 5];
            Random rnd = new Random();

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    arr2[i, j] = rnd.Next(-99, 100);
                    Console.Write($"{arr2[i, j]}\t");
                }
                Console.WriteLine();
            }
            int eX = 0;
            int eY = 0;
            int max = arr2[eX, eY];

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    if (arr2[i, j] > max)
                    {
                        max = arr2[i, j];
                        eX = i;
                        eY = j;
                    }
                }
            }
            Console.WriteLine($"Значение максимального элемента равно: {max}");
            Console.WriteLine($"Индекс максимального элемента [{eX},{eY}]");
            //ArrayList f;

            //Далее методичка
            int[][] a = new int[3][];
            a[0] = new int[3];
            a[1] = new int[3];
            a[2] = new int[3];
            int a00 = a[0][0];
            a[1][1] = 1;

            int[,] b = new int[5, 5];
            b[2, 2] = 1;

            int[,] matrix = new int[5, 5];
            matrix[2, 2] = 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int n = 0;
            while (n < 5)
            {
                Console.Write($"{n}\t");
                n++;
            }
            Console.WriteLine();

            n = 0;
            do
            {
                Console.Write($"{n}\t");
                n++;
            }
            while (n < 5);
            Console.WriteLine();

            string[] students =
            {
                "Иванов",
                "Петров",
                "Сидоров",
                "Петрова",
                "Филиппова",
                "Егоров",
                "Козлова",
            };
            Console.Write("Введите фамилию студента: ");
            string lastName = Console.ReadLine();
            bool isFound = false;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] == lastName)
                {
                    Console.WriteLine($"Студент с фамилией {lastName} находится под номером { i + 1}");
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("Такого студента нет в списке :(");
            }

            string greeting = "Hello, world";
            for (int i = 0; i < greeting.Length; i++)
            {
                Console.Write($"{greeting[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine($"{System.Text.Encoding.Default.HeaderName}");

            Console.ReadKey(true);
        }
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine();
        }
        static int FindElement(int[] arr, int e)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == e)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}