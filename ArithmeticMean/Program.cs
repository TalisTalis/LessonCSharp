using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticMean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Среднее арифметическое двух чисел";

            double firstValue, secondValue, result;

            Console.WriteLine("Введите число 1:");

            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 2:");

            secondValue = double.Parse(Console.ReadLine());

            result = (firstValue + secondValue) / 2;

            Console.WriteLine("Среднее арифметическое чисел " + firstValue + " и " + secondValue + " равно " + result);
        }
    }
}
