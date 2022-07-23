using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_dos_Bomberman
{
    class Earth_Bomber : Bomberman
    {
        public Earth_Bomber(int life, int speed, string color)
            :base(life, speed, color)
        {

        }

        public void Rolar()
        {
            Console.WriteLine("Rolando!");
        }
    }
}
