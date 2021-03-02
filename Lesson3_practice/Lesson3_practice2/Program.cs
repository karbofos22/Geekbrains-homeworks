using System;

namespace Lesson3_practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 2 - Написать программу «Телефонный справочник»: создать двумерный массив 5х2, 
            // хранящий список телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона/email.

            string[,] phonebook = new string[5, 2];
            phonebook[0, 0] = "Алексей";
            phonebook[0, 1] = "442-13-11 / alexey@gorsvet.com";
            phonebook[1, 0] = "Жанна";
            phonebook[1, 1] = "402-53-00  /gianna-best@company.com";
            phonebook[2, 0] = "Сергей";
            phonebook[2, 1] = "312-79-52 / sergey22@gmail.com";
            phonebook[3, 0] = "Валентин";
            phonebook[3, 1] = "112-05-06 / valentine@company.com";
            phonebook[4, 0] = "Инга";
            phonebook[4, 1] = "860-35-16 / inga@yandex.ru";

            foreach (string i in phonebook)
            Console.WriteLine(i);


        }
    }
}
