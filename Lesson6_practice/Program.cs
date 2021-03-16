using System;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Lesson6_practice
{
    class Program
    {

        static void Main(string[] args)
        {

            //Dirtree();        // Задание 1.Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.
            //TodoListMaker();  // Задание 2. Список задач (ToDo-list)
            //MyArray();        // Задание 3. Напишите метод, на вход которого подаётся двумерный строковый массив размером 4х4
              EmployeesForm();  // Задание 4. Создать класс "Сотрудник" с полями: ФИО, должность, email, телефон, зарплата, возраст;
                                //            онструктор класса должен заполнять эти поля при создании объекта;
                                //            Внутри класса «Сотрудник» написать метод, который выводит информацию об объекте в консоль;
                                //            Создать массив из 5 сотрудников
                                //            С помощью цикла вывести информацию только о сотрудниках старше 40 лет;



            static void Dirtree()
            {
                string homeworkDir = @"D:\Projects\HomeworkDir\";
                string[] entries = Directory.GetFileSystemEntries(homeworkDir, "*", SearchOption.AllDirectories);

                foreach (string i in entries)
                {
                    string fileTree = "fileTree.txt";
                    File.AppendAllText(fileTree, Environment.NewLine);
                    File.AppendAllText(fileTree, i);
                }
            }

            static void TodoListMaker()
            {
                ToDo newTask = new ToDo();
                string tasks = "tasks.txt";
                File.Exists(tasks);
                if (File.Exists(tasks) == false)
                {
                    File.WriteAllText(tasks, "Список задач:");
                    File.AppendAllText(tasks, Environment.NewLine);

                }
                //else      // Почему-то не десереализуется... выдает ошибку System.Text.Json.JsonException: The JSON value could not be converted... непонятно. 
                //  в гугле точного объяснения не нашел
                //{
                //    string taskListJson = File.ReadAllText("tasks.json");
                //    ToDo taskList = JsonSerializer.Deserialize<ToDo>(taskListJson);
                //    File.ReadAllText(taskListJson);
                //    Console.WriteLine(taskListJson);
                //}


                Console.WriteLine("Если Вы хотите добавить новую задачу - нажмите 1 и enter\nЕсли хотите закрыть существующую - нажмите 2 и enter");
                int choise = Convert.ToInt32(Console.ReadLine());
                int secondChoise;
                int switcher = 1;

                while (choise == 1)
                {
                    do
                    {
                        Console.Write($"Опишите задачу:\n");
                        newTask.Title = Console.ReadLine();
                        File.AppendAllLines(tasks, new[] { $"Задача {switcher++} : " + newTask.Title });
                        Console.WriteLine();
                        Console.WriteLine("Хотите добавить еще одну? нажмите 1 и enter\n" +
                            "Если хотите закрыть существующую - нажмите 2 и enter\n");
                        secondChoise = Convert.ToInt32(Console.ReadLine());

                    } while (secondChoise != 2);
                    if (secondChoise == 2)
                        break;
                }
                string[] taskLines = File.ReadAllLines(tasks);
                for (int count = 0; count < taskLines.Length; count++)
                {
                    Console.WriteLine(taskLines[count]);
                }
                Console.WriteLine("Введите номер задачи");
                string selectedTask = Console.ReadLine();

                int index = Array.FindIndex(taskLines, element => element.Contains(selectedTask));
                Console.WriteLine($"{taskLines[index].Insert(0, "[x] ")}");
                string json = JsonSerializer.Serialize(taskLines);
                File.WriteAllText("tasks.json", json);
            }


            static void MyArray()
            {
                try
                {
                    InputArray();
                }
                catch (ExceptionByLength e)
                {
                    Console.WriteLine($"Неверная длина массива:\n{e.StackTrace}");
                }
                catch (ExceptionByWrongElement e)
                {
                    Console.WriteLine($"Элемент массива не является числом:\n{e.StackTrace}");
                }
            }
            static void InputArray()
            {
                Console.WriteLine("Введите любые символы");
                string[,] inputArray = new string[4, 4];
                if (inputArray.Length != 16)
                {
                    throw new ExceptionByLength();
                }
                for (int i = 0; i < inputArray.GetLength(0); i++)
                {
                    for (int j = 0; j < inputArray.GetLength(1); j++)
                    {
                        inputArray[i, j] = Console.ReadLine();
                    }
                }
                int sum = 0;
                for (int i = 0; i < inputArray.Length; i++)
                {
                    for (int j = 0; j < inputArray.Length; j++)
                    {
                        try
                        {
                            sum = sum + Int32.Parse(inputArray[i, j]);
                        }
                        catch
                        {
                            throw new ExceptionByWrongElement();

                        }
                        Console.WriteLine($"Сумма чисел: {sum}");

                    }
                }

            }

            



            static void EmployeesForm()
            {
                Employee[] employeeList = new Employee[5];
                employeeList[0] = new Employee("Tsvetkov Andrey", "Chief Architect", "tsvetkovandrey@stroimdoma.com", "89323328776", 90000, 55);
                employeeList[1] = new Employee("Rublev Ilya", "User Support employee", "RublikFirst@mail.com", "82313332123", 36000, 19);
                employeeList[2] = new Employee("Petrova Valentina", "Designer", "supercolors@mail.ru", "9876576", 55000, 22);
                employeeList[3] = new Employee("Popova Anna", "Lawyer", "GoToJailNow@yandex.ru", "89999999191", 89000, 31);
                employeeList[4] = new Employee("Volinsky Lev", "Ceo", "GreatLikeCaesar@gmail.com", "89111232323", 200000, 42);

                Console.WriteLine(employeeList[2].EmployeeInfo());
                Console.WriteLine("----------------------------");

                for (int i = 0; i < employeeList.Length; i++)
                {
                    if (employeeList[i].EmployeesAge >= 40)
                        Console.WriteLine(employeeList[i].EmployeeInfo());
                }

            }










        }
    }
}

