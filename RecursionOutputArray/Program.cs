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

            PrintArray(arr, 0);
        }

        static void PrintArray(int[] arr, int i)
        {
            if (i >= arr.Length)
                return;

            Console.WriteLine(arr[i]);

            i++;

            PrintArray(arr, i);
        }
    }
}
