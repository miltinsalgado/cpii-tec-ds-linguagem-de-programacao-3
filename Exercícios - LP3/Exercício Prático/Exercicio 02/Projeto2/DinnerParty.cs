using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    class DinnerParty
    {
        private const decimal precoPorPessoa = 25;

        private decimal numeroDePessoas = 0;

        public bool opcaoSaudavel;
        public bool decoracaoChique;

        public decimal NumeroDePessoas
        {
            get
            {
                return numeroDePessoas;
            }
            set
            {
                if (value >= 0)
                    numeroDePessoas = value;
            }
        }

        public DinnerParty(decimal numPessoas, bool opSaudavel, bool decChique)
        {
            NumeroDePessoas = numPessoas;
            opcaoSaudavel = opSaudavel;
            decoracaoChique = decChique;
        }

        private decimal CalculaPrecoDeBebida()
        {
            decimal custoDeBebida = 0;

            if (opcaoSaudavel)
                custoDeBebida = numeroDePessoas * 5;
            else
                custoDeBebida = numeroDePessoas * 20;

            return custoDeBebida;
        }

        private decimal CalculaPrecoDeDecoracao()
        {
            decimal custoDaDecoracao = 0;

            if (decoracaoChique)
                custoDaDecoracao = numeroDePessoas * 15 + 50;
            else
                custoDaDecoracao = numeroDePessoas * 7.5M + 30;

            return custoDaDecoracao;
        }

        public decimal CalculaPrecoTotal()
        {
            decimal custoTotal = 0;

            custoTotal = CalculaPrecoDeBebida() + CalculaPrecoDeDecoracao();

            if (opcaoSaudavel)
                custoTotal *= 0.95M;

            return custoTotal;

        }
    }
}
