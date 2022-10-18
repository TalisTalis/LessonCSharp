using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodSearchIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Написать метод для поиска индекса массива (тип элементов в массиве - int)
            // Метод должен вернуть индекс первого найденного элемента (если он будет найден)

            int[] myArray = { 4, 5, 76, 79, 234, 8};

            Console.Write("Введите искомое число в массиве: ");

            int searchNumber = int.Parse(Console.ReadLine());

            int res = FindIndexMassive(myArray, searchNumber);

            if (res == -1)
            {
                Console.WriteLine("Данного элемента в массиве нет.");
            }
            else
            {
                Console.WriteLine($"Элемент {searchNumber} в массиве под индексом {res}");
            }
        }

        static int FindIndexMassive(int[] metodArray, int element)
        {
            int findElement = -1;
            
            for (int i = 0; i < metodArray.Length; i++)
            {
                if (metodArray[i] == element)
                {
                    findElement = i;

                    break;
                }
            }

            return findElement;
        }
    }
}
