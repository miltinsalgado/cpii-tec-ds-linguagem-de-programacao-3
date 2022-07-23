using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_dos_Bomberman
{
    class Fire_Bomber : Bomberman 
    {
        public Fire_Bomber(int life, int speed, string color)
            :base(life, speed, color)
        {
            Console.WriteLine("Construindo Firebomber...");
        }

        public void Explodir()
        {
            Console.WriteLine("Explodindo!");
        }
    }
}
