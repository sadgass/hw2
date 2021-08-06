using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            var login = "root";
            var password = "GeekBrains";
          
            var i = 0;
            while (i <= 3)
            {
                Console.WriteLine("Введите ваш логин");
                var guestlogin = Console.ReadLine();
                Console.WriteLine("Введите ваш пароль");
                var guestpassword = Console.ReadLine();

                if ((guestlogin != login) || (guestpassword != password))
                {
                    Console.WriteLine("Ваш логин или пароль не верен");
                    i++;
                }
                else if ((guestlogin == login) && (guestpassword == password))
                {
                    Console.WriteLine("Успешно, вы открыли доступ в систему");
                    break;
                }
               
            }
           if (i>3)
            Console.WriteLine("Количсетво неверных попыток превысило лимит");

        }
    }
}
