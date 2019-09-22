using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace FireGameWithOption
{
    public partial class Form1 : Form
    {
        //global varaible that are used in the project for counting the bullet generating the radom no , and count the fire 
        int Bullets = 0, Rand_No = 0, Count_Bullet = 2,Count_Trigger=0;
        Game obj = new Game();

        public Form1()
        {
            InitializeComponent();

            //calling the user define method is used to end the game or start the game at starting point that is used to disable all the button of working 
            Random objRandom = new Random();
            End_Game();
        }
        //this is the user define method that is used to disable all the button from the game and call this method at the end of the fire or after displaying the result 
        public void End_Game()
        {
            start.Enabled = false;
            Bullet.Enabled = false;
            Fire.Enabled = false;
            pbBullet.Visible = false;
            Pistol.ImageLocation = "";
            Count_Bullet = 2;
            Bullets = 0;
            Count_Trigger = 0;
         
        }
        /*this is another user define method that is used to start the game when the user choose any gun from the given three one then the start method will automatically called by the code 
                    this code is used to enable all the button for the player so thus he can play the game 
             * */
        public void Start_Game()
        {
            start.Enabled = true;
            Bullet.Enabled = true;
            Fire.Enabled = true;
            Fire_Bullet();
            optnFirst.Enabled = true;
            optnSecnd.Enabled = true;
            optnThird.Enabled = true;
        }

        private void optnFirst_Click(object sender, EventArgs e)
        {
            //this code is used to get the image of the gun for use by the player
            Pistol.ImageLocation = "option/optn1.png";
            //this code is used to invoke the start game method 
            Start_Game();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //this code is used to get the image of the gun for use by the player
            Pistol.ImageLocation = "option/optn2.png";
            //this code is used to invoke the start game method 
            Start_Game();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //this code is used to get the image of the gun for use by the player
            Pistol.ImageLocation =obj.genPic();
            //this code is used to invoke the start game method 
            Start_Game();
        }

        private void start_Click(object sender, EventArgs e)
        {
            //this is the first button that is used to load the game and strt the game 
            MessageBox.Show("Welcome to the Game Click on Spin to Load Bullets ");
            start.Enabled = false;
        }
        //this is another user define method that is used to generate the random no so thus it can be compare with the trigger of the bullet when the trigger of the bullet become equal with the random no then it will generate the sound of the fire 
        // this method is also used to passs  the random no to the global varaible 
        public void Fire_Bullet() {   
            Random Instance_Object = new Random();
             Rand_No = Instance_Object.Next(1, 5);
        }

        // this is another one user define method that is used to find the result with the help of the random method 
        public void Get_Result() {
            Random Instance_Object = new Random();
            int  Image = Instance_Object.Next(2,6);
            // if the random no and the bullet's trigger are equal then the game over is display and the player will be the winner of the game 
            if(Image==Count_Trigger)
            {
                pbBullet.Visible =true;
                MessageBox.Show("You are the winner of the Game and you got 100 Score");
                //after finding the winner then invoke the method of the end game so thus the game can be played again  
                End_Game();
                optnFirst.Enabled = false;
                optnSecnd.Enabled = false;
                optnThird.Enabled = false;
            }
        }

        private void Retry_Click(object sender, EventArgs e)
        {
            Start_Game();
        }

        private void Fire_Click(object sender, EventArgs e)
        {
            //this variable that is used too count  the trigger 
            Bullets++;
            //this loop is used to fetch the no one by one till the bullet counting 
            if (Bullets <= 6)
            {
                for (int loop = 1; loop <= Bullets; loop++)
                {
                    // this code is used to compare the  random no with the bullet  counting using the varaible of loop
                    if (Rand_No == loop)
                    {
                        // generate the fire sound 
                        SoundPlayer player = new SoundPlayer(Resource1.fire);
                        player.Play();

                        Count_Trigger++;
                        //this code is used to count the trigger 
                        Count_Bullet = Count_Bullet - 1;
                        loop = Bullets + 3;
                    }
                    //this code is used to get the result 
                    Get_Result();
                }
            }
            if (Bullets == 6) {
                MessageBox.Show("Your First Chance is over Now turn to Another Chance ");
                Bullets = 0;
                Fire_Bullet();
            }
            //after the loop if the all the shoot are empty then the player will loose the game and generate the Message box and also call the end game 
            if (Count_Bullet==0) {
                End_Game();
                MessageBox.Show("Game Is Over and unfortunately You loss the Game");
                optnFirst.Enabled = false;
                optnSecnd.Enabled = false;
                optnThird.Enabled = false;
            }
        }

        private void Bullet_Click(object sender, EventArgs e)
        {
            //this is  the 2nd button that is used to load the bullet in the gun 
            Bullets = 2;
            Bullet.Enabled = false;
        }
    }
   }

