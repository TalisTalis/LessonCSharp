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

            int sum = 0;

            int numberLength = a.ToString().Length - 1;

            SumDigitNumber(a, ref sum, numberLength);

            Console.WriteLine($"Сумма цифр числа {a} равна {sum}");
        }

        static void SumDigitNumber(int a, ref int sum, int i)
        {
            if (i < 0)
                return;

            sum += (a / (int)Math.Pow(10, i)) % 10;

            i--;

            SumDigitNumber(a, ref sum, i);
        }
    }
}
