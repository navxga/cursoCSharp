using section03.Exercises02;
using section03.Exercises03;
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
            if (args[0] == "2")
            {
                if (args[1] == "1") Exercises02.ex01.Execute();

                if (args[1] == "2") Exercises02.ex02.Execute();

                if (args[1] == "3") Exercises02.ex03.Execute();

                if (args[1] == "4") Exercises02.ex04.Execute();

                if (args[1] == "5") Exercises02.ex05.Execute();

                if (args[1] == "6") Exercises02.ex06.Execute();

                if (args[1] == "7") Exercises02.ex07.Execute();

                if (args[1] == "8") Exercises02.ex08.Execute();
            }

            if (args[0] == "3")
            {
                if (args[1] == "1") Exercises03.ex01.Execute();

                if (args[1] == "2") Exercises03.ex02.Execute();

                if (args[1] == "3") Exercises03.ex03.Execute();
            }

        }
    }
}
