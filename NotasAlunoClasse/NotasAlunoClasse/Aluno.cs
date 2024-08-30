﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasAlunoClasse
{
    internal class Aluno
    {
        public string Nome;
        public double N1;
        public double N2;
        public double N3;

        public double NotaFinal() 
        {
            return N1 + N2 + N3;
        }

        public bool Aprovado() 
        {
            if (NotaFinal() >= 60) 
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.00;
            }
            else 
            {
                return 60 - NotaFinal();
            }
        }

    }
}
