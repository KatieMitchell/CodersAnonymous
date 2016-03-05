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
using 

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
    }
}
