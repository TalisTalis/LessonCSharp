using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Конвертер валют";

            double USDtoRUB = 57.39;

            double USDtoUAH = 36.75;

            double USD;

            Console.WriteLine("Введите сумму в USD:");

            USD = double.Parse(Console.ReadLine());

            double convertResultRUB = USD * USDtoRUB;

            double convertResultUAH = USD * USDtoUAH;

            Console.WriteLine("Сумма в рублях: " + convertResultRUB + " RUB");

            Console.WriteLine("Сумма в гривнах: " + convertResultUAH + " UAH");
        }
    }
}
