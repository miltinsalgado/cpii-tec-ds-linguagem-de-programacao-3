using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_dos_Bomberman
{
    class Aqua_Bomber : Bomberman
    {
        public Aqua_Bomber(int life, int speed, string color)
            :base(life, speed, color)
        {
            Console.WriteLine("Construindo Aquabomber...");
        }

        public void Nadar()
        {
            Console.WriteLine("Nadando!");
        }
    }
}
