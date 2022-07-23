using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    class BirthdayParty
    {
        private const decimal precoPorPessoa = 25;

        private decimal numeroDePessoas = 0;

        private bool boloGrande;
        public bool decoracaoChique;
        public string escrita;

        public decimal NumeroDePessoas
        {
            get
            {
                return numeroDePessoas;
            }
            set
            {
                if (value >= 0)
                {
                    numeroDePessoas = value;

                    if (numeroDePessoas >= 4)
                        boloGrande = true;
                    else
                        boloGrande = false;
                }
            }
        }

        public BirthdayParty(decimal numPessoas, bool decChique, string esc)
        {
            NumeroDePessoas = numPessoas;
            decoracaoChique = decChique;
            escrita = esc;
        }

        private decimal CalculaPrecoDaEscrita()
        {
            return escrita.Length * 0.25M;

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

            custoTotal = CalculaPrecoDaEscrita() + CalculaPrecoDeDecoracao();

            if (boloGrande)
                custoTotal += 75;
            else
                custoTotal += 40;

            return custoTotal;

        }
    }
}
