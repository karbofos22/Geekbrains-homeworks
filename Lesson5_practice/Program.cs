using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;



namespace Lesson5_practice
{
    class Program
    {
        static void Main(string[] args)
        {
                // Задание 1. Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.

            //string receipt = "Borsch.txt";
            //    File.AppendAllText(receipt, Console.ReadLine());
            //    File.AppendAllText(receipt, Environment.NewLine);


                // Задание 2. Написать программу, которая при старте дописывает текущее время в файл «startup.txt».

            //string fileName = "startup.txt";
            //  File.AppendAllText(fileName, DateTime.Now.ToLongTimeString());
            //  File.AppendAllText(fileName, Environment.NewLine);

                // Задание 3. Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.


            string nums = "anyNumbers.txt";
                File.AppendAllText(nums, Console.ReadLine());
            BinaryFormatter formatThisFile = new BinaryFormatter();
            formatThisFile.Serialize(new FileStream("anyNumbers.bin", FileMode.OpenOrCreate), nums);
 
        }
    }
}
