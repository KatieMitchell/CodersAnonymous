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

            MessageBox.Show("TEST");

        }

        public class card
        {
            private static readonly List<card> _all = new List<card>();
            public static readonly card card1 = new card("1");
            public static readonly card card2 = new card("2");
            public static readonly card card3 = new card("3");
            public static readonly card card4 = new card("4");
            public static readonly card card5 = new card("5");
            public static readonly card card6 = new card("6");

            public readonly string Number;

            private card(string number)
            {
                Number = number;
                _all.Add(this);
            }

            public static IEnumerable<card> All => _all;

            public static IEnumerable<card> Random(int counter)
            {
                List<card> cards = new List<card>();
                while(counter > 0)
                {
                    counter--;
                    if (cards.counter < 1) 
                    {
                        cards.AddRange(_all);
                    }
                    int index = Form1.Random.Value.Next(cards.counter);
                }
            }

            private static void AddRange(List<card> _all)
            {
                throw new NotImplementedException();
            }
        }

        private void renderGame()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(renderGame));
                return;
            }
            Size size = gameArea.Size;
            double xscale = size.Width / 2;
            double yscale = size.Width / 6;

            int countRows;
            countRows = 1;
           foreach ()

   
        }
    }
}
