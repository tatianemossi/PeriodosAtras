using System;

namespace PeriodosAtras.ConsoleApp
{
    public class GerenciadorPeriodo
    {
        public Periodo BuscarPeriodo(DateTime data)
        {
            int anos = 0;
            int meses = 0;
            int semanas = 0;
            int dias = 0;
            TimeSpan intervalo = DateTime.Now - data;
            int diasRestantes = intervalo.Days;

            while (diasRestantes > 0)
            {
                if (diasRestantes >= 365)
                {
                    anos++;
                    diasRestantes -= 365;
                }
                else if (diasRestantes >= 30)
                {
                    meses++;
                    diasRestantes -= 30;
                }
                else if (diasRestantes >= 7)
                {
                    semanas++;
                    diasRestantes -= 7;
                }
                else
                {
                    dias = diasRestantes;
                    diasRestantes = 0;
                }
            }

            return new Periodo
            {
                anos = anos,
                meses = meses,
                semanas = semanas,
                dias = dias,
                horas = intervalo.Hours,
                minutos = intervalo.Minutes,
                segundos = intervalo.Seconds
            };
        }

        public void ApresentarPeriodo(Periodo periodo)
        {
            string mensagem = "";

            if (periodo.anos == 0 && periodo.meses == 0 && periodo.semanas == 0 && periodo.dias == 0)
            {
                mensagem = $"{periodo.horas} hora(s), " +
                    $"{periodo.minutos} minuto(s) e " +
                    $"{periodo.segundos} segundo(s) atrás";
            }
            else
            {
                mensagem = MontarMensagemAno(periodo.anos, mensagem);
                mensagem = MontarMensagemMes(periodo.meses, mensagem);
                mensagem = MontarMensagemSemana(periodo.semanas, mensagem);
                mensagem = MontarMensagemDia(periodo.dias, mensagem);
            }

            Console.WriteLine($"{mensagem} atrás");
        }

        private string MontarMensagemAno(int ano, string mensagem)
        {
            if (ano > 0)
            {
                if (ano == 1)
                    mensagem = $"Um ano";
                else
                {
                    var anosEmOrdinal = ConverterParaOrdinal(ano);
                    mensagem = $"{anosEmOrdinal} anos";
                }
            }

            return mensagem;
        }

        private string MontarMensagemMes(int mes, string mensagem)
        {
            if (mes > 0)
            {
                if (mes == 1)
                {
                    if (mensagem.Length > 0)
                        mensagem = $"{mensagem} e Um mês";
                    else
                        mensagem = "Um mês";
                }
                else
                {
                    var mesesEmOrdinal = ConverterParaOrdinal(mes);
                    if (mensagem.Length > 0)
                        mensagem = $"{mensagem} e {mesesEmOrdinal} meses";
                    else
                        mensagem = $"{mesesEmOrdinal} meses";
                }
            }

            return mensagem;
        }

        private string MontarMensagemSemana(int semana, string mensagem)
        {
            if (semana > 0)
            {
                if (semana == 1)
                {
                    if (mensagem.Length > 0)
                        mensagem = $"{mensagem} e Uma semama";
                    else
                        mensagem = "Uma semana";
                }
                else
                {
                    string semanasEmOrdinal;
                    if (semana == 2)
                        semanasEmOrdinal = "Duas";
                    else
                        semanasEmOrdinal = ConverterParaOrdinal(semana);

                    if (mensagem.Length > 0)
                        mensagem = $"{mensagem} e {semanasEmOrdinal} semanas";
                    else
                        mensagem = $"{semanasEmOrdinal} semanas";
                }
            }

            return mensagem;
        }

        private string MontarMensagemDia(int dia, string mensagem)
        {
            if (dia > 0)
            {
                if (dia == 1)
                {
                    if (mensagem.Length > 0)
                        mensagem = $"{mensagem} e Um dia";
                    else
                        mensagem = "Um dia";
                }
                else
                {
                    var diasEmOrdinal = ConverterParaOrdinal(dia);
                    if (mensagem.Length > 0)
                        mensagem = $"{mensagem} e {diasEmOrdinal} dias";
                    else
                        mensagem = $"{diasEmOrdinal} dias";
                }
            }

            return mensagem;
        }

        public string ConverterParaOrdinal(int inteiro)
        {
            switch (inteiro)
            {
                case 2:
                    return "Dois";

                case 3:
                    return "Três";

                case 4:
                    return "Quatro";

                case 5:
                    return "Cinco";

                case 6:
                    return "Seis";

                case 7:
                    return "Sete";

                case 8:
                    return "Oito";

                case 9:
                    return "Nove";

                case 10:
                    return "Dez";

                default:
                    return "";
            }
        }
    }
}