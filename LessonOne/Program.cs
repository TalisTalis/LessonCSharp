using System;

namespace LessonOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[2, 3];            

            int heght = myArray.GetLength(0);

            int width = myArray.GetLength(1);

            for (int i = 0; i < heght; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    
                    myArray[i, j] = int.Parse(Console.ReadLine());
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
