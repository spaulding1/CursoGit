using System;
using System.Collections.Generic;
using System.Text;

namespace Couse
{
    class ConversorDeMoeda
    {
        public static double IOF = 6.0 / 100.0;
        
        public static double Converte(double dolarCotado, double valorAComprar)
        {
            double valor = dolarCotado * valorAComprar;
            return valor + (valor * IOF);
        }
    }

}