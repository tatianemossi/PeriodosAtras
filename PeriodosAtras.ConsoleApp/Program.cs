using System;

namespace PeriodosAtras.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            PeriodoAtras periodo = new PeriodoAtras();
            periodo.data = Convert.ToDateTime("23/03/2022");
            periodo.VerificarPeriodo();


            PeriodoAtras periodo2 = new PeriodoAtras();
            periodo2.data = Convert.ToDateTime("22/03/2022");
            periodo2.VerificarPeriodo();


            PeriodoAtras periodo3 = new PeriodoAtras();
            periodo3.data = Convert.ToDateTime("17/03/2022");
            periodo3.VerificarPeriodo();

            PeriodoAtras periodo4 = new PeriodoAtras();
            periodo4.data = Convert.ToDateTime("17/01/2022");
            periodo4.VerificarPeriodo();

            PeriodoAtras periodo5 = new PeriodoAtras();
            periodo5.data = Convert.ToDateTime("21/01/2022");
            periodo5.VerificarPeriodo();

            PeriodoAtras periodo6 = new PeriodoAtras();
            periodo6.data = Convert.ToDateTime("24/03/2011");
            periodo6.VerificarPeriodo();

            Console.ReadLine();
        }
    }
}
