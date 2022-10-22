using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodDelElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Написать методы для удаления первого элемента массива,
            // последнего элемента массива и элемента по указанному индексу

            int[] myArray = new int[] {1, 5, 4, 8 };

            int a = 1;

            //DelFirst(ref myArray);\

            //DelLast(ref myArray);

            DelToIndex(ref myArray, a);
        }

        static void DelFirst(ref int[] arr)
        {
            int[] arr1 = new int[arr.Length - 1];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = arr[i+1];
            }

            arr = arr1;
        }

        static void DelLast(ref int[] arr)
        {
            int[] arr1 = new int[arr.Length - 1];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = arr[i];
            }

            arr = arr1;
        }

        static void DelToIndex(ref int[] arr, int index)
        {
            int[] arr1 = new int[arr.Length - 1];

            for (int i = 0, j = 0; i < arr.Length; i++, j++)
            {
                if (i == index)
                {
                    j--;
                    continue;
                }

                arr1[j] = arr[i];
            }

            arr = arr1;
        }
    }
}
