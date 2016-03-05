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
            hideAllText();
            loadingPic.Show();
        }


        private void loadingPic_Click(object sender, EventArgs e)
        {
            ShowAllText();
            startNewGame();
            loadingPic.Hide();

        }

        public void RenderGame()
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
        //  private void resetLifes()
        //  {

        //  }

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

        struct singleCard
        {
            public int position;
            public string text;
        }

        public int currentScore = 0;
        public int round
            Time;
        singleCard[] card = new singleCard[5];


        private void startNewGame()
        {
            currentScore = 0;
            myLives = 3;
            newRound();

        }

        private void hideAllText()
        {
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            Pic1.Show();
            Pic2.Show();
            Pic3.Show();
            Pic4.Show();
            Pic5.Show();
            Pic6.Show();
        }
        private void ShowAllText()
        {
            Pic1.Hide();
            Pic2.Hide();
            Pic3.Hide();
            Pic4.Hide();
            Pic5.Hide();
            Pic6.Hide();
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
        }

        private void flippingCard()
        {
            Pic1.Image = Properties.Resources.card;
            Pic2.Image = Properties.Resources.card;
            Pic3.Image = Properties.Resources.card;
            Pic4.Image = Properties.Resources.card;
            Pic5.Image = Properties.Resources.card;
            Pic6.Image = Properties.Resources.card;
        }

        private void newRound()
        {
            roundTime = 0;
            roundTimer.Enabled = true;
            hideAllText();
            flippingCard();
            ShowAllText();
        }

        private void answerBox_Click(object sender, EventArgs e)
        {
            PictureBox clickBox = (PictureBox)sender;
            string positionNum = clickBox.Name.Substring(clickBox.Name.Length - 1, 1);
            Label showLabel = this.Controls.Find("label" + positionNum, true).FirstOrDefault() as Label;
            showLabel.Show();
        }

        public void roundTimer_Tick(object sender, EventArgs e)
        {
            roundTime = roundTime + 1;
            if (roundTime == 15)
            {
                roundTimer.Stop();
                hideAllText();
            }
        }

    }
}



