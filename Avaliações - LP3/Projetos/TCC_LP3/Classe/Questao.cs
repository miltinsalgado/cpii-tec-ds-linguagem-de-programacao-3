using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_LP3
{
    public class Questao
    {
        public int codigo = 0;
        public string enunciado = string.Empty;
        public string altA = string.Empty;
        public string altB = string.Empty;
        public string altC = string.Empty;
        public string altD = string.Empty;
        public string altE = string.Empty;
        public char altCorreta = 'X';
        public string resolucao = string.Empty;
        public int acertos = 0;
        public int erros = 0;

        public Questao(int cod, string e, string A, string B, string C, string D, string E, char X, string r, int ac, int er)
        {
            codigo = cod;
            enunciado = e;
            altA = A;
            altB = B;
            altC = C;
            altD = D;
            altE = E;
            altCorreta = X;
            resolucao = r;
            acertos = ac;
            erros = er;
        }

        public Questao(string e, string A, string B, string C, string D, string E, char X, string r, int ac, int er)
        {
            enunciado = e;
            altA = A;
            altB = B;
            altC = C;
            altD = D;
            altE = E;
            altCorreta = X;
            resolucao = r;
            acertos = ac;
            erros = er;
        }

        public Questao()
        {

        }


        public int PercentualDeAcertos()
        {
            int total = acertos + erros;
            int percentual = 0;

            if (total != 0)
                percentual = acertos * 100 / total;
            else
                percentual = 0;

            return percentual;
        }
    }
}