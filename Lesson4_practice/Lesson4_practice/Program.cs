using System;
using System.Linq;

namespace Lesson4_practice
{
    class Program
    {

        // Задание 1. Написать метод GetFullName(string firstName, string lastName, string patronymic), 
        // принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО. 
        // Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.

        //static void Main(string[] args)
        //{
        //    string[] names = new string[4];
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        names[i] = GetFullName();
        //    }
        //    foreach (string i in names)
        //    {
        //        Console.WriteLine($"Введенные ФИО:\n {i}");
        //    }
        //}
        //static string GetFullName()
        //{
        //    Console.WriteLine("Введите фамилию");
        //    string lastName = Console.ReadLine();
        //    Console.WriteLine("Введите имя");
        //    string firstName = Console.ReadLine();
        //    Console.WriteLine("Введите отчество");
        //    string patronymic = Console.ReadLine();
        //    return $"{lastName} {firstName} {patronymic}";
        //}



        //Задание 2. Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, и возвращающую число — сумму всех чисел в строке. 
        //Ввести данные с клавиатуры и вывести результат на экран.(Честно скопированно после полного разбора с учителем в личке)

        //static void Main(string[] args)
        //{

        //    Console.WriteLine(GetSum(Console.ReadLine()));
        //    Console.WriteLine();
        //}
        //static int GetSum(string inputLine)
        //{
        //    int sum = 0;
        //    string number = "";
        //    for (int i = 0; i <= inputLine.Length; i++)
        //    {
        //        if (i == inputLine.Length || inputLine[i] == ' ')
        //        {
        //            if (number != "")
        //            {
        //                sum += Convert.ToInt32(number);
        //                number = "";
        //            }
        //        }
        //        else
        //        {
        //            number += inputLine[i];
        //        }
        //    }
        //    return sum;
        //}



        //Задание 3. Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца. 
        //На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn. 
        //Написать метод, принимающий на вход значение из этого перечисления и возвращающий название времени года (зима, весна, лето, осень). 
        //Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года. 
        //Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».

        //enum Season
        //{
        //    its_Winter_Time_Now = 1,
        //    its_Spring_Time_Now,
        //    its_Summer_Time_Now,
        //    its_Autumn_Time_Now,
        //}
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Введите порядковый номер месяца, чтобы узнать текущий сезон");
        //    int monthNumber = Convert.ToInt32(Console.ReadLine());
        //    SeasonSelect(monthNumber);
        //}

        //static void SeasonSelect(int monthNumber)
        //{
        //    string season;

        //    if (monthNumber == 12 || monthNumber == 1 || monthNumber == 2)
        //    {
        //        season = monthNumber.ToString();
        //        season = nameof(Season.its_Winter_Time_Now);
        //        Console.WriteLine(season);
        //    }
        //    else if (monthNumber == 3 || monthNumber == 4 || monthNumber == 5)
        //    {
        //        season = monthNumber.ToString();
        //        season = nameof(Season.its_Spring_Time_Now);
        //        Console.WriteLine(season);
        //    }
        //    else if (monthNumber == 6 || monthNumber == 7 || monthNumber == 8)
        //    {
        //        season = monthNumber.ToString();
        //        season = nameof(Season.its_Summer_Time_Now);
        //        Console.WriteLine(season);
        //    }
        //    else if (monthNumber == 9 || monthNumber == 10 || monthNumber == 11)
        //    {
        //        season = monthNumber.ToString();
        //        season = nameof(Season.its_Autumn_Time_Now);
        //        Console.WriteLine(season);
        //    }else
        //        Console.WriteLine("Ошибка: введите число от 1 до 12");
        //}

        // Задание 4. (*) Написать программу, вычисляющую число Фибоначчи для заданного значения рекурсивным способом.

        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число, чтобы увидеть магию Фибоначии...");
                int fiboNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fibonachi(fiboNumber));
        }

        static int Fibonachi(int fiboNumber)
        {
            if (fiboNumber == 0) 
                return 0;
            if (fiboNumber == 1) 
                return 1;
            return Fibonachi(fiboNumber - 2) + Fibonachi(fiboNumber - 1);
        }
















    }
}