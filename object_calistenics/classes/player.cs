using System;
namespace object_calistenics.classes
{
    public class Player : PlayerMovements
    {
        private PlayerInformation playerInformation;

        public Player(String nickName , char token){
            this.playerInformation = new PlayerInformation(nickName , token);
        }
        public int move(){
            this.playerInformation.requestPosition();
            int position = Int32.Parse(Console.ReadLine());
            return position;
        }
        public void placeToken (bool confirm , int position){
            if (confirm){
                this.movements[position-1] = 1;
            }
        }
        public bool checkVictory (){
            bool victory = checkVertical() || checkHorizontal() || checkDiagonal() || checkInverted();
            if (victory)
            {
                this.playerInformation.winMessage();
            }
            return victory;
        }
        public char showToken(){
            return this.playerInformation.showToken();
        }
    }
}