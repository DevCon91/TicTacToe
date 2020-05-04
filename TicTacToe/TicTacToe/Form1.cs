using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int player = 2; //Even = X turn, Odd = O turn;
        public int turns = 0;
        public int s1 = 0;
        public int s2 = 0;
        public int sd = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            XWin.Text = "X: " + s1;
            OWin.Text = "O: " + s2;
            Draw.Text = "Draw: " + sd;
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "")
            {
                if (player % 2 == 0)
                {
                    button.Text = "X";
                    player++;
                    turns++;
                }
                else
                {
                    button.Text = "O";
                    player++;
                    turns++;
                }
                if(CheckDraw() == true)
                {
                    MessageBox.Show("It's a Draw");
                    sd++;
                    NewGame();
                }
                if(CheckWinner() == true)
                {
                    if(button.Text == "X")
                    {
                        MessageBox.Show("X Won!");
                        s1++;
                        NewGame();
                    }
                    else
                    {
                        MessageBox.Show("O Won!");
                        s2++;
                        NewGame();
                    }
                }
            }
        }

        private void EButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        void NewGame()
        {
            player = 2;
            turns = 0;
            B1.Text = B2.Text = B3.Text = B4.Text = B5.Text = B6.Text = B7.Text = B8.Text = B9.Text = "";
            XWin.Text = "X: " + s1;
            OWin.Text = "O: " + s2;
            Draw.Text = "Draw: " + sd;
        }

        private void NGButton_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        bool CheckDraw()
        {
            if ((turns == 9) && CheckWinner() == false)
                return true;
            else
                return false;
        }

        bool CheckWinner()
        {
            //Horizontal checks
            if ((B1.Text == B6.Text) && (B6.Text == B9.Text) && (B1.Text != ""))
                return true;
            else if ((B2.Text == B5.Text) && (B5.Text == B8.Text) && (B2.Text != ""))
                return true;
            else if ((B3.Text == B4.Text) && (B4.Text == B7.Text) && (B3.Text != ""))
                return true;

            //Verticle checks
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (B1.Text != ""))
                return true;
            else if ((B6.Text == B5.Text) && (B5.Text == B4.Text) && (B6.Text != ""))
                return true;
            else if ((B9.Text == B8.Text) && (B8.Text == B6.Text) && (B9.Text != ""))
                return true;

            //Diagonal checks
            if ((B1.Text == B5.Text) && (B5.Text == B7.Text) && (B1.Text != ""))
                return true;
            else if ((B9.Text == B5.Text) && (B5.Text == B3.Text) && (B9.Text != ""))
                return true;
            else
                return false;
        }

        private void RButton_Click(object sender, EventArgs e)
        {
            s1 = s2 = sd = 0;
            NewGame();
        }
    }
}
