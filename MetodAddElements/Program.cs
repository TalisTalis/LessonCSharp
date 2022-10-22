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
            int[] arr1 = new int[arr.Length + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                arr1[i+1] = arr[i];
            }

            arr = arr1;

            arr[0] = value;
        }

        static void AddLast(ref int[] arr, int value)
        {
            int[] arr1 = new int[arr.Length + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                arr1[i] = arr[i];
            }

            arr = arr1; 

            arr[arr.Length - 1] = value;

        }

        static void AddToIndex(ref int[] arr, int index, int value)
        {
            int[] arr1 = new int[arr.Length + 1];

            for (int i = 0, j = 0; i < arr1.Length; i++, j++)
            {
                if (i == index)
                {
                    arr1[i] = value;

                    j--;

                    continue;
                }

                arr1[i] = arr[j];
            }

            arr = arr1;
        }
    }
}
