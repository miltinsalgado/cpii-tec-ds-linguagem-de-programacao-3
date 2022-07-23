using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestaoJuros
{
    class JurosSimples : Juros
    {
        public JurosSimples(decimal C, decimal i, decimal t)
            :base(C, i, t)
        {
            
        }

        public override decimal CalcularJuros()
        {
            decimal j = GetCapital() * GetTaxa() * GetTempo();
            return j;
        }
    }
}
