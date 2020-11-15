using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICE
{
    public partial class GameForm : Form
    {
        int nRandom;
        int numOfGuesses = 0;

        public GameForm(int lowNumber, int highNumber)
        {
            InitializeComponent();

            Random rand = new Random();
            nRandom = rand.Next(lowNumber, highNumber);

            this.timer.Interval = 500;
            this.toolStripProgressBar.Maximum = 90;
            this.toolStripProgressBar.Value = this.toolStripProgressBar.Maximum;
            this.timer.Start();

            this.AcceptButton = this.guessButton;
            this.guessButton.Click += new EventHandler(GuessButton__Click);
            this.timer.Tick += new EventHandler(Timer__Tick);
            this.guessTextBox.KeyPress += new KeyPressEventHandler(Only_Digits);
        }

        private void GuessButton__Click(object sender, EventArgs e)
        {
            int guess = Int32.Parse(guessTextBox.Text);

            if(guess >= 1)
            {
                numOfGuesses++;

                if (guess > nRandom)
                {

                    this.outputLabel.Text = "Guess of " + guess + ": HIGH";
                    this.guessTextBox.Text = "";
                    this.guessTextBox.Focus();

                }
                else if (guess < nRandom)
                {
                    this.outputLabel.Text = "Guess of " + guess + ": Low";
                    this.guessTextBox.Text = "";
                    this.guessTextBox.Focus();
                }
                else if (guess == nRandom)
                {
                    this.timer.Stop();
                    MessageBox.Show("Good job, it only took you " + numOfGuesses + " guesses!");
                    this.Close();
                }
            }
        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            --this.toolStripProgressBar.Value;

            if (this.toolStripProgressBar.Value == 0)
            {
                this.timer.Stop();

                MessageBox.Show("Time's up, you failed to guess the number, even after " + numOfGuesses + " tries.");
                this.Close();
            }
        }

        private void Only_Digits(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }
    }
}
