using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace section05.Listas
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary{ get; set; }

        public Employee (int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double porcentage)
        {
            Salary += (Salary * (porcentage / 100));
        }

        public override string ToString()
        {
            return 
                $"Id: {Id}\n" +
                $"Name: {Name}\n" +
                $"Salary: {Salary.ToString("F2", CultureInfo.InvariantCulture)}"; 
        }
    }
    public class Exercise01
    {
        public static void Execute()
        {
            Console.Write("How many employees will be registered? ");
            int c = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();
            for (int i = 1; i <= c; i++)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"Employee #{i}");
                Console.WriteLine();

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                employees.Add(new Employee(id, name, salary));
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());


            Employee emp = employees.Find(x => x.Id == searchId);

            if (emp != null)
            {
                Console.Write("Enter the porcentage: ");
                double porcentage = double.Parse(Console.ReadLine());

                emp.IncreaseSalary(porcentage);

            }else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");

            foreach (Employee obj in employees)
            {
                Console.WriteLine(obj + "\n");
            }
        }
    }
}
