using System;
using System.Diagnostics;
using System.Text;
using ClassLibrary1;  // созданная библиотека с приветствием


namespace Lesson8_practice
{
    class Program
    {
        static void Main(string[] args)
        {

            
            //1.Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы и позволяет завершить указанный процесс. 
            //    Предусмотреть возможность завершения процессов с помощью указания его ID или имени процесса. 
            //    В качестве примера можно использовать консольные утилиты Windows tasklist и taskkill.

            Process taskList = Process.Start("tasklist.exe");
            Console.WriteLine("Введите Id процесса который нужно закрыть\n");
            int id = Int32.Parse(Console.ReadLine());
            Process.GetProcessById(id).Kill();

            //SayHello.Greeting(); //Задание 2. Создать библиотеку с методом привествия, создать второе консольное приложение, которое выводит это приветствие.


        }
    }
}
