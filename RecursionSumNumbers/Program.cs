using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionSumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Найти сумму цифр числа с помощью рекурсии 561 = 12

            Console.Write("Введите число: ");

            int a = int.Parse(Console.ReadLine());

            int result = SumDigitNumber(a);

            Console.WriteLine($"Сумма цифр числа {a} равна {result}");
        }

        static int SumDigitNumber(int a)
        {
            if (a < 10)
                return a;

            return a % 10 + SumDigitNumber(a / 10);
        }
    }
}
