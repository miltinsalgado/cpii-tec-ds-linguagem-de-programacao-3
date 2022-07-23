using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_LP3
{
    public class Usuario
    {
        public enum Papel
        {
            Padrao = 0, 
            Administrador
        }

        public string nome = string.Empty;
        public string senha = string.Empty;
        public Papel papel = Papel.Padrao;

        public Usuario(string n, string s, Papel p)
        {
            nome = n;
            senha = s;
            papel = p;
        }

        public Usuario(string n, string s)
        {
            nome = n;
            senha = s;
            
        }

        public Usuario()
        {

        }
    }
}
