using System;
namespace SistemaHotel
{
    public class Suite
    {
        public int Numero { get; set; }
        public int ValorDiaria { get; set; }

        public Suite(int numero, int valorDiaria)
        {
            Numero = numero;
            ValorDiaria = valorDiaria;
        }
    }
}

