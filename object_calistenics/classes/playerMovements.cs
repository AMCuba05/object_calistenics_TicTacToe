namespace object_calistenics.classes{
    public class PlayerMovements{
        protected int[] movements;
        public PlayerMovements (){
            this.movements = new int[9] {0,0,0,0,0,0,0,0,0};
        }
        public bool checkHorizontal(){
            bool answer = false;
            for (int i = 0; i < 9; i+=3){
                answer = horizontalLine(i,i+3) || answer;
            }
            return answer;
        }
        private bool horizontalLine(int lowRange , int maxRange){
            bool answer = true;
            for (int i = lowRange; i < maxRange; i++){
                if (this.movements[i] == 0) answer = false;
            }
            return answer;
        }
        public bool checkVertical(){
            bool answer = false;
            for (int i = 0; i < 3; i++){
                answer = verticalLine(i) || answer;
            }
            return answer;
        }
        public bool verticalLine(int begin){
            bool answer = true;
            for (int i = begin; i < 9 ; i+=3){
                if (this.movements[i] == 0) answer = false;
            }
            return answer;
        }
        public bool checkDiagonal(){
            bool answer = true;
            for (int i = 0; i < 9; i+=4){
                if (this.movements[i] == 0) answer = false;
            }
            return answer;
        }
        public bool checkInverted(){
            bool answer = true;
            for (int i = 2; i < 7; i+=2){
                if (this.movements[i] == 0) answer = false;
            }
            return answer;
        }
    }
}