using System;

namespace Lesson3_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1 - Написать программу, выводящую элементы двумерного массива по диагонали.




            int[,] mas = new int [6,6];
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (i == j)
                        mas[i, j] = 8;
                    Console.Write(mas[i, j] + " ");
                }

                Console.WriteLine();
            }

        }
    }
}


        