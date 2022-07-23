using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_dos_Bomberman
{
    class Bomberman
    {
        public int bman_life = 10;
        public int bman_speed = 5;
        public string bman_color = "branco";

        public Bomberman(int life, int speed, string color)
        {
            bman_life = life;
            bman_speed = speed;
            bman_color = color;

            Console.WriteLine("Construindo bomberman...");
        }

        public void ColocarBomba()
        {
            Console.WriteLine("Colocando Bomba!");
        }
    }
}
