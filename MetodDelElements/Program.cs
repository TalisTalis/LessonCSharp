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

            //DelFirst(ref myArray);

            //DelLast(ref myArray);

            DelToIndex(ref myArray, a);
        }

        static void DelFirst(ref int[] arr)
        {
            DelToIndex(ref arr, 0);
        }

        static void DelLast(ref int[] arr)
        {
            DelToIndex(ref arr, arr.Length - 1);
        }

        static void DelToIndex(ref int[] arr, int index)
        {
            int[] arr1 = new int[arr.Length - 1];

            for (int i = 0; i < index; i++)
            {
                arr1[i] = arr[i];
            }

            for (int i = index + 1; i < arr.Length; i++)
            {
                arr1[i - 1] = arr[i];
            }

            arr = arr1;
        }
    }
}
