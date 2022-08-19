using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumEvensAndOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Колличество чётных и нечётных чисел";

            int currentValue, limit;
            uint evenNumberCount = 0; 
            uint oddNumberCount = 0;
            int sumEvenNumber = 0;
            int sumOddNumber = 0;

            Console.WriteLine("Введите первое число диапазона:");

            currentValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите последнее число диапазона:");

            limit = int.Parse(Console.ReadLine());

            while (currentValue <= limit)
            {                
                if (currentValue % 2 == 0)
                {
                    evenNumberCount++;
                    sumEvenNumber += currentValue;
                }
                    
                else
                {
                    oddNumberCount++;
                    sumOddNumber += currentValue;
                }

                currentValue++;
            }

            Console.WriteLine("Количество чётных чисел: " + evenNumberCount);
            Console.WriteLine("Сумма чётных чисел = " + sumEvenNumber);
            Console.WriteLine("Количество нечётных чисел: " + oddNumberCount);
            Console.WriteLine("Сумма нечётных чисел = " + sumOddNumber);
        }
    }
}
