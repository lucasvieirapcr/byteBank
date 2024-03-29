﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_ADM.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(cpf, 2000)
        {
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.20;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.1;
        }
    }
}