using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserHell
{

    public partial class Form1 : Form
    {
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();

            this.passTextBox.TextChanged += new EventHandler(PassTextBox__TextChanged);
            this.passTextBox.KeyPress += new KeyPressEventHandler(PassTextBox__KeyPress);
            this.enterButton.Click += new EventHandler(EnterButton__Click);
            this.Enter += new EventHandler(Enter__Key);

        }

        private void EnterButton__Click(object sender, EventArgs e)
        {
            UserInterface.password = this.passTextBox.Text;
            this.Close();
        }

        private void Enter__Key(object sender, EventArgs e)
        {
            this.passTextBox.Text = "0";
            this.passTextBox.Location = new Point(93, 77);
            this.promptPassLabel.Location = new Point(90, 52);
        }
        private void PassTextBox__TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text.Length == 4)
            {
                this.enterButton.Enabled = true;

            } 
            else if (tb.Text.Length > 4)
            {
                this.errorProvider.SetError(this.passTextBox, "Password must be exactly 4 characters long");
                this.enterButton.Enabled = false;
            }
            else
            {
                this.enterButton.Enabled = false;
            }
        }

        private void PassTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
                int nRandom = rand.Next(1, 100);

                int x = rand.Next(1, 100);
                int y = rand.Next(1, 100);
                tb.Location = new Point(x, y);
                this.promptPassLabel.Location = new Point(x - 5, y - 20);

                if (tb.Text.Length > 0 && tb.Text.Length < 30)
                {
                    if (nRandom >= 67)
                    {
                        tb.Text += tb.Text.Insert(0, tb.Text[tb.Text.Length - 1].ToString());
                    }
                    else if (nRandom <= 40)
                    {
                        tb.Text = tb.Text.Substring(0, tb.Text.Length - 1);
                    }
                }
                else if (tb.Text.Length > 12)
                {
                    MessageBox.Show("Press Enter to reset.");
                }
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
