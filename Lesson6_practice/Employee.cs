using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6_practice
{
    public class Employee  //Создать класс "Сотрудник" с полями: ФИО, должность, email, телефон, зарплата, возраст;
    {
        /// <summary>
        /// Фамилия Имя Отчество сотрудника
        /// </summary>
        public string EmployeeFullName { get; }
        /// <summary>
        /// Должность сотрудника
        /// </summary>
        public string Position { get; set; }
        /// <summary>
        /// Email Сотрудника
        /// </summary>
        public string EmployeesEmail { get; set; }
        /// <summary>
        /// Контактный телефон сотрудника
        /// </summary>
        public string EmployeesMobile { get; set; }
        /// <summary>
        /// Зарплата сотрудника
        /// </summary>
        public decimal EmployeesSalary { get; set; }
        /// <summary>
        /// Возраст сотрудника
        /// </summary>
        public int EmployeesAge { get; }

        /// <summary>
        /// Создаем нового сотрудника с заданными параметрами
        /// </summary>
        /// <param name="EmployeeFullName">Фамилия Имя Отчество сотрудника</param>
        /// <param name="Position">Должность сотрудника</param>
        /// /// <param name="EmployeesEmail">Email Сотрудника</param>
        /// <param name="EmployeesMobile">Контактный телефон сотрудника</param>
        /// /// <param name="EmployeesSalary">Зарплата сотрудника</param>
        /// <param name="EmployeesAge">Возраст сотрудника</param>

        public Employee(string employeeFullName, string position, string employeesEmail, string employeesMobile, decimal employeesSalary, int employeesAge)
        {
            EmployeeFullName = employeeFullName;
            Position = position;
            EmployeesEmail = employeesEmail;
            EmployeesMobile = employeesMobile;
            EmployeesSalary = employeesSalary;
            EmployeesAge = employeesAge;
        }

        public string EmployeeInfo()
        {
            return $"ФИО: {EmployeeFullName}, Возраст: {EmployeesAge}, Должность: {Position}, ЗП: {EmployeesSalary}\nКонтактный телефон:" +
                $" {EmployeesMobile}, Почта: {EmployeesEmail}";
        }


    }
}
