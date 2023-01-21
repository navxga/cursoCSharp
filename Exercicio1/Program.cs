using Exercicio1.Entities;
using Exercicio1.Entities.Enums;
using System;
using System.Globalization;

namespace Section09.Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();

            //Dados do trabalhador
            Console.WriteLine("Enter worker data:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior / MidLevel / Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("BaseSalary: ");
            double baseSalary = double.Parse(Console.ReadLine());

            //Instanciando objetos
            Department department = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, department);

            //Contratos
            Console.Write("How many contracts to this worker?: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                //Data
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());

                //Valor por hora
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Duração
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract hourContract = new HourContract(data, valuePerHour, hours); 
                worker.AddContract(hourContract);
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            //Execução
            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for {monthAndYear}: {worker.Income(month, year).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}