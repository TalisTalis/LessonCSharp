using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionSumElementsArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Найти сумму элементов массива с помощью рекурсии

            int[] arr = { 1, 2, 3, 7};

            int sum = 0;

            int result = SumElementsArray(arr);

            Console.WriteLine($"Сумма элементов массива равна {result}.");
        }

        static int SumElementsArray(int[] arr, int i = 0)
        {
            if (i >= arr.Length)
                return 0;

            return arr[i] + SumElementsArray(arr, i + 1);
        }
    }
}
