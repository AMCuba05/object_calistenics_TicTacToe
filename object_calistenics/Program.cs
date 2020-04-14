using System;
using object_calistenics.classes;
namespace object_calistenics
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("ingrese nombre de jugador 1");
            string nameP1 = Console.ReadLine();
            Console.WriteLine("marca de jugador 1");
            char tokenP1 = Console.ReadLine().ToCharArray()[0];
            Console.WriteLine("ingrese nombre de jugador 2");
            string nameP2 = Console.ReadLine();
            Console.WriteLine("marca de jugador 2");
            char tokenP2 = (char)Console.ReadLine().ToCharArray()[0];
            GameControl gameControl = new GameControl(new Player(nameP1 , tokenP1) , new Player(nameP2 , tokenP2));
            gameControl.start(gameControl);
            
        }
    }
}
