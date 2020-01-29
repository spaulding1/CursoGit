using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Couse
{
    class Aluno
    {
        public string Nome;
        public double Trimestre1, Trimestre2, Trimestre3;

        public double CalculaNotaFinal()
        {
            return Trimestre1 + Trimestre2 + Trimestre3;
        }

        public double CalculaFalta()
        {
            return 60 - CalculaNotaFinal();
        }

        public string TesteAprova()
        {
            if (CalculaNotaFinal() >= 60.0)
            {
                return "APROVADO";
            }
            else
            {
                Console.WriteLine("REPROVADO");
                return "FALTARAM "+CalculaFalta().ToString("F2",CultureInfo.InvariantCulture)+" PONTOS";
            }

        }
    }
}
