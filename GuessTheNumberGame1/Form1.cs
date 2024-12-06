using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class Form1 : Form

    {
        private int randomNumber;
        private int previousDifference;

        public Form1()
        {
            InitializeComponent();
            StartNewGame();
        }

        private void StartNewGame()
        {
            Random random = new Random();
            randomNumber = random.Next(1, 1000);
            previousDifference = int.MaxValue;
            this.BackColor = SystemColors.Control;
            feedbackLabel.Text = "";
            guessTextBox.Text = "";
            guessTextBox.Enabled = true;
        }



        private void guessTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(guessTextBox.Text, out int userGuess))
            {
                int difference = Math.Abs(randomNumber - userGuess);

                if (userGuess == randomNumber)
                {
                    this.BackColor = Color.Green;
                    MessageBox.Show("Correct!", "Guess the Number");
                    guessTextBox.Enabled = false;
                }
                else
                {
                    feedbackLabel.Text = userGuess > randomNumber ? "Too High" : "Too Low";
                    this.BackColor = difference < previousDifference ? Color.Red : Color.Blue;
                    previousDifference = difference;
                }
            }
            else
            {
                feedbackLabel.Text = ""; 
                this.BackColor = SystemColors.Control; 
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

    }
}
