using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listaex01
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public void Salario(double salario) 
        {
            Salary = salario;
        }

        public void increaseSalary(double percentage) 
        {
            Salary = percentage / 100 * Salary;
        }
    }
}
