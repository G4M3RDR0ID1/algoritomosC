using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01MembrosEstaticos
{
    internal class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double CalculoDeDolares(double cotacao, double quantia) 
        {
            double total = cotacao * quantia;
            return total + total * Iof / 100.00;
        }
    }
}
