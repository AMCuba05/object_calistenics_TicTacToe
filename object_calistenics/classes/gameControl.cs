using System;
namespace object_calistenics.classes
{
    public class GameControl : Board
    {
        private PlayerSwitch playerSwitch;
        public GameControl (Player player1 , Player player2){
            this.playerSwitch = new PlayerSwitch(player1 , player2);
        }
        public bool move (int position , char token){
            bool answer = false;
            if (verify(position)){
                this.space[position-1] = token;
                answer = true;
            }
            return answer;
        }
        private bool verify(int position){
            bool answer = true;
            if(this.space[position-1] != '-'){
                Console.WriteLine("posicion ocupada intente con otra...");
                answer = false;
            }
            return answer;
        }
        public bool end(){
            bool answer = true;
            for (int i = 0; i < 9; i++){
                if (this.space[i] == '-')answer = false;
            }
            return answer;
        }
        public bool draw(){
            bool answer = false;
            if (!playerSwitch.winner() && end()){
                Console.WriteLine("Empate");
                answer = true;
            }
            return answer;
        }
        public void start(GameControl game){
            int turn = 0;
            while (!this.finish()){
                this.showBoard();
                turn = this.playerSwitch.begin( turn , game);
                Console.Clear();
            }
        }
        public void showBoard(){
            this.show();
        }
        public bool finish(){
            return playerSwitch.winner() || this.draw();
        }
    }
    
}