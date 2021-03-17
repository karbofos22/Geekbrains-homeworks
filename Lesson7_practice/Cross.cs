using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lesson7_practice
{
    class Cross
    {
        static int WIN_Count = 4;
        static int SIZE_X = 5;
        static int SIZE_Y = 5;

        static char[,] field = new char[SIZE_Y, SIZE_X];

        static char PLAYER_DOT = 'X';
        static char AI_DOT = 'O';
        static char EMPTY_DOT = '.';

        static Random random = new Random();

        private static void InitField()
        {
            for (int i = 0; i < SIZE_Y; i++)
            {
                for (int j = 0; j < SIZE_X; j++)
                {
                    field[i, j] = EMPTY_DOT;
                }
            }
        }

        private static void PrintField()
        {
            Console.Clear();
            Console.WriteLine("-------");
            for (int i = 0; i < SIZE_Y; i++)
            {
                Console.Write("|");
                for (int j = 0; j < SIZE_X; j++)
                {
                    Console.Write(field[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------");
        }

        private static void SetSym(int y, int x, char sym)
        {
            field[y, x] = sym;
        }

        private static bool IsCellValid(int y, int x)
        {
            if (x < 0 || y < 0 || x > SIZE_X - 1 || y > SIZE_Y - 1)
            {
                return false;
            }

            return field[y, x] == EMPTY_DOT;
        }

        private static bool IsFieldFull()
        {
            for (int i = 0; i < SIZE_Y; i++)
            {
                for (int j = 0; j < SIZE_X; j++)
                {
                    if (field[i, j] == EMPTY_DOT)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private static void PlayerStep()
        {
            int x;
            int y;
            do
            {
                Console.WriteLine($"Введите координаты X Y (1-{SIZE_X})");
                x = Int32.Parse(Console.ReadLine()) - 1;
                y = Int32.Parse(Console.ReadLine()) - 1;
            } while (!IsCellValid(y, x));
            SetSym(y, x, PLAYER_DOT);
        }

        private static void AiStep()
        {
            int x;
            int y;
            do
            {
                x = random.Next(0, SIZE_X);
                y = random.Next(0, SIZE_Y);
            } while (!IsCellValid(y, x));
            SetSym(y, x, AI_DOT);
        }


        // проверка на победу
        private static bool CheckWinLine(char sym) //Задание 2 и 3.  Переделать проверку победы + игра 5х5 и 4 фишки.
        {
            for (int i = 0; i < SIZE_X; i++)
            {         
                for (int j = 0; j < SIZE_Y; j++)
                {
                    if (checkLine(i, j, 1, 0, WIN_Count, sym)) return true;   
                    if (checkLine(i, j, 1, 1, WIN_Count, sym)) return true;  
                    if (checkLine(i, j, 0, 1, WIN_Count, sym)) return true;   
                    if (checkLine(i, j, 1, -1, WIN_Count, sym)) return true;
                }
            }
            return false;
        }
        private static bool checkLine(int x, int y, int vx, int vy, int len, char c)
        {
            int far_x = x + (len - 1) * vx;           
            int far_y = y + (len - 1) * vy;
            if (!IsCellValid(far_x, far_y)) return false;
            for (int i = 0; i < len; i++)
            {                
                if (field[y + i * vy, x + i * vx] != c) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            InitField();
            PrintField();

            while (true)
            {
                PlayerStep();
                PrintField();
                if (CheckWinLine(PLAYER_DOT))
                {
                    Console.WriteLine("Player Win!");
                    break;
                }
                if (IsFieldFull())
                {
                    Console.WriteLine("DRAW");
                    break;
                }
                AiStep();
                PrintField();
                if (CheckWinLine(AI_DOT))
                {
                    Console.WriteLine("SkyNet Win!");
                    break;
                }
                if (IsFieldFull())
                {
                    Console.WriteLine("DRAW");
                    break;
                }
            }
        }
    }
}



