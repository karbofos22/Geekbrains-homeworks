using System;

namespace Lesson_practice3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 3 - Написать программу, выводящую введённую пользователем строку в обратном порядке (olleH вместо Hello).

            Console.WriteLine("Напишите что-нибудь, чтобы вывести надпись задом наперед");
            string word = Console.ReadLine();
            for (int i = word.Length -1; i >=0; i--)
            {
                Console.Write(word[i]);
            }
        }
    }
}
