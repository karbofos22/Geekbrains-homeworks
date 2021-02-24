using System;

namespace Practice4
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание 4 - переменные с чека... если я правильно понял задание
            
            DateTime date = new DateTime(21, 11, 19);
            Console.WriteLine($"PH KKT: 09375     {date}");
            string nalog = "Сайт ФНС:      www.nalog.ru";
            Console.WriteLine(nalog);
            int itogo = 1500;
            Console.WriteLine($"Сумма ИТОГО:   {itogo}");

        }
    }
}
