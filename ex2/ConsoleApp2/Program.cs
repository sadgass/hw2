using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            var a = Convert.ToInt32(Console.ReadLine());
            var n = 0;
           
            for (int i = 1; a > 0; i++)
            {
                a = a / 10;

                n = i;
            }
            Console.WriteLine(n);


        }
    }
}
