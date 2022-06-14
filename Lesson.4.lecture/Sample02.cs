using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson._4.lecture
{
    internal class Sample02
    {
        static void Main(string[] args)
        {
            char[] chars =
            {
                'j',
                '\u006A',
                (char)106
            };
            Console.WriteLine(string.Join(" ",chars));
            char symbol01 = 'a';
            Console.WriteLine($"{symbol01} {char.ToUpper(symbol01)}");
            UnicodeCategory category = char.GetUnicodeCategory('+');

            string str01;
            str01 = "Hello";
            str01 = "Hello, GeekBrains!";
            string str02 = "";
            string str03 = string.Empty;
            string str04 = new string(new char[] { 'H', 'e', 'l', 'l', 'o' });
            string str05 = new string('a', 10);

            string str06 = "Hello, GeekBrains!";

            Console.WriteLine(str01 == str06);
            Console.WriteLine(str01.Equals(str06));

            MyString myString01 = new MyString(new char[] { 'H', 'e', 'l', 'l', 'o' });
            MyString myString02 = new MyString(new char[] { 'H', 'e', 'l', 'l', 'o' });

            Console.WriteLine(myString01 == myString02);
            Console.WriteLine(myString01.Equals(myString02));

            Console.WriteLine(str01);
            Console.WriteLine(myString01);

            string message = "За окном потоп, а я ем торт";
            PrintWords(message);

            Console.ReadKey(true);
        }

        static string[] separators = { ",", ".", "!", "?", ";", ";", " " };

        static void PrintWords(string message)
        {
            string[] words =  message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for(int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= 3 && words[i][0] == words[i][words[i].Length - 1])
                {
                    Console.WriteLine(words[i]);
                }
            }
        }
    }
    class MyString
    {
        private char[] arr;
        public MyString(char[] arr)
        {
            this.arr = arr;
        }
        public override bool Equals(object obj)
        {
            if (obj is MyString)
            {
                MyString myString = (MyString)obj;
                if(this.arr.Length != myString.arr.Length)
                    return false;
                for(int i = 0; i < this.arr.Length; i++)
                {
                    if (this.arr[i] != myString.arr[i])
                    return false;
                }
                return true;
            }
            return false;
        }
        public static bool operator == (MyString o1, MyString o2)
        {
            return o1.Equals(o2);
        }
        public static bool operator != (MyString o1, MyString o2)
        {
            return !o1.Equals(o2);
        }
        public override string ToString()
        {
            return new string(arr);
        }
    }
}
