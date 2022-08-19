using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionAndMultiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Сумма и произведение трёх чисел";

            double firstValue, secondValue, thirdValue;

            Console.WriteLine("Введите число 1:");

            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 2:");

            secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 3:");

            thirdValue = double.Parse(Console.ReadLine());

            double addResult = firstValue + secondValue + thirdValue;

            double multResult = firstValue * secondValue * thirdValue;

            Console.WriteLine("Сумма чисел " + firstValue + ", " + secondValue + ", " + thirdValue + " = " + addResult);

            Console.WriteLine("Произведение чисел " + firstValue + ", " + secondValue + ", " + thirdValue + " = " + multResult);
        }
    }
}
