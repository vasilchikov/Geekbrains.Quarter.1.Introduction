using System;
using System.Collections.Generic;
using System.Threading;
using System.Reflection;

namespace Lesson._1.Task._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя пользователя: ");
            string name = Console.ReadLine();

            List<object> list = new List<object>
            {
                "Привет " + name + ", сегодня [" + DateTime.Now + "]",// конкатенация
                $"Привет {name}, сегодня [{DateTime.Now}] ",//интерполяция
                ("Привет {0}, сегодня [{1}]", name, DateTime.Now)
            };
            PrintList(list);
            
            void PrintList(List<object> list)
            {
                foreach (object str in list)
                {
                    if (str.ToString().IndexOf("{0}") > 0)
                    {
                        Console.WriteLine("Привет {0}, сегодня [{1}]", name, DateTime.Now); 
                    }
                    else
                    {
                        foreach (var s in str.ToString())
                        {
                            Thread.Sleep(15);
                            Console.Write(s);
                        }
                        Console.WriteLine();
                    } 
                }
            }
            /*запуск из терминала:
            вид > терминал > 
            cd .. //переидти в каталог с проектом
            dotnet run 
             */
        }

    }
}
