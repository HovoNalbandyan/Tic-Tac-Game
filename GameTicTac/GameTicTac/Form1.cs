using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTicTac
{
    public partial class Form1 : Form
    {


        bool turn = true;
        int turn_count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Anaasun");
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            turn_count++;
            //Call method Winner
            Chekwinner();

        }
        private void Chekwinner()
        {
        
        bool there_is_awinner= false;
            //Chek horizontal winner
            if ((A1.Text==A2.Text)&&(A2.Text==A3.Text)&&(!A1.Enabled))
                there_is_awinner=true;
            else if ((A4.Text==A5.Text)&&(A5.Text==A6.Text)&&(!A4.Enabled))
                 there_is_awinner=true;
            else if ((A7.Text==A8.Text)&&(A8.Text==A9.Text)&&(!A7.Enabled))
                 there_is_awinner=true;
            //Chek vertical winner
            if ((A1.Text == A4.Text) && (A4.Text == A7.Text)&&(!A1.Enabled))
                 there_is_awinner = true;
            else if ((A2.Text == A5.Text) && (A5.Text == A8.Text)&&(!A2.Enabled))
                 there_is_awinner = true;
            else if ((A3.Text == A6.Text) && (A6.Text == A9.Text)&&(!A3.Enabled))
                 there_is_awinner = true;
            //Chek diaganal winner
            if ((A1.Text == A5.Text) && (A5.Text == A9.Text) && (!A1.Enabled))
                there_is_awinner = true;
            else if ((A3.Text == A5.Text) && (A5.Text == A7.Text) && (!A7.Enabled))
                there_is_awinner = true;

            if (there_is_awinner)
            {
                DisabeleButton();
                string winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";
                MessageBox.Show(winner+" "+"Wins");
             }
            else
            {
                if (turn_count==9)
                    MessageBox.Show("Draw" + " " + "wwwwww");

            }

        }
        
        private void DisabeleButton()
        {
            try
            {
                foreach (Component c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                    
                }
            }
            catch { }

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            try
            {
                foreach (Component c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        /*  private void newgame()
          {
              if (turn_count == 9)
                  turn = true;
              turn_count = 0;
              try
              {
                  foreach (Component c in Controls)
                  {
                      Button b = (Button)c;
                      b.Enabled = true;
                      b.Text = "";
                  }
              }
              catch { }
          }
          */
    }
}
