using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section04
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args[0] == "1")
            {
                if (args[1] == "1") Exercises01.ex01.Execute();

                if (args[1] == "2") Exercises01.ex02.Execute();
            }
        }
    }
}