using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using crashCourse;

namespace crashCourse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int CardGen()
        {
            Random rnd = new Random();
            int chosenCard = rnd.Next(1, 6);
            return chosenCard;
        }

        private void SetStartScreen()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(SetStartScreen));
                return;
            }
            loadingPic.Show();
        }

        private void loadingPic_Click(object sender, EventArgs e)
        {
            loadingPic.Hide();

        }

        private void RenderGame()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(RenderGame));
                return;
                //Game game = _currentgame;
                //if (game == null) return;
                
      
            }
        }

        public int myLives = 3;
        public int animationPosition = 0;
        public int targetLocation = 0;
        private void loseALife()
        {
            switch (myLives)
            {
                case 1:
                    targetLocation = 386;
                    break;
                case 2:
                    targetLocation = 289;
                    break;
                case 3:
                    targetLocation = 196;
                    break;
            }
            animationTimer.Enabled = true;
            //* Start the animation timer.
        }
        private void resetLifes()
        {

        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            if (pBoxCar.Location.X < targetLocation)
            {
                pBoxCar.Location = new Point(pBoxCar.Location.X + 10, pBoxCar.Location.Y);
            }
            else
            {
                switch (myLives)
                {
                    case 3:
                        life1.Hide();
                        break;
                    case 2:
                        life2.Hide();
                        break;
                    case 1:
                        life3.Hide();
                        //*GAME OVER HERE.
                        break;
                }
                animationTimer.Enabled = false;
                myLives = myLives - 1;
                pBoxCar.Location = new Point(0, pBoxCar.Location.Y);
            }
        }
    }
    ᐧ
}

    
}
