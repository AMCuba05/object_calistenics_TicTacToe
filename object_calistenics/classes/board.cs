using System;
namespace object_calistenics.classes
{
    public class Board
    {
        protected char [] space;

        public Board ()
        {
            this.space = new char[9] {'-','-','-','-','-','-','-','-','-'};
        }
        public void ocupiedMessage(){
            Console.WriteLine("posicion ocupada intente con otra...");
        }
        public void DrawMessage(){
            Console.WriteLine("Empate");
        }
        public void clear(){
            Console.Clear();
        }
        public void show ()
        {
            Console.WriteLine("|" + filled(1) + "|" + filled(2) + "|" + filled(3));
            Console.WriteLine("|" + filled(4) + "|" + filled(5) + "|" + filled(6));
            Console.WriteLine("|" + filled(7) + "|" + filled(8) + "|" + filled(9));
        }
        private string filled(int position)
        {
            string field = this.space[position-1].ToString();
            if (this.space[position-1] == '-'){
                field = position.ToString();
            }
            return field;
        }
    }
}