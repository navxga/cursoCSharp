using section03.Exercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Contains("1"))
                ex01.Execute();

            if (args.Contains("2"))
                ex02.Execute();

            if (args.Contains("3"))
                ex03.Execute();

            if (args.Contains("4"))
                ex04.Execute();

            if (args.Contains("5"))
                ex05.Execute();
        }
    }
}
