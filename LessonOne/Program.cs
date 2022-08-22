using System;

namespace LessonOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[10, 6];

            Random random = new Random();

            int heght = myArray.GetLength(0);

            int width = myArray.GetLength(1);

            for (int i = 0; i < heght; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    myArray[i, j] = random.Next(100);
                }
            }

            for (int i = 0; i < heght; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(myArray[i, j] + "\t");
                }

                Console.WriteLine();
            }

        }
    }
}
