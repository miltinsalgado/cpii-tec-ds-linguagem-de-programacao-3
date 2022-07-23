using System;
using System.Collections.Generic;
using System.Text;

namespace Questão_03
{
    class Recibo
    {
        public string nome_passageiro = "";
        public string lugar_origem = "";
        public string lugar_destino = "";
        public string data_viagem = "";
        public string empresa = "";
        public decimal preco_passagem = 0;

        public Recibo (string np, string lo, string ld, string dv, string e, decimal pp)
        {
            nome_passageiro = np;
            lugar_origem = lo;
            lugar_destino = ld;
            data_viagem = dv;
            empresa = e;
            preco_passagem = pp;
        }

        public override string ToString()
        {
            string recibo = "";
            recibo = nome_passageiro + "\r\n" + lugar_origem + "\r\n" + lugar_destino + "\r\n" + data_viagem + "\r\n" + empresa + "\r\n" + preco_passagem + "\r\n" + "---------------------";
            return recibo;
        }
    }
}
