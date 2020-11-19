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
    public partial class UserInterface : Form
    {
        // System.Threading.Thread thread;
        Random rand = new Random();
        int tim = 0;
        string title = "UserInterface";

        public static Color[] color = new Color[]
        {
            System.Drawing.Color.RoyalBlue,
            System.Drawing.Color.AntiqueWhite,
            System.Drawing.Color.CadetBlue,
            System.Drawing.Color.DarkMagenta,
            System.Drawing.Color.Maroon,
            System.Drawing.Color.LightGoldenrodYellow,
            System.Drawing.Color.Gainsboro,
            System.Drawing.Color.LightSeaGreen,
            System.Drawing.Color.DeepPink,
            System.Drawing.Color.Wheat,
            System.Drawing.Color.OliveDrab,
            System.Drawing.Color.OrangeRed,
            System.Drawing.Color.RosyBrown
        };
        public static string password = null;

        public UserInterface()
        {
            InitializeComponent();

            this.splitContainer1.SplitterDistance = 600;

            this.radioButton1.CheckedChanged += new EventHandler(Button__Checked);
            this.radioButton2.CheckedChanged += new EventHandler(Button__Checked);
            this.passLabel.MouseEnter += new EventHandler(PassLabel__MouseEnter);
            this.passLabel.MouseLeave += new EventHandler(PassLabel__MouseLeave);

            this.enterButton.Click += new EventHandler(EnterButton__Click);
            this.timer.Tick += new EventHandler(Timer__Tick);
        }

        private void PassLabel__MouseEnter(object sender, EventArgs e)
        {
            timer.Stop();
        }
        private void PassLabel__MouseLeave(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void Button__Checked(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            switch (rb.Name)
            {
                case "radioButton1":
                    if (password == null)
                    {
                        Form1 form = new Form1();
                        form.ShowDialog();

                        this.passLabel.Visible = true;
                        this.passLabel.Text = "Your password is:" + password;
                        this.welcomeLabel.Location = new Point(20, welcomeLabel.Location.Y);
                        this.welcomeLabel.Text = "Now that you have made a password, be sure to keep it safe!";
                    }
                    else if (password != null)
                    {
                        this.errorProvider.SetError(rb, "Already Made a password");
                    }

                    break;

                case "radioButton2":
                    if (password == null)
                    {
                        this.errorProvider.SetError(this.radioButton2, "You need to have a password");
                    }
                    else if (password != null)
                    {
                        Form2 form2 = new Form2();
                        form2.Show();
                    }

                    break;
                default:
                    break;
            }
            
        }

        private void Button2__Checked(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (password == null)
            {
                this.errorProvider.SetError(rb, "Please create a password first");
            }
        }

        private void EnterButton__Click(object sender, EventArgs e)
        {

            timer.Start();
            this.splitContainer1.SplitterDistance = 400;

            ShakeUp();
        }

        private void ShakeUp()
        {
            string newTitle = "";

            this.splitContainer1.Panel1.BackColor = color[rand.Next(1, this.Text.Length)];
            this.splitContainer1.Panel2.BackColor = color[rand.Next(1, this.Text.Length)];
            this.passLabel.ForeColor = color[rand.Next(1, this.Text.Length)];
            this.label1.ForeColor = color[rand.Next(1, this.Text.Length)];

            int nRandom = rand.Next(1, this.Text.Length);
            for (int c = 0; c < this.Text.Length; c++)
            {
                if (c == nRandom)
                {
                    newTitle += "_";
                }
                else
                {
                    newTitle += title[c];
                }
            }

            this.Text = newTitle;
        }


        private void Timer__Tick(object sender, EventArgs e)
        {
            tim++;

            if (password != null)
            {
                this.passLabel.Location = new Point(((tim * 43) % 1200) - 600, this.passLabel.Location.Y);
            }
        }
    }
}
