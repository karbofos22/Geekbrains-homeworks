using System;

namespace Lesson2_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1,2,5 - среднесуточная температура, вывод месяца и сообщение

            Console.WriteLine("Введите минимальную температуру за сутки");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру за сутки");
            int max = Convert.ToInt32(Console.ReadLine());
            int middle = (min + max) / 2;
            Console.WriteLine($"Среднесуточная температура: {middle} градус(ов)\n");

            Console.WriteLine("Укажите номер текущего месяца");
            int month = Convert.ToInt32(Console.ReadLine());
            string monthnumber = "";
            switch (month)
            {
                case 1:
                    monthnumber = "Январь";
                    break;
                case 2:
                    monthnumber = "Февраль";
                    break;
                case 3:
                    monthnumber = "Март";
                    break;
                case 4:
                    monthnumber = "Апрель";
                    break;
                case 5:
                    monthnumber = "Май";
                    break;
                case 6:
                    monthnumber = "Июнь";
                    break;
                case 7:
                    monthnumber = "Июль";
                    break;
                case 8:
                    monthnumber = "Август";
                    break;
                case 9:
                    monthnumber = "Сентябрь";
                    break;
                case 10:
                    monthnumber = "Октябрь";
                    break;
                case 11:
                    monthnumber = "Ноябрь";
                    break;
                case 12:
                    monthnumber = "Декабрь";
                    break;
                default:
                    Console.WriteLine("Номер месяца указан не верно");
                    break;

            }
            Console.WriteLine(monthnumber);
            if (middle > 0 && month <= 12 && month >= 10 || month <= 2)
                Console.WriteLine("Дождливая зима");
        }
    }
}
