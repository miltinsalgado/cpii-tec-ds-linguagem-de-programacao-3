using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp3
{
    class BirthdayParty : Party
    {

        // Atributos
        public bool boloGrande = false;
        public string escritaBolo = "";

        // Métodos
        public BirthdayParty(bool c, string e, int n)
            :base (c, n)
        {
            opcaoChique = c;
            escritaBolo = e;
            SetNumeroDePessoas(n);

            if (GetNumeroDePessoas() > 4)
                boloGrande = true;
            else
                boloGrande = false;
        }

        public decimal CalcularCustoBolo()
        {
            if (boloGrande)
                return (escritaBolo.Replace(" ", "").Length) * 0.25M + 75;
            else
                return (escritaBolo.Replace(" ", "").Length * 0.25M) + 40;
        }

        public decimal CalcularCustoTotal()
        {
            decimal custoTotal = CalcularCustoPessoa() + CalcularCustoDec() + CalcularCustoBolo();
            return custoTotal;
        }
    }
}
