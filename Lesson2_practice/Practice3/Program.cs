using System;

namespace Practice3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 3 - определение четного
            Console.WriteLine("Введите любое число");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Вы ввели четное число");
            }
            else
            {
                Console.WriteLine("Вы ввели нечетное число");
            }
            Console.ReadKey();
        }
    }
}
