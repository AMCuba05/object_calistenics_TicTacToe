using System;
namespace object_calistenics.classes{
    public class PlayerInformation{
        private String nickname;
        private char token;
        public PlayerInformation(string nickname , char token){
            this.nickname = nickname;
            this.token = token;
        }
        public void requestPosition(){
            Console.WriteLine(this.nickname + ", Ingrese la posicion donde poner la ficha");
        }
        public char showToken (){
            return this.token;
        }
        public void winMessage(){
            Console.WriteLine(this.nickname + ", Gano");
        }
    }
}