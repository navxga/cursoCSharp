using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.ComponentModel.DataAnnotations;

namespace section05
{
    class Aluno
    {
        public string Nome { get; set; }
        public string Email { get; set; } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão ocupados? ");
            int n = int.Parse(Console.ReadLine());

            Aluno[] quartos = new Aluno[10];
            for (int i = 0; i < n; i++)
            {
                Console.Write("\nNome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                quartos[quarto] = new Aluno { Nome = nome, Email = email};
            }

            Console.WriteLine("Quartos hospedados:");

            for (int i = 0; i < quartos.Length; i++)
            {
                if (quartos[i] != null)
                    Console.WriteLine($"{quartos[i].Nome}, {quartos[i].Email} ");
            }

            //if (args[0] == "1")
            //{
            //    if (args[1] == "1") Exercises01.ex01.Execute();
            //}
        }
    }
}