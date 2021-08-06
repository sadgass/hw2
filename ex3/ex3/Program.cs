using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 0;
            Console.WriteLine("Введите число");
            var a = Convert.ToDouble(Console.ReadLine());
            while (a!=0)
            {
                if ((a % 2 != 0) && (a > 0)) n++;
                Console.WriteLine("Введите число");
                a = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine(n);
        }

    }
}
