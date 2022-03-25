using System;

namespace PeriodosAtras.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            GerenciadorPeriodo gerenciadorPeriodo = new GerenciadorPeriodo();
            var periodoDias = gerenciadorPeriodo.BuscarPeriodo(Convert.ToDateTime("23/03/2022"));
            gerenciadorPeriodo.ApresentarPeriodo(periodoDias);

            GerenciadorPeriodo gerenciadorPeriodo2 = new GerenciadorPeriodo();
            periodoDias = gerenciadorPeriodo2.BuscarPeriodo(Convert.ToDateTime("22/03/2022"));
            gerenciadorPeriodo2.ApresentarPeriodo(periodoDias);

            GerenciadorPeriodo gerenciadorPeriodo3 = new GerenciadorPeriodo();
            periodoDias = gerenciadorPeriodo3.BuscarPeriodo(Convert.ToDateTime("17/03/2022"));
            gerenciadorPeriodo3.ApresentarPeriodo(periodoDias);

            GerenciadorPeriodo gerenciadorPeriodo4 = new GerenciadorPeriodo();
            periodoDias = gerenciadorPeriodo4.BuscarPeriodo(Convert.ToDateTime("17/01/2022"));
            gerenciadorPeriodo4.ApresentarPeriodo(periodoDias);

            GerenciadorPeriodo gerenciadorPeriodo5 = new GerenciadorPeriodo();
            periodoDias = gerenciadorPeriodo5.BuscarPeriodo(Convert.ToDateTime("21/01/2022"));
            gerenciadorPeriodo5.ApresentarPeriodo(periodoDias);

            GerenciadorPeriodo gerenciadorPeriodo6 = new GerenciadorPeriodo();
            periodoDias = gerenciadorPeriodo6.BuscarPeriodo(Convert.ToDateTime("24/03/2012"));
            gerenciadorPeriodo6.ApresentarPeriodo(periodoDias);

            GerenciadorPeriodo gerenciadorPeriodo7 = new GerenciadorPeriodo();
            periodoDias = gerenciadorPeriodo7.BuscarPeriodo(Convert.ToDateTime("25/03/2022 10:10:10"));
            gerenciadorPeriodo7.ApresentarPeriodo(periodoDias);

            Console.ReadLine();
        }
    }
}
