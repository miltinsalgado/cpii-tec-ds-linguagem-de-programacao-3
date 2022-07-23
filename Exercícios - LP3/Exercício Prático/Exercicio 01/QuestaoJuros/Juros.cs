using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestaoJuros
{
    abstract class Juros
    {
        protected decimal Capital = 0, taxa = 0, tempo = 0;

        public void SetCapital(decimal C)
        {
            if (C > 0)
                Capital = C;
        }
        
        public decimal GetCapital()
        {
            return Capital;
        }

        public void SetTaxa(decimal i)
        {
            if (i >= 0 && i <= 100)
                taxa = i * 0.01M;
        }

        public decimal GetTaxa()
        {
            return taxa;
        }

        public void SetTempo(decimal t)
        {
            if (t > 0)
                tempo = t;
        }

        public decimal GetTempo()
        {
            return tempo;
        }

        public Juros(decimal C, decimal i, decimal t)
        {
            SetCapital(C);
            SetTaxa(i);
            SetTempo(t);        }

        public abstract decimal CalcularJuros();
    }
}
