using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lesson._2.Task._4
{
    internal class Program
    {
        public static void Main()
        {
            int counter = 0;
            double sum = 0;
            var builder = new StringBuilder();
            var buyerList = new List<Goods>
            {
                new Goods("Вода минеральная 0.5л", 8433, 44),
                new Goods("Батончик СНИНЕРС 140гр", 25499, 39),
                new Goods("Хлеб нарезной Добрыня", 30996, 29),
                new Goods("Сигареты ВИНСТОН супер лайт (мрц 71)", 30934, 71)
            };
            builder.AppendLine($"{"".PadRight(25, ' ')}Касса №2");
            foreach (var product in buyerList)
            {
                counter++;
                sum += product.price;
                builder.AppendLine($"{counter}.{product.name}");
                builder.AppendLine($"  Код:{product.code}");
                builder.AppendLine($"  Стоимость{"".PadRight(40 - product.price.ToString().Length, '.')}{product.price}");
            }
            builder.AppendLine("".PadRight(51, '='));
            builder.AppendLine($"Всего{"".PadRight(46 - sum.ToString().Length, '.')}{sum}");
            builder.AppendLine($"Скидка{"".PadRight(42, ' ')}15%");
            sum -= Math.Round(sum / 100 * 15, 2);
            builder.AppendLine($"Итог{"".PadRight(47 - sum.ToString().Length, ' ')}{sum}");
            File.WriteAllText("cheque.txt", builder.ToString());
            Console.Write(builder.ToString());

        }

        class Goods
        {
            public string name;
            public int code;
            public double price;
            public Goods(string name, int code, double price)
            {
                this.name = name;
                this.code = code;
                this.price = price;
            }
        }
    }
}
