using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireGameWithOption
{
    public class Game
    {
        public string Messageboxgame { get; set; }
        // we all know that if we want to get a no then we have to use the random class to generate the random no from class using the method of the class next 
        Random obj = new Random();
        int y = 0;
        //start game method is used to start the game 
        public int Start_Game()
        {
            y++;
            return y;
        }
        // this is  the third method that is used to get the source of the pic  to the picture box
        public String genPic() {
            return "option/optn3.png";
        }
        public string Messagebox()
        {
            MessageBox.Show("Game is over and unfortunately you lose the game");
            return Messageboxgame;
        }
        public string Messagebox2()
        {
            MessageBox.Show("You are the winner of the Game and you got 100 Score");
            return Messageboxgame;
        }
        public string Messagebox3()
        {
            MessageBox.Show("Your First Chance is over Now turn to Another Chance ");
            return Messageboxgame;
        }

    }
}
