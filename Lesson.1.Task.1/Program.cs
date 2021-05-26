using System;

namespace Lesson._1.Task._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя пользователя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Привет " + name + ", сегодня [" + DateTime.Now + "]");// конкатенация
            Console.WriteLine($"Привет {name}, сегодня [{DateTime.Now}] ");//интерполяция
            Console.WriteLine("Привет {0}, сегодня [{1}]", name, DateTime.Now);

            /*запуск из терминала:
            вид > терминал > 
            cd .. //переидти в каталог с проектом
            dotnet run 
             */
        }
    }
}
