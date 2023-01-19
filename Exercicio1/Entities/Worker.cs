using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio1.Entities.Enums;

namespace Exercicio1.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level{ get; set; }
        public double baseSalary { get; set; }
    }
}
