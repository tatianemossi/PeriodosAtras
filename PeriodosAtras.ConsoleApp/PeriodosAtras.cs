using System;

namespace PeriodosAtras.ConsoleApp
{
    public class PeriodoAtras
    {
        public DateTime data;

        public TimeSpan VerificarPeriodo()
        {
            TimeSpan intervalo = DateTime.Now - this.data;
            int qtdDias;
            int qtdSemanas;
            int qtdMeses;
            int qtdAnos;

            qtdDias = intervalo.Days;
            qtdSemanas = intervalo.Days / 7;
            qtdMeses = intervalo.Days / 28;
            qtdAnos = intervalo.Days / 365;

            if (intervalo.Days == 1)
                Console.WriteLine($"{qtdDias} dia atrás");

            else if (intervalo.Days > 1 && intervalo.Days < 7)
                Console.WriteLine($"{qtdDias} dias atrás");

            else if (intervalo.Days <= 7 && intervalo.Days < 28)
            {
                if (intervalo.Days >= 7 && intervalo.Days < 14)
                {
                    if (intervalo.Days == 7)
                        Console.WriteLine($"{qtdSemanas} semanas atrás");

                    else
                        Console.WriteLine($"{qtdSemanas} semana(s) e {qtdDias / qtdSemanas} dia(s) atrás");
                }
            }
            else if (intervalo.Days == 28)
                Console.WriteLine($"{qtdMeses} um mês atrás");

            else if(intervalo.Days > 28)
                Console.WriteLine($"{qtdAnos} anos, {qtdMeses} meses, {qtdSemanas/qtdMeses} semana(s) e {qtdDias/qtdSemanas} dia(s) atrás");                       

            return intervalo;
        }
    }
}
