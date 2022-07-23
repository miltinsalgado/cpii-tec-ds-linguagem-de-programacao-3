using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp7
{
    class JurosSimples : Juros
    {
        public JurosSimples(int tempo, double taxa, double capital) : base(tempo, taxa, capital)
        {

        }

        public override double CalcularJuros()
        {
            return GetCapital() * GetTaxa() * GetTempo();
        }

    }
}
