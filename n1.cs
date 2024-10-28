using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны прямоугольника (целые числа):");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int perimeterInt = 2 * (a + b);
            int areaInt = a * b;
            Console.WriteLine("Периметр (целый тип): " + perimeterInt);
            Console.WriteLine("Площадь (целый тип): " + areaInt);

            Console.WriteLine("Введите стороны прямоугольника (вещественные числа):");
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double perimeterDouble = 2 * (c + d);
            double areaDouble = c * d;
            Console.WriteLine("Периметр (вещественный тип): " + perimeterDouble);
            Console.WriteLine("Площадь (вещественный тип): " + areaDouble);

            Console.ReadLine();
        }
    }
}
