using System;

namespace Lesson3.Task._1
{
    internal class Program
    {
        delegate void Message();
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
        static void Task1()
        {
            //формируем и выводим исходный двумерный массив:
            Console.Write($"Введите размерность двумерного массива через запятую [i,j]: ");
            string[] arrStr = Console.ReadLine().Split(',');
            int[,] arr = new int[int.Parse(arrStr[1]), int.Parse(arrStr[0])];
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

            //выводим элементы двумерного массива по диагонали:
            int x = 0;
            int y = Console.CursorTop; //arr.GetLength(0) + 1;

            foreach (int i in arr)
            {
                Console.SetCursorPosition(x++, y++);
                Console.Write(i);
            }
        }
        static void Task2()
        {
            string[,] Phone_dir =
            {

                {"Иванов","+7-111-111-11-11 / 111@yandex.ru"},
                {"Петров","+7-222-222-22-22 / 222@yandex.ru"},
                {"Сидоров", "+7-333-333-33-33 / 333@yandex.ru"},
                {"Васильчиков","+7-444-444-44-44 / 444@yandex.ru" },
                {"Кибирев","+7-555-555-55-55 / 555@yandex.ru"}
            };

            for (int i = 0; i < Phone_dir.GetLength(0); i++)
            {
                for (int j = 0; j < Phone_dir.GetLength(1); j++)
                {
                    Console.SetCursorPosition(j * 20,i);
                    Console.Write($"{Phone_dir[i, j]}");
                }
                Console.WriteLine();
            }
        }
        static void Task3()
        {
            string str_v1 = "Строка в исходном состоянии";
            Console.WriteLine($"{RevertStr(str_v1)}");
            static string RevertStr(string str)
            {
                char[] res = new char[str.Length];
                int count = str.Length-1;
                foreach (char s in str)
                {
                    res.SetValue(s, count);
                    count--;
                }
                return new string(res);
            }
        }
    }
}
