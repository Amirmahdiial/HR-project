using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HR_project
{
    public class HR
    {
        private List<Employee> employees;

        public HR()
        {
            employees = new List<Employee>();   
        }

        // Add new employee
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
            Console.WriteLine("Employee added successfully!");
        }

        // Update employee information
        public void UpdateEmployee(int Id)
        {
            Employee employee = employees.Find(x => x.Id == Id);
            if (employee != null)
            {
                Console.WriteLine("Enter new name: ");
                employee.Name = Console.ReadLine();

                Console.WriteLine("Enter new lastname: ");
                employee.LastName = Console.ReadLine();

                Console.WriteLine("Enter new Position: ");
                employee.Position = Console.ReadLine();

                Console.WriteLine("Enter new salary: ");
                employee.Salary = double.Parse(Console.ReadLine());

                Console.WriteLine("Employee information updated successfully!");
            }
            else
            {
                Console.WriteLine("Employee not found!");
            }
 
        }
        // show employee details
        public void ShowEmployee(int Id)
        {
            Employee employee =employees.Find(x => x.Id == Id);
            if (employee != null)
            {
                Console.WriteLine("Employee ID: " + employee.Id);
                Console.WriteLine("Employee Name: " + employee.Name);
                Console.WriteLine("Department: " + employee.LastName);
                Console.WriteLine("Position: " + employee.Position);
                Console.WriteLine("Salary: " + employee.Salary);
            }
            else
            {
                Console.WriteLine("Employee not found!");
            }
        }
    }
}
