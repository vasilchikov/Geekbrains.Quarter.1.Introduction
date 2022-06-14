using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson._4.lecture
{
    internal class Sample03
    {
        static void Main(string[] args)
        {
            f(3);
            Console.ReadKey(true);
        }

        static void f(int n)
        {
            Console.Write($"{n} ");
            if (n >= 3)
            {
                f(n - 1);
                f(n - 2);
                f(n - 2);
            }
        }
    }
}
