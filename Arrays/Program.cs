using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов в массиве: ");

            int elementsCount = int.Parse(Console.ReadLine());

            int[] myArray = new int[elementsCount];

            Console.WriteLine("Введите элементы массива");

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Массив в обратном порядке:");

            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.WriteLine();

            Console.Write("Сумма чётных чисел в массиве: ");

            int sumEvenNumberArray = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                    sumEvenNumberArray += myArray[i];                
            }

            Console.WriteLine(sumEvenNumberArray);

            Console.WriteLine(myArray.Where(i => i % 2 == 0).Sum());

            Console.WriteLine();

            Console.Write("Наименьшее число в массиве: ");

            int minValueArray = int.MaxValue;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < minValueArray)
                {
                    minValueArray = myArray[i];
                }
            }

            Console.WriteLine(minValueArray);

            Console.WriteLine(myArray.Min());
        }
    }
}
