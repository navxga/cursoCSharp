using EmployeeSystem.Entities;
using System;
using System.Globalization;
using System.Xml.Linq;

namespace Section10.EmployeeSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int qtdEmployees = int.Parse(Console.ReadLine());


            for (int i = 1; i <= qtdEmployees; i++)
            {
                Console.WriteLine($"Employee #{i} data:");

                Console.Write("Outsourced (Y/N) ? ");
                bool isOutsourced = Console.ReadLine().Trim().ToUpper() == "Y" ? true : false;

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("ValuePerHour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (isOutsourced)
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");

            foreach (Employee emp in employees)
                Console.WriteLine($"{emp.Name} - R${emp.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}