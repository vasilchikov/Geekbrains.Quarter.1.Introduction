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
                    "4. «Морской бой»: вывести на экран массив 10х10, состоящий из символов X и O, где Х — элементы кораблей, а О — свободные клетки.\n" +
                    "0. Для завершения работы программы введите \n" +
                    "\n \\ ");
                string number =  Console.ReadLine();
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
                        mes += Task3_1;
                        mes += Task3_2;
                        Executor(mes);
                        break;
                    case "4":
                        mes += Task4;
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
        /// <summary>
        /// Написать программу, выводящую элементы двумерного массива по диагонали
        /// </summary>
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
        /// <summary>
        /// Написать программу «Телефонный справочник»: создать двумерный массив 5х2, хранящий список телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона/email.
        /// </summary>
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
        /// <summary>
        /// Написать программу, выводящую введённую пользователем строку в обратном порядке (olleH вместо Hello).
        /// Способ 1: заполнить массив символов с последнего элемента
        /// </summary>
        static void Task3()
        {
            string str_v1 = "МАССИВ СИМВОЛОВ C#";
            Console.WriteLine($"Строка в исходном состоянии: {str_v1}");
            Console.WriteLine($"В обратном направлении: {RevertStr(str_v1)}\n");
            static string RevertStr(string inputStr)
            {
                char[] res = new char[inputStr.Length];
                int count = inputStr.Length-1;
                foreach (char s in inputStr)
                {
                    res.SetValue(s, count);
                    count--;
                }
                return new string(res);
            }
        }
        /// <summary>
        /// Написать программу, выводящую введённую пользователем строку в обратном порядке (olleH вместо Hello).
        /// Способ 2: Ручная перестановка элементов
        /// </summary>
        static void Task3_1()
        {
            string str_v1 = "МАССИВ СИМВОЛОВ C#";
            Console.WriteLine($"Строка в исходном состоянии: {str_v1}");
            Console.WriteLine($"В обратном направлении: {RevertStr(str_v1)}\n");
            static string RevertStr(string inputStr)
            {
                string outputStr = null;
                char[] chars = inputStr.ToCharArray();
                for(int i = chars.Length-1; i >= 0; i--)
                {
                    outputStr += chars[i];
                }
                return new string(outputStr);
            }
        }
        /// <summary>
        /// Написать программу, выводящую введённую пользователем строку в обратном порядке (olleH вместо Hello).
        /// Способ 3: С использованием метода Reverse класса Array
        /// </summary>
        static void Task3_2()
        {
            string str_v1 = "МАССИВ СИМВОЛОВ C#";
            Console.WriteLine($"Строка в исходном состоянии: {str_v1}");
            Console.WriteLine($"В обратном направлении: {RevertStr(str_v1)}\n");
            static string RevertStr(string inputStr)
            {
                char[] chars = inputStr.ToCharArray();
                Array.Reverse(chars);
                return new string(chars);
            }
        }
        /// <summary>
        /// *«Морской бой»: вывести на экран массив 10х10, состоящий из символов X и O, где Х — элементы кораблей, а О — свободные клетки.
        /// </summary>
        static void Task4()
        {

            /// <summary>
            /// Добавить корабль на игровое поле
            /// </summary>
            /// <param name="field">Игровое поле</param>
            /// <param name="deck">Кол-во палуб</param>
            /// <param name="x">Координата X</param>
            /// <param name="y">Координата Y</param>
            /// <param name="dir">направление расположения (-1 => горизонтали + вправо/ 1 => вертикали + вниз)</param>
            static void AddShip(char[,] field, int deck, int x, int y, int dir)
            {
                /*
                |.|.|.|.|.|
                |.|.|.|.|.|
                |.|X|X|X|X|
                |.|X|.|.|.|
                |.|X|.|.|.|
                */
                // Проверка возможности добавления корабля, клетки должны быть свободны (O)
                if (field[x, y] != 'O') return;
                for (int i = 1 ; i < deck; i++)
                    if (dir > 0 && (!IsCellValid(x + i, y) || 'O' != field[x + i, y])) return;
                    else if (dir < 0 && (!IsCellValid(x, y + i) || 'O' != field[x, y + i])) return;

                // Добавляем корабль
                field[x, y] = 'X'; // Начальная точка
                for (int i = 0; i < deck; i++)
                    if (dir > 0)
                        field[x + i, y] = 'X';
                    else
                        field[x, y + i] = 'X';
            }
            /// <summary>
            /// Проверка валидности клетки игрового поля
            /// </summary>
            /// <param name="x">Координата X</param>
            /// <param name="y">Координата Y</param>
            /// <returns>Результат проверки</returns>
            static bool IsCellValid(int x, int y)
            {
                return x >= 0 && x < 10 && y >= 0 && y < 10;
            }
            char[,] field = new char[10, 10];
            // Заполним все игровое поле свободными клетками (O)
            for (int i = 0; i < field.GetLength(0); i++)
                for (int j = 0; j < field.GetLength(1); j++)
                    field[i, j] = 'O';

            // Добавим корабли
            AddShip(field, 4, 0, 0, -1); // Четырехпалубный корабль по горизонтали
            AddShip(field, 3, 2, 5, 1); // Трехпалубный корабль по вертикали
            AddShip(field, 4, 6, 8, -1); // Четырехпалубный корабль по горизонтали
            PrintField(field);
            // Распечатаем игровое поле
            static void PrintField(char[,] field)
            {
                for (int i = 0; i < field.GetLength(0); i++)
                {
                    for (int j = 0; j < field.GetLength(1); j++)
                        Console.Write("{0}  ", field[i, j]);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
