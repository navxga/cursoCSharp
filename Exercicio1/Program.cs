using Exercicio1.Entities;
using Exercicio1.Entities.Enums;
using System;

namespace Section09.OrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");

            Department department = new Department()
            {
                Name = Console.ReadLine()
            };

            //Dados do trabalhador
            Console.WriteLine("Enter worker data:");

            Worker worker = new Worker();

            Console.Write("Name: ");
            worker.Name = Console.ReadLine();

            Console.Write("Level (Junior / MidLevel / Senior): ");
            worker.Level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("BaseSalary: ");
            worker.baseSalary = double.Parse(Console.ReadLine());

            //Contratos
            Console.Write("How many contracts to this worker?: ");
            int c = int.Parse(Console.ReadLine());

            List<HourContract> listHourContract = new List<HourContract>();
            for (int i = 0; i < c; i++)
            {
                HourContract hourContract = new HourContract(); 
                //Data
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                hourContract.Date = DateTime.Parse(Console.ReadLine());

                //Valor por hora
                Console.Write("Value per hour: ");
                hourContract.ValuePerHour = double.Parse(Console.ReadLine());

                //Duração
                Console.Write("Duration (hours): ");
                hourContract.Hours = int.Parse(Console.ReadLine());

                listHourContract.Add(hourContract);
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string periodo = Console.ReadLine();

            double salary = 0;
            foreach (var l in listHourContract)
            {
                if (l.Date.ToString("MM/yyyy") == periodo)   
                    salary += l.TotalValue();
            }

            //Execução
            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {department.Name}");
            Console.WriteLine($"Income for {periodo}: {salary + worker.baseSalary}");
        }
    }
}