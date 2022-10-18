using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodOutputString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Написать метод, который выводит а экран строку.
            // Символы, из которых состоит строка, и количество символов вводятся пользователем

            Console.Write("Введите символ: ");

            string str = Console.ReadLine();

            Console.Write("Введите количество символов в строке: ");

            int count = int.Parse(Console.ReadLine());

            OutpuString(str, count);
        }

        static void OutpuString(string str, int count)
        {
            string result = "";

            for (int i = 0; i < count; i++)
            {
                result += str;
            }

            Console.WriteLine(result);
        }
    }
}
