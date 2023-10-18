using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace OOPGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a stack for our employees
            Stack<Employee> employees = new Stack<Employee>();

            // Piling on objects to the stack using 'Push'
            employees.Push(new Employee { Name = "Amanda", Id = 1, Salary = 680000, Gender = "Female" });
            employees.Push(new Employee { Name = "Lars-UlrikUlrik", Id = 2, Salary = 38000, Gender = "Male" });
            employees.Push(new Employee { Name = "Liselott-Lise", Id = 3, Salary = 25000, Gender = "Female" });
            employees.Push(new Employee { Name = "Karin-Helena", Id = 4, Salary = 45000, Gender = "Female" });
            employees.Push(new Employee { Name = "Ulf-Göran", Id = 5, Salary = 78000, Gender = "Male" });

            Console.OutputEncoding = Encoding.UTF8;

            // Iterating through every employee using a foreach-loop
            Console.WriteLine("Iterating through every employee in the stack");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.ToString());
                Console.WriteLine($"Employees left in the stack: {employees.Count()}");
            }
            Console.WriteLine("👾👾👾👾👾👾👾👾👾👾👾👾👾👾👾👾👾👾👾👾👾👾👾👾👾👾");
            Console.WriteLine();

            // Removing all objects from the stack using 'Pop'
            Console.WriteLine("Removing objects using Pop method");
            while (employees.Count > 0)
            {
                foreach (Employee employee in employees)
                {
                    employees.Pop();
                    Console.WriteLine(employee.ToString());
                    Console.WriteLine($"Employees left in the stack: {employees.Count()}");
                    break;
                }
            }

            // Retrieving all objects back using 'Push'
            Console.WriteLine();
            employees.Push(new Employee { Name = "Amanda", Id = 1, Salary = 680000, Gender = "Female" });
            employees.Push(new Employee { Name = "Lars-UlrikUlrik", Id = 2, Salary = 38000, Gender = "Male" });
            employees.Push(new Employee { Name = "Liselott-Lise", Id = 3, Salary = 25000, Gender = "Female" });
            employees.Push(new Employee { Name = "Karin-Helena", Id = 4, Salary = 45000, Gender = "Female" });
            employees.Push(new Employee { Name = "Ulf-Göran", Id = 5, Salary = 78000, Gender = "Male" });
            Console.WriteLine("👾👾👾👾👾👾👾👾👾👾👾👾👾👾👾👾👾👾👾👾👾👾👾👾👾👾");
            Console.WriteLine();

            // Peeking at the two objects at the top of the stack without deleting them
            Console.WriteLine("Retrieve using Peek method");
            Employee top1 = employees.Peek();
            Employee top2 = employees.Peek();

            foreach (Employee employee in employees)
            {
                Console.WriteLine(top1.ToString());
                Console.WriteLine($"Employees left in the stack: {employees.Count()}");
                break;
            }

            foreach (Employee employee in employees)
            {
                Console.WriteLine(top2.ToString());
                Console.WriteLine($"Employes left in the stack: {employees.Count()}");
                break;
            }
            Console.WriteLine("👾👾👾👾👾👾👾👾👾👾👾👾👾👾👾👾👾👾👾👾👾👾👾👾👾👾");
            Console.WriteLine();

            // Creating an instance of employee3
            Employee employee3 = employees.FirstOrDefault(employee => employee.Id == 3);

            // Checking if employee 3 is left in stack using if-statement
            if (employee3 != null)
            {
                Console.WriteLine("*Employee 3 is left in stack");
            }

            else
            {
                Console.WriteLine("*Employee 3 is not left in stack");
            }

            // Creating list of employees and adding each one of them
            List<Employee> listEmployee = new List<Employee>();

            listEmployee.Add(new Employee { Name = "Amanda", Id = 1, Salary = 680000, Gender = "Female" });
            listEmployee.Add(new Employee { Name = "Lars-UlrikUlrik", Id = 2, Salary = 38000, Gender = "Male" });
            listEmployee.Add(new Employee { Name = "Liselott-Lise", Id = 3, Salary = 25000, Gender = "Female" });
            listEmployee.Add(new Employee { Name = "Karin-Helena", Id = 4, Salary = 45000, Gender = "Female" });
            listEmployee.Add(new Employee { Name = "Ulf-Göran", Id = 5, Salary = 78000, Gender = "Male" });

            // Creating an instance of employee2
            Employee employee2 = listEmployee.FirstOrDefault(employee => employee.Id == 2);
            Console.WriteLine();

            // Checking if employee2 exists in the list
            if (listEmployee.Contains(employee2))
            {
                Console.WriteLine("*Employee 2 does exist in the list");
            }

            else
            {
                Console.WriteLine("*Employee 2 doesn't exist in the list");
            }

            // Printing out first male in the stack
            Employee employeeMale = listEmployee.Find(employee => employee.Gender == "Male");
            Console.WriteLine();
            Console.WriteLine($"*First male in the stack is: {employeeMale.Name}");

            // Printing out all males in the stack
            Console.WriteLine();
            Console.WriteLine("*Males in the stack are: ");
            List<Employee> employeeMaleAll = listEmployee.FindAll(employee => employee.Gender == "Male");
            foreach (Employee employee in employeeMaleAll)
            {
                Console.WriteLine($"{employee.Name}");
            }
        }
    }
}

