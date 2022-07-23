using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_2C
{
    class Questão
    {
        public string enunciado = "";
        public string alternativaA = "";
        public string alternativaB = "";
        public string alternativaC = "";
        public string alternativaD = "";
        public string alternativaE = "";
        public string resolucao = "";
        public int quantAcertos = 0;
        public int quantErros = 0;
        public string alternativaCorreta = "";

        public Questão()
        {

        }

        public Questão(string enc, string a, string b, string c, string d, string e, string rsc, int acertos, int erros, string correta)
        {
            enunciado = enc;
            alternativaA = a;
            alternativaB = b;
            alternativaC = c;
            alternativaD = d;
            alternativaE = e;
            resolucao = rsc;
            quantAcertos = acertos;
            quantErros = erros;
            alternativaCorreta = correta;
        }

        public override string ToString()
        {
            string questao = enunciado + "\r\n" + alternativaA + "\r\n" + alternativaB + "\r\n" + alternativaC + "\r\n" + alternativaD + "\r\n" + alternativaE + "\r\n" + resolucao + "\r\n" + quantAcertos + "\r\n" + quantErros + "\r\n" + alternativaCorreta;
            return questao;
        }
    }
}
