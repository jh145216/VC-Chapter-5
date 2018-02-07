using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        int randomNumber;
        Random randNumber = new Random();

        int score = 0;
        int rock = 1;
        int paper = 2;
        int scissors = 3;

        private void picRock_Click(object sender, EventArgs e)
        {


            randomNumber = randNumber.Next(1, 3);

            if (randomNumber == rock)
            {
                lblWinLoseDraw.Text = "You Tied!";
            }
            else if (randomNumber == paper)
            {
                lblWinLoseDraw.Text = "You Lost!";
            }
            else if (randomNumber == scissors)
            {
                lblWinLoseDraw.Text = "You Won!";
                score = score + 1;
                lblScore.Text = "You have won " + score.ToString() + "x";
            }
        }

        private void picPaper_Click(object sender, EventArgs e)
        {
            randomNumber = randNumber.Next(1, 3);

            if (randomNumber == rock)
            {
                lblWinLoseDraw.Text = "You Won!";
                score = score + 1;
                lblScore.Text = "You have won " + score.ToString() + "x";
            }
            else if (randomNumber == paper)
            {
                lblWinLoseDraw.Text = "You Tied!";
            }
            else if (randomNumber == scissors)
            {
                lblWinLoseDraw.Text = "You Lost!";
            }
        }
         
        private void picScissors_Click(object sender, EventArgs e)
        {
            {
                randomNumber = randNumber.Next(1, 3);

                if (randomNumber == rock)
                {
                    lblWinLoseDraw.Text = "You Lost!";
                }
                else if (randomNumber == paper)
                {
                    lblWinLoseDraw.Text = "You Won!";
                    score = score + 1;
                    lblScore.Text = "You have won " + score.ToString() + "x";
                }
                else if (randomNumber == scissors)
                {
                    lblWinLoseDraw.Text = "You Tied!";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}