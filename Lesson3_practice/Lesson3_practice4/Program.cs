using System;

namespace Lesson3_practice4
{
    class Program
    {
        static void Main(string[] args)
        {
            //*«Морской бой»: вывести на экран массив 10х10, состоящий из символов X и O, где Х — элементы кораблей, а О — свободные клетки.

            char[,] battle = new char[10, 10];
            
            for (int i = 0; i < battle.GetLength(0); i++)
            {
                for (int j = 0; j < battle.GetLength(1); j++)
                {
                    if (j % 2 == 0 && j == 4)
                    {
                        battle[i, j] = 'X';
                        Console.Write(battle[i, j] + " ");
                    //}
                    //else if (j % 2 == 0 || j == 3)
                    //{
                    //    battle[i, j] = 'X';
                    //    Console.Write(battle[i, j] + " ");
                    } else
                    {
                        battle[i, j] = 'O';
                        Console.Write(battle[i, j] + " ");
                    }
                }

                Console.WriteLine();
            }

        }
    }
}
