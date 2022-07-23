using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp3
{
    class Party
    {
        // Constantes
        private const decimal PRECO_POR_PESSOA = 25.0M;

        // Atributos
        public bool opcaoChique = false;
        private int numeroDePessoas = 1;

        // Métodos
        public int GetNumeroDePessoas() { return numeroDePessoas; }
        public void SetNumeroDePessoas(int n) { if (n > 0) numeroDePessoas = n; }

        public Party (bool c, int n)
        {

        }
        public decimal CalcularCustoPessoa()
        {
            return PRECO_POR_PESSOA * numeroDePessoas;

        }
        public decimal CalcularCustoDec()
        {
            if (opcaoChique)
                return 15.0M * numeroDePessoas + 50.0M;
            else
                return 7.50M * numeroDePessoas + 30.0M;
        }
    }
}
