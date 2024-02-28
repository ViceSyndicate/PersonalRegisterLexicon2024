namespace PersonalRegisterLexicon2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeListHandler employeeListHandler = new EmployeeListHandler();
            string input = "";
            while (input != "EXIT")
            {
                Console.WriteLine("------------------");
                Console.WriteLine("Exit - Exit Program");
                Console.WriteLine("1 - Add Employee");
                Console.WriteLine("2 - List Employees");
                Console.WriteLine("------------------");
                input = Console.ReadLine();
                if (input == "1")
                {

                    employeeListHandler.AddEmployee();
                    
                }
                else if (input == "2")
                {
                    employeeListHandler.ListEmployees();
                }
                // case sensitive check.
                input = input.ToUpper();
            }
        }
    }
}
