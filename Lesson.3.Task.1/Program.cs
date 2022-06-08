using System;

namespace Lesson3.Task._1
{
    internal class Program
    {
        public delegate void Message();
        static Message mes;
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.Write("Выберете номре задания задание для проверки: \n\n" +
                    "1. Вывод элементов двумерного массива по диагонали\n" +
                    "2. Телефонный справочник в двумерном массиве 5*2\n" +
                    "3. Написать программу, выводящую введенную пользователем строку в обратном порядке (olleHвместо Hello).\n" +
                    "0. Для заверения работы программы введите \n" +
                    "\n \\ ");
                string number = Console.ReadLine();
                switch (number)
                {
                    case "1":
                        mes += Task1;
                        Executor(mes);
                        break;
                    case "2":
                        mes += Task2;
                        Executor(mes);
                        break;
                    case "3":
                        mes += Task3;
                        Executor(mes);
                        break;
                    default:
                        {
                            Console.WriteLine("Завершение работы программы");
                            Console.ReadKey(true);
                            return;
                        }
                }
            }
            while (true);
        }
        static void Executor(Message message)
        {
            Console.Clear();
            message();
            Console.Write("\n\nДля перехода в главное меню нажмите Ввод\n\n \\");
            Console.ReadKey(true);
            mes = null;
        }
        public static void Task1()
        {
            Console.Write($"Введите размерность двумерного массива через запятую [y,x]: ");
            string[] arrStr = Console.ReadLine().Split(',');
            int[,] arr = new int[int.Parse(arrStr[0]), int.Parse(arrStr[1])];
            Random rnd = new Random();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(0, 22);
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("================================");

            //вывести элементы двумерного массива по диагонали:
            int x = 0;
            int y = Console.CursorTop; //arr.GetLength(0) + 1;

            foreach (int i in arr)
            {
                Console.SetCursorPosition(x++, y++);
                Console.Write(i);
            }
        }
        public static void Task2()
        {
            //Console.Write("Выполнение метода Task2()");

        }
        public static void Task3()
        {
            Console.Write("Выполнение метода Task3()");
        }
    }
}
