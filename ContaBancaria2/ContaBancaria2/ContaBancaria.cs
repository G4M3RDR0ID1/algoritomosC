using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria2
{
    internal class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }


        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this (numero, titular) 
        {
            Saldo = saldo;
        }

        public void Deposito(double quantia) 
        {
            Saldo += quantia;
        }

        public void Saque(double quantia) 
        {
            Saldo = Saldo - quantia - 5.0;
        }

        public override string ToString()
        { 
            return "Conta " + Numero + ", Titular: " + Titular + ", Saldo: $ " + Saldo.ToString("f2"); 
        }

    }
}
