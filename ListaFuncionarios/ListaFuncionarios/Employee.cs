﻿using System;
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

        public Employee(int id, string name, double salary) 
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public void Salario(double salario)
        {
            Salary = salario;
        }

        public void increaseSalary(double percentage)
        {
            Salary += percentage / 100 * Salary;
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary.ToString("F2");
        }
    }
}