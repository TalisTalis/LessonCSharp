using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodAddElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Написать методы для добавления элемента в начало массива,
            // в конец массива и по указанному индексу

            int[] myArray = new int[] {7, 3, 4, 8, 1, 5, 7, 1, 6, 2};

            int a = 4;

            //AddFirst(ref myArray, a);

            //AddLast(ref myArray, a);

            AddToIndex(ref myArray, a, a);
        }

        static void AddFirst(ref int[] arr, int value)
        {
            AddToIndex(ref arr, value, 0);
        }

        static void AddLast(ref int[] arr, int value)
        {
            AddToIndex(ref arr, value, arr.Length);
        }

        static void AddToIndex(ref int[] arr, int value, int index)
        {
            int[] arr1 = new int[arr.Length + 1];

            arr1[index] = value;

            for (int i = 0; i < index; i++)
            {
                arr1[i] = arr[i];
            }

            for (int i = index; i < arr.Length; i++)
            {
                arr1[i + 1] = arr[i];
            }

            arr = arr1;
        }
    }
}
