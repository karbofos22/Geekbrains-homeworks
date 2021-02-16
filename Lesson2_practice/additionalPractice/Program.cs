using System;

namespace additionalPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, которая определяет является ли год високосным, и выводит сообщение в консоль.
            //Каждый 4 - й год является високосным, кроме каждого 100 - го, при этом каждый 400 - й – високосный.

            Console.WriteLine("Введите год, чтобы узнать високосный он или нет");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0 && year % 100 == 0 && year % 400 == 0)
            {
                Console.WriteLine($"{year} - високосный год");
            }
            else
                Console.WriteLine("Введенный год не является високосным");


        }
    }
}
