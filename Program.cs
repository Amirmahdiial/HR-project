// See https://aka.ms/new-console-template for more information

using HR_project;

HR hrSystem = new();
try
{
    while (true)
    {
        Console.WriteLine("1. Add Employee");
        Console.WriteLine("2. Update Employee Information");
        Console.WriteLine("3. Show Employee Details");
        Console.WriteLine("4. Exit");
        Console.WriteLine("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter Employee Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Employee Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter lastName: ");
                string lastName = Console.ReadLine();

                Console.WriteLine("Enter position: ");
                string position = Console.ReadLine();

                Console.WriteLine("Enter Salary: ");
                double salary = double.Parse(Console.ReadLine());

                Employee newEmployee = new Employee
                {
                    Id = id,
                    Name = name,
                    LastName = lastName,
                    Position = position,
                    Salary = salary
                };
                hrSystem.AddEmployee(newEmployee);
                break;

            case 2:
                Console.WriteLine("Enter Employee Id to update information: ");
                int updateId = int.Parse(Console.ReadLine());
                hrSystem.UpdateEmployee(updateId);
                break;

            case 3:
                Console.WriteLine("Enter Employee Id to show details: ");
                int showId = int.Parse(Console.ReadLine());
                hrSystem.ShowEmployee(showId);
                break;

            case 4:
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("Invalid choice!");
                break;
        }


    }
}
catch (Exception)
{
    Console.WriteLine();
    throw;
}

    

