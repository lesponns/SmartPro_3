using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Değer kayıt
            string username;
            //Kullanıcıdan istenen değerin ne olduğu
            Console.Write("Name: ");
            //Kullanıcıdan gelen değeri okuma ve text değerine kayıt
            username = Console.ReadLine();
            Console.Clear();

            if (username == "Lesponns" /*Koşul durumu*/)
            {
                // Ek koşul durumu ve sonuç yazılır
                Console.Clear();
                Console.WriteLine("Welcome back " + username);
            }
            else if (username == "Mustafa")
            {
                //else if, 1. koşul yani if'in sağlanmadığı durumda geçerlidir.
                Console.Clear();
                Console.WriteLine("Welcome back " + username);
            }
            else if (username == "Admin")
            {
                //1. ve 2. koşulun sağlanmadığı durumda geçerlidir.
                Console.Clear();
                Console.WriteLine("Welcome back " + username);
            }
            else
            {
                //if koşullarının sağlanmadığı durumda son çare olarak geçerlidir.
                Console.Clear();
                Console.WriteLine("User not found!");
            }
            Console.ReadKey();  
        }
    }
}
