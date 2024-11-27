using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp_2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.3. Дан радиус окружности. Найти ее диаметр.
            Console.WriteLine("Найдите диаметр окружности");
        input:
            Console.Write("Радиус окружности равен: ");
            double r = Convert.ToDouble(Console.ReadLine());
            while (!(r > 0))
            {
                Console.WriteLine("Вы ввели неверное значение");
                goto input;
            }
            double D = 2 * r;
            Console.WriteLine("Диаметр окружности равен " + D);
        }
    }
}
