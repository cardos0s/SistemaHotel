using System;
namespace SistemaHotel
{
        public class Rserva
        {
            public Hospede Hospede { get; set; }
            public Suite Suite { get; set; }
            public DateTime DataInicio { get; set; }
            public DateTime DataFim { get; set; }

            public Rserva(Hospede hospede, Suite suite, DateTime dataInicio, DateTime dataFim)
            {
                Hospede = hospede;
                Suite = suite;
                DataInicio = dataInicio;
                DataFim = dataFim;
            }

            public int CalcularQuantidadeDias()
            {
                return (int)(DataFim - DataInicio).TotalDays;
            }

            public decimal CalcularValorTotal()
            {
                int quantidadeDias = CalcularQuantidadeDias();
                decimal valorTotal = quantidadeDias * Suite.ValorDiaria;

                if (quantidadeDias > 10)
                {
                    valorTotal *= 0.9m; // Aplicando desconto de 10% para reservas maiores que 10 dias
                }

                return valorTotal;
            }
        }

}
