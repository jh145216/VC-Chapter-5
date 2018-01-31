using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random randNumber = new Random();
            randomNumber = randNumber.Next(1, 10);
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Random randNumber = new Random();
            randomNumber = randNumber.Next(1, 20);
            txtNumberGuess.Clear();
            lblOutput.Text = string.Empty;
            number = 0;
            number2 = 0;

        }

        int randomNumber;
        int number = 0;
        int number2 = 0;

            
        private void btnGuess_Click(object sender, EventArgs e)
        {
            string input;
            int guess;


            input = txtNumberGuess.Text;
            guess = Convert.ToInt32(input);


            if (guess != randomNumber)
            {
                if (guess > randomNumber)
                {
                    number = number + 1;
                    number2 = 0;
                    if (number == 2)
                    {

                        lblOutput.Text = "You dummy! I said you guessed to high!";

                    }
                    else if (number < 2)
                    {

                        lblOutput.Text = "You guessed to high. Try again.";

                    }

                }
                else if (guess < randomNumber)
                {
                    number2 = number2 + 1;
                    number = 0;
                    if (number2 == 2)
                    {

                        lblOutput.Text = "You dummy! I said you guessed to low!";

                    }
                    else if (number2 < 2)
                    {

                        lblOutput.Text = "You guessed to low. Try again.";

                    }

                }
            }
            else
            {
                lblOutput.Text = "You guessed it right! the number was " + randomNumber + "!";

            }

        }

    }


}
