using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodResize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Написать метод Resize изменяющий количество элементов массива
            // (метод должен иметь возможность увеличивать или уменьшать количество элементов массива)

            int[] myArray = new int[] {1, 6, 5, 3, 8};

            Resize(ref myArray, 10);            
        }

        static void Resize<T>(ref T[] arr, int newSize)
        {
            T[] arr1 = new T[newSize];

            for (int i = 0; i < newSize && i < arr.Length; i++)
            {
                arr1[i] = arr[i];
            }

            arr = arr1;
        }
    }
}
