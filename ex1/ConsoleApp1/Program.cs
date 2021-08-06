using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1-е число");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите 2-е число");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите 1-е число");
            double c = Convert.ToDouble(Console.ReadLine());
            var min = a;
            if (a > b) min = b; else min = a;
            if (min > c) min = c; 
            Console.WriteLine(min);
        }
    }
}
