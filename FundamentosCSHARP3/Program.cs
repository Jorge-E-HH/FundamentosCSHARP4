using FundamentosCSHARP.Models;
using FundamentosCSHARP3.Models;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;


namespace FundamentosCSHARP3
{
    class Program
    {
        static void Main(string[] args)
        {
            var bebidaAlcoholica = new Cerveza(100);
            MostrarRecomendacion(bebidaAlcoholica);
        }

        static void MostrarRecomendacion(IBebidaAlcoholica bebida)
        {
            bebida.MaxRecomendado();
        }
    }
}