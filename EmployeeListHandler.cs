using PersonalRegisterLexicon2024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegisterLexicon2024
{
    public class EmployeeListHandler : IEmployee
    {
        public static List<Models.Employee> employees = new();
        public void ListEmployees()
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|", "Salary", "First Name", "Last Name");
            Console.WriteLine("|--------------------|--------------------|--------------------|");
            foreach (var employee in employees)
            {
                Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|", employee.Salary, employee.FirstName, employee.LastName);

            }
        }
        public void AddEmployee()
        {
            Models.Employee employee = new Models.Employee();

            employee.Id = Guid.NewGuid();

            string input;
            Console.Write("Enter Employee FirstName: ");
            input = Console.ReadLine();
            if (input.Length > 20)
            {
                Console.WriteLine("First Name is too long!");
                return;
            }
            employee.FirstName = input;

            Console.Write("Enter Employee LastName: ");
            input = Console.ReadLine();
            if (input.Length > 20)
            {
                Console.WriteLine("Last Name is too long!");
                return;
            }
            employee.LastName = input;

            Console.Write("Enter Employee Salary: ");
            input = Console.ReadLine();
            if (input.Length > 20)
            {
                Console.WriteLine("Salary is too high!");
                return;
            }
            if (int.TryParse(input, out int result))
            {
                employee.Salary = result;
            }
            else
            {
                Console.WriteLine("Invalid salary input!");
                return;
            }

            employees.Add(employee);
            return;
        }
    }

    public interface IEmployee
    {
        static List<Models.Employee> employees = new();
        public void AddEmployee();
        public void ListEmployees();
    }
}
