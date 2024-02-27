namespace PersonalRegisterLexicon2024
{
    internal class Program
    {
        // Employee list.
        static List<Models.Employee> employees = new();

        static void Main(string[] args)
        {
            string input = "";
            while (input != "Exit")
            {
                Console.WriteLine("------------------");
                Console.WriteLine("Exit - Exit Program");
                Console.WriteLine("1 - Add Employee");
                Console.WriteLine("2 - List Employees");
                Console.WriteLine("------------------");
                input = Console.ReadLine();
                if (input == "1")
                {
                    AddEmployee();
                }
                else if (input == "2")
                {
                    ListEmployees();
                }
            }
        }
        public static void AddEmployee()
        {
            Models.Employee employee = new Models.Employee();

            employee.Id = Guid.NewGuid();

            string input;
            Console.Write("Enter Employee FirstName: ");
            input = Console.ReadLine();
            employee.FirstName = input;

            Console.Write("Enter Employee LastName: ");
            input = Console.ReadLine();
            employee.LastName = input;

            Console.Write("Enter Employee Salary: ");
            input = Console.ReadLine();
            if(int.TryParse(input, out int result))
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
        public static void ListEmployees()
        {
            Console.WriteLine();
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Salary} {employee.FirstName} {employee.LastName}");
            }
            Console.WriteLine();
        }
    }
}
