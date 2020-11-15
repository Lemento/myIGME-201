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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.startButton.Click += new EventHandler(StartButton__Click);
            this.lowTextBox.KeyPress += new KeyPressEventHandler(Only_Digits);
            this.highTextBox.KeyPress += new KeyPressEventHandler(Only_Digits);
        }

        private void StartButton__Click(object sender, EventArgs e)
        {
            bool bConv = true;
            int lowNumber = 0;
            int highNumber = 0;

            lowNumber = Int32.Parse(lowTextBox.Text);
            highNumber = Int32.Parse(highTextBox.Text);

            if ( lowNumber > highNumber || lowNumber == highNumber || bConv == false )
            {
                MessageBox.Show("The numbers are invalid.");
            }
            else
            {
                GameForm gameForm = new GameForm(lowNumber, highNumber);
                gameForm.ShowDialog();
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
