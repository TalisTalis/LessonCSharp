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

            Resize(ref myArray, 2);
        }

        static void Resize (ref int[] arr, int count)
        {
            int[] arr1 = new int[count];

            for (int i = 0; i < count; i++)
            {
                if (i == arr.Length)
                {
                    break;
                }

                arr1[i] = arr[i];
            }

            arr = arr1;
        }
    }
}
