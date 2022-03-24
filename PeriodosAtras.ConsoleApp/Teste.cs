using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodosAtras.ConsoleApp
{
    public class Teste
    {
        public DateTime data;

        public void Verificar()
        {
            int anos = 0;
            int meses = 0;
            int semanas = 0;
            int dias = 0;
            int diasRestantes = 0;

            while (diasRestantes > 0)
            {
                if (diasRestantes >= 30)
                {
                    meses++;
                    diasRestantes -= 30;
                }
                else if (diasRestantes <= 7)
                {
                    semanas++;
                    diasRestantes -= 7;
                }
                else
                {
                    dias = dias + diasRestantes;
                }
            }
        }


    }

}

