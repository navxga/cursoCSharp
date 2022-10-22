using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace section04.Exercises01
{
    internal class ex02
    {
        internal static void Execute()
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do 1º funcionário:");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();

            Console.Write("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine());


            Console.WriteLine("Dados do 2º funcionário:");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();

            Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine());


            double salarioMedio = (f1.Salario + f2.Salario) / 2.0;

            Console.WriteLine($"Salário médio: {salarioMedio.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
    internal class Funcionario
    {
        public string Nome;
        public double Salario;
    }
}
