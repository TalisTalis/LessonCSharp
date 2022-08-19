using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Чёт или нечёт";

            int a;

            Console.WriteLine("Введите число");

            a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Чёт!");
            }
            else
            {
                Console.WriteLine("Нечёт!");
            }
        }
    }
}
