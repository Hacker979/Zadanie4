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
            Console.WriteLine("Введите длины катетов прямоугольного треугольника:");
            double catet1 = double.Parse(Console.ReadLine());
            double catet2 = double.Parse(Console.ReadLine());
            double hypoten = Math.Sqrt(cathetus1 * cathetus1 + cathetus2 * cathetus2);
            Console.WriteLine("Гипотенуза: " + hypoten);

            Console.ReadLine();
        }
    }
}
