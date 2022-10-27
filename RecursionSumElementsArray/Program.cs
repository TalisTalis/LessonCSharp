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

            SumElementsArray(arr, ref sum, 0);

            Console.WriteLine($"Сумма элементов массива равна {sum}.");
        }

        static void SumElementsArray(int[] arr, ref int sum, int i)
        {
            if (i == arr.Length)
                return;
            
            sum += arr[i];

            i++;

            SumElementsArray(arr, ref sum, i);
        }
    }
}
