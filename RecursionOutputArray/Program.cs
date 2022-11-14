using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionOutputArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Реализовать вывод массива с помощью рекурсии

            int[] arr = { 1, 5, 67, 3, 34 };

            PrintArray(arr);
        }

        static void PrintArray(int[] arr, int i = 0)
        {
            if (i < arr.Length)
            {
                Console.WriteLine(arr[i]);

                PrintArray(arr, i + 1);
            }
        }
    }
}
