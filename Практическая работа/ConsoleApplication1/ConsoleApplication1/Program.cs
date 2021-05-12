using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задания номер 6.
            Console.WriteLine("Введите число");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число");
            double b = Convert.ToDouble(Console.ReadLine());
            double v1 = a*b*l;
            double v2 = l / (2 * Math.PI);
            double r = b / 2;
            double r1 = a / 2;         
            double x = v1 - v2;
            Console.WriteLine("%" + x);
            Console.ReadKey();
        }
    }
}
