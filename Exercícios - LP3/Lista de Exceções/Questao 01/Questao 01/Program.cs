using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] list = new string[5];

            list[0] = "segunda";
            list[1] = "terca";
            list[2] = "quarta";
            list[3] = "quinta";
            list[4] = "sexta";

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(list[i].ToString());
            }

            Console.ReadLine();
        }
    }

}
