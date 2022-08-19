using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOnSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Калькулятор на SWITCH";

            double firstValue, secondValue;

            string oper;

            firstValue = double.Parse(Console.ReadLine());

            oper = Console.ReadLine();

            secondValue = double.Parse(Console.ReadLine());

            switch (oper)
            {
                case "+":
                    Console.WriteLine(firstValue + secondValue);
                    break;
                case "-":
                    Console.WriteLine(firstValue - secondValue);
                    break;
                case "*":
                    Console.WriteLine(firstValue * secondValue);
                    break;
                case "/":
                    if (secondValue == 0)
                        Console.WriteLine(0);
                    else
                        Console.WriteLine(firstValue / secondValue);     
                    break;
                default:
                    Console.WriteLine("Ошибка!!!");
                    break;
            }
        }
    }
}
