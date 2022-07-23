using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_dos_Bomberman
{
    class Cyclone_Bomber : Bomberman
    {
        public Cyclone_Bomber(int life, int speed, string color)
            :base(life, speed, color)
        {

        }

        public void Voar()
        {
            Console.WriteLine("Voando!");
        }
    }
}
