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

            Console.Write("Введите длину массива: ");

            uint length = uint.Parse(Console.ReadLine());

            Console.Write("Введите минимальное значение: ");

            int minValue = int.Parse(Console.ReadLine());

            Console.Write("Введите максимальное значение: ");

            int maxValue = int.Parse(Console.ReadLine());
            
            int[] myArray = GetRandoArray(length, minValue, maxValue);

            PrintArray(myArray);

            Console.Write("\nВведите искомое число в массиве: ");

            int searchNumber = int.Parse(Console.ReadLine());

            int res = FindIndexMassive(myArray, searchNumber);

            if (res == -1)
                Console.WriteLine("Данного элемента в массиве нет.");
            else
                Console.WriteLine($"Элемент {searchNumber} в массиве под индексом {res}");
        }

        static int[] GetRandoArray(uint length, int minValue, int maxValue)
        {
            int[] array = new int[length];

            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(minValue, maxValue);
            }

            return array;
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        static int FindIndexMassive(int[] metodArray, int element)
        {
            for (int i = 0; i < metodArray.Length; i++)
            {
                if (metodArray[i] == element)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
