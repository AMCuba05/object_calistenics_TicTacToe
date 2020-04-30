using System;
namespace object_calistenics.classes
{
    public class PlayerSwitch
    {
        private Player[] players;
        public PlayerSwitch (Player player1 , Player player2){
            Random random = new Random();  
            this.players = new Player[2];
            int initial = (int) random.Next(0, 1);
            int another_index = this.switchInd(initial);
            this.players[initial] = player1;
            this.players[another_index] = player2;
        }
        public int switchInd (int index ){
            if (index + 1 == 2 ){
                index = -1;
            }    
            return index + 1;
        }
        public int begin(int turn){
            int position = this.players[turn].move();
            return position;
        }
        public bool winner (){
            bool winner = false;
            if(players[0].checkVictory() || players[1].checkVictory()){
                winner = true;
            }
            return winner;
        }
        public char showCurrentToken(int turn){
            return this.players[turn].showToken();
        }
        public int change (bool success , int turn , int position){
            if (success){
                this.players[turn].placeToken(success , position);
                turn = this.switchInd(turn);
            }
            return turn;
        }
    }
}