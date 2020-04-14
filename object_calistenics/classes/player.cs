using System;
namespace object_calistenics.classes
{
    public class Player : PlayerMovements
    {
        private String nickName;
        private char token;

        public Player(String nickName , char token){
            this.nickName = nickName;
            this.token = token;
        }

        public void move(GameControl gameControl){
            bool repeat = true;
            do{
                System.Console.WriteLine(this.nickName + ", Ingrese la posicion donde poner la ficha");
                int position = Int32.Parse(Console.ReadLine());
                repeat = !gameControl.move(position , this.token);
                if (!repeat) this.movements[position-1] = 1;
            } while (repeat);
        }
        public bool checkVictory (){
            bool victory = checkVertical() || checkHorizontal() || checkDiagonal() || checkInverted();
            if (victory)
            {
                Console.WriteLine("jugador " + this.nickName + " gano");
            }
            return victory;
        }
    }
}