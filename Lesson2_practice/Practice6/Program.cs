using System;

namespace Practice6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание номер 6 - создать расписание офиса через битовые маски

            Console.WriteLine("Совпадает ли утвержденный график работы отделов с фактической посещаемостью?");
            int workingScedule = 0b111111;

            int divisionOneScedule = 0b111100;
            int divisionTwoScedule = 0b001111;
            int divisionThreeScedule = 0b111111;
            int divisionFourScedule = 0b001100;

            int daysAtWork1 = divisionOneScedule | workingScedule;
            int daysAtWork2 = divisionTwoScedule | workingScedule;
            int daysAtWork3 = divisionThreeScedule | workingScedule;
            int daysAtWork4 = divisionFourScedule | workingScedule;



            Console.WriteLine(daysAtWork1 == divisionOneScedule);
            Console.WriteLine(daysAtWork2 == divisionTwoScedule);
            Console.WriteLine(daysAtWork3 == divisionThreeScedule);
            Console.WriteLine(daysAtWork4 == divisionFourScedule);

        }
    }
}
