using EThompson_RockPaperScissors.Properties;
using System;
using System.Windows.Forms;

namespace EThompson_RockPaperScissors
{

    public partial class Form1 : Form
    {
        Player p = new Player();
        Computer c = new Computer();
        int d = 0;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            p.score = 0;
            c.score = 0;
            pOut.Text = p.score.ToString();
            cOut.Text = c.score.ToString();
            dOut.Text = d.ToString();
        }

        private void clearScores()
        {
            p.score = 0;
            c.score = 0;
            d = 0;
        }

        private void scoreIt()
        {
            if (c.move == p.move)
            {
                winner.Text = "Draw!";
                d += 1;
                dOut.Text = d.ToString();

            }
            else if (c.move == 0 && p.move == 1)
            {
                winner.Text = "Player Wins!";
                p.score += 1;
                pOut.Text = p.score.ToString();

            }
            else if (c.move == 0 && p.move == 2)
            {
                winner.Text = "Computer Wins!";
                c.score += 1;
                cOut.Text = c.score.ToString();

            }
            else if (c.move == 1 && p.move == 2)
            {
                winner.Text = "Player Wins!";
                p.score = +1;
                pOut.Text = p.score.ToString();

            }
            else if (c.move == 1 && p.move == 0)
            {
                winner.Text = "Computer Wins!";
                c.score = +1;
                cOut.Text = c.score.ToString();
            }
            else if (c.move == 2 && p.move == 1)
            {
                winner.Text = "Computer Wins!";
                c.score += 1;
                cOut.Text = c.score.ToString();
            }
            else if (c.move == 2 && p.move == 0)
            {
                winner.Text = "Player Wins!";
                p.score += 1;
                pOut.Text = p.score.ToString();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            var confirmReset = MessageBox.Show("Are you sure you want to reset the scores?", "Confirm Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmReset == DialogResult.Yes)
            {
                clearScores();
                winner.Text = string.Empty;
                p.score = 0;
                c.score = 0;
                pOut.Text = p.score.ToString();
                cOut.Text = c.score.ToString();
                dOut.Text = d.ToString();
                pIcon.Image = Resources.justFrame;
                cIcon.Image = Resources.justFrame;
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            var confirmExit = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmExit == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        public void compMove()
        {
            c.move = rand.Next(3);
            switch (c.move)
            {
                case 0: cIcon.Image = Resources.rock; break;
                case 1: cIcon.Image = Resources.paper; break;
                case 2: cIcon.Image = Resources.scissors; break;
            }
        }

        private void rockButton_Click(object sender, EventArgs e)
        {
            pIcon.Image = Resources.rock;
            p.move = 0;
            compMove();
            scoreIt();
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            pIcon.Image = Resources.paper;
            p.move = 1;
            compMove();
            scoreIt();

        }

        private void scissorsButton_Click(object sender, EventArgs e)
        {
            pIcon.Image = Resources.scissors;
            p.move = 2;
            compMove();
            scoreIt();
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            p.move = rand.Next(3);
            switch (p.move)
            {
                case 0: pIcon.Image = Resources.rock; break;
                case 1: pIcon.Image = Resources.paper; break;
                case 2: pIcon.Image = Resources.scissors; break;
            }
            compMove();
            scoreIt();
        }
    }

    public class Computer
    {
        public int score;
        public int move;
    }

    public class Player
    {
        public int score;
        public int move;
    }
}
