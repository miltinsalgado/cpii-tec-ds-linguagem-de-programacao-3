using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp3
{
    class DinnerParty : Party
    {
        // Atributos
        public bool opcaoSaudavel = false;

        // Métodos
        public DinnerParty(bool c, bool s, int n)
           :base (c, n)
        {
            opcaoChique = c;
            opcaoSaudavel = s;
            SetNumeroDePessoas(n);
        }

        public decimal CalcularCustoBebida()
        {
            if (opcaoSaudavel)
                return 5.0M * GetNumeroDePessoas();
            else
                return 20.0M * GetNumeroDePessoas();
        }

        public decimal CalcularCustoTotal()
        {
            decimal custoTotal = CalcularCustoPessoa() + CalcularCustoDec() + CalcularCustoBebida();
            
            if (opcaoSaudavel)
                custoTotal *= 0.95M;

            return custoTotal;
        }
    }
}
