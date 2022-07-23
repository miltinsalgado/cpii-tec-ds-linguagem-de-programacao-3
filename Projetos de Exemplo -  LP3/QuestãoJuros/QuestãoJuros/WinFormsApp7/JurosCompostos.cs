using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp7
{
    class JurosCompostos : Juros
    {
        public JurosCompostos(int tempo, double taxa, double capital) : base(tempo, taxa, capital)
        {

        }

        public override double CalcularJuros()
        {
            return GetCapital() * Math.Pow(1+GetTaxa(), GetTempo()) - GetCapital();
        }
    }
}
