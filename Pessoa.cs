﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Couse
{
    class Pessoa
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += SalarioBruto * (porcentagem / 100);
        }

        public override string ToString()
        {
            return "Funcionário: "
                    + Nome
                    + ", $ "
                    + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
