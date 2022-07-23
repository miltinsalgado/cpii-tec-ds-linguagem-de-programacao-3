using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp7
{
    abstract class Juros
    {
        private int tempo;
        private double taxa;
        private double capital;

        public Juros(int tempo)
        {
            SetTempo(tempo);
            taxa = 0.5;
            capital = 2000;
        }

        public Juros(int tempo, double taxa, double capital)
        {
            SetCapital(capital);
            SetTaxa(taxa);
            SetTempo(tempo);
        }

        public abstract double CalcularJuros();

        public void SetTaxa(double taxa)
        {
            if (taxa >= 0 && taxa <= 1)
                this.taxa = taxa;
        }
        public void SetCapital(double capital)
        {
            if (capital >= 0)
                this.capital = capital;
        }

        public void SetTempo(int tempo)
        {
            if (tempo >= 0)
                this.tempo = tempo;
        }

        public int GetTempo() { return this.tempo; }
        public double GetCapital() { return this.capital; }
        public double GetTaxa() { return this.taxa; }
    }
}
