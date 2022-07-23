using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestaoJuros
{
    class JurosCompostos : Juros
    {
        public JurosCompostos(decimal C, decimal i, decimal t)
            :base(C, i, t)
        {
            
        }

        public override decimal CalcularJuros()
        {
            decimal J = GetCapital() * Convert.ToDecimal(Math.Pow(Convert.ToDouble(1 + GetTaxa()), Convert.ToDouble(GetTempo()))) - GetCapital();
            return J;
        }

    }
}
