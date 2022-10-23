using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace section04.Exercises01.CasadeCambio
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double DolarToReal(double dol, double c)
        {
            double tot = dol * c;
            return tot + tot * Iof / 100;
        }
    }
}
