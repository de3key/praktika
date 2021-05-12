using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            double X1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число");
            double Y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число");
            double X2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число");
            double Y2 = Convert.ToDouble(Console.ReadLine());             
            double a = (Y1 - Y2) / (X1 - X2);
            Console.WriteLine("a равно:" + a);
            double b = (Y1 - a * X1);
            Console.WriteLine("b равно:" + b);
            Console.ReadKey();
        }
    }
}
