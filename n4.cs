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
            Console.WriteLine("Введите сторону квадрата (целое число):");
            int side = int.Parse(Console.ReadLine());
            int perimeterInt = 4 * side;
            int areaInt = side * side;
            Console.WriteLine("Периметр квадрата (целый тип): " + perimeterInt);
            Console.WriteLine("Площадь квадрата (целый тип): " + areaInt);

            Console.WriteLine("Введите сторону квадрата (вещественное число):");
            double sideD = double.Parse(Console.ReadLine());
            double perimeterD = 4 * sideD;
            double areaD = sideD * sideD;
            Console.WriteLine("Периметр квадрата (вещественный тип): " + perimeterD);
            Console.WriteLine("Площадь квадрата (вещественный тип): " + areaD);

            Console.ReadLine();
        }
    }
}
