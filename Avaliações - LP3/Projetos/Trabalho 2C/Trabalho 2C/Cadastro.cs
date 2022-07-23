using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_2C
{
    class Cadastro
    {
        public string usuario = String.Empty;
        public string senha = String.Empty;

        public Cadastro()
        {

        }

        public Cadastro(string user, string password)
        {
            usuario = user;
            senha = password;
        }

        public override string ToString()
        {
            string cadastro = usuario + "\r\n" + senha + "\r\n" + "==================================";
            return cadastro;
        }
    }
}
