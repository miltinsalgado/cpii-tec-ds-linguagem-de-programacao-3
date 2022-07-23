using System;

namespace Exercício_dos_Bomberman
{
    class Program
    {
        static void Main(string[] args)
        {
            Bomberman whitebomber = new Bomberman(10, 5, "branco");
            Bomberman blackbomber = new Bomberman(10, 5, "preto");
            Bomberman bluebomber = new Bomberman(10, 5, "azul");

            whitebomber.ColocarBomba();
            blackbomber.ColocarBomba();
            bluebomber.ColocarBomba();

            Fire_Bomber firebomber = new Fire_Bomber(20, 2, "vermelho");
            firebomber.ColocarBomba();
            firebomber.Explodir();

            Aqua_Bomber aquabomber = new Aqua_Bomber(8, 14, "azul");
            aquabomber.ColocarBomba();
            aquabomber.Nadar();

            Console.ReadLine();
        }
    }
}
