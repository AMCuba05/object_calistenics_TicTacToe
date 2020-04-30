namespace object_calistenics.classes
{
    public class GameControl : Board
    {
        private PlayerSwitch playerSwitch;
        public GameControl (Player player1 , Player player2){
            this.playerSwitch = new PlayerSwitch(player1 , player2);
        }
        public bool move (int position , int turn){
            bool answer = false;
            if (verify(position)){
                this.space[position-1] = this.playerSwitch.showCurrentToken(turn);
                answer = true;
            }
            return answer;
        }
        private bool verify(int position){
            bool answer = true;
            if(this.space[position-1] != '-'){
                this.ocupiedMessage();
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
                this.DrawMessage();
                answer = true;
            }
            return answer;
        }
        public void start(){
            int turn = 0;
            while (!playerSwitch.winner() || this.draw()){
                this.show();
                int position = this.playerSwitch.begin( turn );
                bool success = this.move(position , turn);
                turn = this.playerSwitch.change(success , turn , position);
                this.clear();
            }
        }
    }
}