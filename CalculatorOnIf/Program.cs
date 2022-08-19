using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOnIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Калькулятор на IF";

            double firstValue, secondValue;

            string oper;

            while (true)
            {
                Console.Clear();

                try
                {
                    firstValue = double.Parse(Console.ReadLine());

                    oper = Console.ReadLine();

                    secondValue = double.Parse(Console.ReadLine());

                }
                catch (Exception)
                {

                    Console.WriteLine("Не удалось преобразовать строку в число");
                    Console.ReadLine();
                    continue;
                }

                if (oper == "+")
                {
                    Console.WriteLine(firstValue + secondValue);
                }
                else if (oper == "-")
                {
                    Console.WriteLine(firstValue - secondValue);
                }
                else if (oper == "*")
                {
                    Console.WriteLine(firstValue * secondValue);
                }
                else if (oper == "/")
                {
                    if (secondValue == 0)
                        Console.WriteLine(0);
                    else
                        Console.WriteLine(firstValue / secondValue);           
                }
                else
                {
                    Console.WriteLine("Ошибка!");
                }

                Console.ReadLine();
            }
        }
    }
}
