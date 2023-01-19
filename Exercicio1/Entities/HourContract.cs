using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours{ get; set; } // O que é Integer?

        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}
