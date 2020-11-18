using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presidents
{
    public partial class Form1 : Form
    {
        System.Drawing.Image img;
        string wikiLink = "https://en.m.wikipedia.org/wiki/";
        bool[] pA = new bool[16];


        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < pA.Length; i++)
            {
                pA[i] = false;
            }

            this.bhRadioButton.CheckedChanged += new EventHandler(this.PresidentsRadioButton__CheckChanged);
            this.fdrRadioButton.CheckedChanged += new EventHandler(this.PresidentsRadioButton__CheckChanged);
            this.wjcRadioButton.CheckedChanged += new EventHandler(this.PresidentsRadioButton__CheckChanged);
            this.jbRadioButton.CheckedChanged += new EventHandler(this.PresidentsRadioButton__CheckChanged);
            this.fpRadioButton.CheckedChanged += new EventHandler(this.PresidentsRadioButton__CheckChanged);
            this.gwbRadioButton.CheckedChanged += new EventHandler(this.PresidentsRadioButton__CheckChanged);
            this.boRadioButton.CheckedChanged += new EventHandler(this.PresidentsRadioButton__CheckChanged);
            this.jfkRadioButton.CheckedChanged += new EventHandler(this.PresidentsRadioButton__CheckChanged);
            this.wmkRadioButton.CheckedChanged += new EventHandler(this.PresidentsRadioButton__CheckChanged);
            this.rrRadioButton.CheckedChanged += new EventHandler(this.PresidentsRadioButton__CheckChanged);
            this.ddeRadioButton.CheckedChanged += new EventHandler(this.PresidentsRadioButton__CheckChanged);
            this.mvbRadioButton.CheckedChanged += new EventHandler(this.PresidentsRadioButton__CheckChanged);
            this.gwRadioButton.CheckedChanged += new EventHandler(this.PresidentsRadioButton__CheckChanged);
            this.jaRadioButton.CheckedChanged += new EventHandler(this.PresidentsRadioButton__CheckChanged);
            this.trRadioButton.CheckedChanged += new EventHandler(this.PresidentsRadioButton__CheckChanged);
            this.tjRadioButton.CheckedChanged += new EventHandler(this.PresidentsRadioButton__CheckChanged);

            this.pictureBox.MouseEnter += new EventHandler(this.GrowImage);
            this.pictureBox.MouseLeave += new EventHandler(this.ShrinkImage);

            webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Navigate(wikiLink);

            this.allRadioButton.CheckedChanged += new EventHandler(this.FilterRadioButton__CheckChanged);
            this.democratRadioButton.CheckedChanged += new EventHandler(this.FilterRadioButton__CheckChanged);
            this.republicanRadioButton.CheckedChanged += new EventHandler(this.FilterRadioButton__CheckChanged);
            this.demrepRadioButton.CheckedChanged += new EventHandler(this.FilterRadioButton__CheckChanged);
            this.fedRadioButton.CheckedChanged += new EventHandler(this.FilterRadioButton__CheckChanged);

            this.bhTextBox.Validating += new CancelEventHandler(this.TextBox__Validating);
            this.fdrTextBox.Validating += new CancelEventHandler(this.TextBox__Validating);
            this.wjcTextBox.Validating += new CancelEventHandler(this.TextBox__Validating);
            this.jbTextBox.Validating += new CancelEventHandler(this.TextBox__Validating);
            this.fpTextBox.Validating += new CancelEventHandler(this.TextBox__Validating);
            this.gwbTextBox.Validating += new CancelEventHandler(this.TextBox__Validating);
            this.boTextBox.Validating += new CancelEventHandler(this.TextBox__Validating);
            this.jfkTextBox.Validating += new CancelEventHandler(this.TextBox__Validating);
            this.wmkTextBox.Validating += new CancelEventHandler(this.TextBox__Validating);
            this.rrTextBox.Validating += new CancelEventHandler(this.TextBox__Validating);
            this.ddeTextBox.Validating += new CancelEventHandler(this.TextBox__Validating);
            this.mvbTextBox.Validating += new CancelEventHandler(this.TextBox__Validating);
            this.gwTextBox.Validating += new CancelEventHandler(this.TextBox__Validating);
            this.jaTextBox.Validating += new CancelEventHandler(this.TextBox__Validating);
            this.trTextBox.Validating += new CancelEventHandler(this.TextBox__Validating);
            this.tjTextBox.Validating += new CancelEventHandler(this.TextBox__Validating);

            this.bhTextBox.TextChanged += new EventHandler(this.TextBox__TextChanged);
            this.fdrTextBox.TextChanged += new EventHandler(this.TextBox__TextChanged);
            this.wjcTextBox.TextChanged += new EventHandler(this.TextBox__TextChanged);
            this.jbTextBox.TextChanged += new EventHandler(this.TextBox__TextChanged);
            this.fpTextBox.TextChanged += new EventHandler(this.TextBox__TextChanged);
            this.gwbTextBox.TextChanged += new EventHandler(this.TextBox__TextChanged);
            this.boTextBox.TextChanged += new EventHandler(this.TextBox__TextChanged);
            this.jfkTextBox.TextChanged += new EventHandler(this.TextBox__TextChanged);
            this.wmkTextBox.TextChanged += new EventHandler(this.TextBox__TextChanged);
            this.rrTextBox.TextChanged += new EventHandler(this.TextBox__TextChanged);
            this.ddeTextBox.TextChanged += new EventHandler(this.TextBox__TextChanged);
            this.mvbTextBox.TextChanged += new EventHandler(this.TextBox__TextChanged);
            this.gwTextBox.TextChanged += new EventHandler(this.TextBox__TextChanged);
            this.jaTextBox.TextChanged += new EventHandler(this.TextBox__TextChanged);
            this.trTextBox.TextChanged += new EventHandler(this.TextBox__TextChanged);
            this.tjTextBox.TextChanged += new EventHandler(this.TextBox__TextChanged);

            this.bhTextBox.KeyPress += new KeyPressEventHandler(this.TextBox__KeyPress);
            this.fdrTextBox.KeyPress += new KeyPressEventHandler(this.TextBox__KeyPress);
            this.wjcTextBox.KeyPress += new KeyPressEventHandler(this.TextBox__KeyPress);
            this.jbTextBox.KeyPress += new KeyPressEventHandler(this.TextBox__KeyPress);
            this.fpTextBox.KeyPress += new KeyPressEventHandler(this.TextBox__KeyPress);
            this.gwbTextBox.KeyPress += new KeyPressEventHandler(this.TextBox__KeyPress);
            this.boTextBox.KeyPress += new KeyPressEventHandler(this.TextBox__KeyPress);
            this.jfkTextBox.KeyPress += new KeyPressEventHandler(this.TextBox__KeyPress);
            this.wmkTextBox.KeyPress += new KeyPressEventHandler(this.TextBox__KeyPress);
            this.rrTextBox.KeyPress += new KeyPressEventHandler(this.TextBox__KeyPress);
            this.ddeTextBox.KeyPress += new KeyPressEventHandler(this.TextBox__KeyPress);
            this.mvbTextBox.KeyPress += new KeyPressEventHandler(this.TextBox__KeyPress);
            this.gwTextBox.KeyPress += new KeyPressEventHandler(this.TextBox__KeyPress);
            this.jaTextBox.KeyPress += new KeyPressEventHandler(this.TextBox__KeyPress);
            this.trTextBox.KeyPress += new KeyPressEventHandler(this.TextBox__KeyPress);
            this.tjTextBox.KeyPress += new KeyPressEventHandler(this.TextBox__KeyPress);

            this.exitButton.Click += new EventHandler(this.ExitButton__Click);

            this.toolStripProgressBar.Value = this.toolStripProgressBar.Maximum;
            this.timer.Tick += new EventHandler(Timer__Tick);

        }


        private void PresidentsRadioButton__CheckChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            PresidentsImage(rb);

            string url = wikiLink + rb.Text.Replace(' ', '_');
            this.webBrowser1.Navigate(url);
            this.wikiGroupBox.Text = url;
        }


        private void PresidentsImage(RadioButton rb)
        {
            img = GetImageFromUrl("http://people.rit.edu/dxsigm/" + rb.Text.Replace(" ", ""));

            this.pictureBox.Size = new Size(img.Width / 4, img.Height / 4);
            this.pictureBox.Image = img;

        }

        public Image GetImageFromUrl(string url)
        {
            System.Drawing.Image image = null;

            try
            {
                try
                {
                    System.Net.HttpWebRequest webRequest = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(url + ".jpeg");
                    webRequest.AllowWriteStreamBuffering = true;
                    webRequest.Timeout = 30000;

                    System.Net.WebResponse webResponse = webRequest.GetResponse();

                    System.IO.Stream stream = webResponse.GetResponseStream();

                    image = System.Drawing.Image.FromStream(stream);

                    webResponse.Close();
                }
                catch
                {
                    System.Net.HttpWebRequest webRequest = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(url + ".png");
                    webRequest.AllowWriteStreamBuffering = true;
                    webRequest.Timeout = 30000;

                    System.Net.WebResponse webResponse = webRequest.GetResponse();

                    System.IO.Stream stream = webResponse.GetResponseStream();

                    image = System.Drawing.Image.FromStream(stream);

                    webResponse.Close();
                }
            }
            catch (Exception ex)
            {
                return null;
            }

            return image;
        }

        private void GrowImage(object sender, EventArgs e)
        {
            this.pictureBox.Size = new Size(this.pictureBox.Width * 2, this.pictureBox.Height * 2);
        }
        private void ShrinkImage(object sender, EventArgs e)
        {
            this.pictureBox.Size = new Size(this.pictureBox.Width / 2, this.pictureBox.Height / 2);
        }

        
        private void FilterRadioButton__CheckChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            switch (rb.Text)
            {
                case "All":
                    this.bhRadioButton.Visible = true;
                    this.fdrRadioButton.Visible = true;
                    this.wjcRadioButton.Visible = true;
                    this.jbRadioButton.Visible = true;
                    this.fpRadioButton.Visible = true;
                    this.gwbRadioButton.Visible = true;
                    this.boRadioButton.Visible = true;
                    this.jfkRadioButton.Visible = true;
                    this.wmkRadioButton.Visible = true;
                    this.rrRadioButton.Visible = true;
                    this.ddeRadioButton.Visible = true;
                    this.mvbRadioButton.Visible = true;
                    this.gwRadioButton.Visible = true;
                    this.jaRadioButton.Visible = true;
                    this.trRadioButton.Visible = true;
                    this.tjRadioButton.Visible = true;

                    this.bhRadioButton.Checked = true;
                    break;

                case "Democrat":
                    this.bhRadioButton.Visible = false;
                    this.fdrRadioButton.Visible = true;
                    this.wjcRadioButton.Visible = true;
                    this.jbRadioButton.Visible = true;
                    this.fpRadioButton.Visible = true;
                    this.gwbRadioButton.Visible = false;
                    this.boRadioButton.Visible = true;
                    this.jfkRadioButton.Visible = true;
                    this.wmkRadioButton.Visible = false;
                    this.rrRadioButton.Visible = false;
                    this.ddeRadioButton.Visible = false;
                    this.mvbRadioButton.Visible = true;
                    this.gwRadioButton.Visible = false;
                    this.jaRadioButton.Visible = false;
                    this.trRadioButton.Visible = false;
                    this.tjRadioButton.Visible = false;

                    this.fdrRadioButton.Checked = true;
                    break;

                case "Republican":
                    this.bhRadioButton.Visible = true;
                    this.fdrRadioButton.Visible = false;
                    this.wjcRadioButton.Visible = false;
                    this.jbRadioButton.Visible = false;
                    this.fpRadioButton.Visible = false;
                    this.gwbRadioButton.Visible = true;
                    this.boRadioButton.Visible = false;
                    this.jfkRadioButton.Visible = false;
                    this.wmkRadioButton.Visible = true;
                    this.rrRadioButton.Visible = true;
                    this.ddeRadioButton.Visible = true;
                    this.mvbRadioButton.Visible = false;
                    this.gwRadioButton.Visible = false;
                    this.jaRadioButton.Visible = false;
                    this.trRadioButton.Visible = true;
                    this.tjRadioButton.Visible = false;

                    this.bhRadioButton.Checked = true;
                    break;

                case "Democratic-Republican":
                    this.bhRadioButton.Visible = false;
                    this.fdrRadioButton.Visible = false;
                    this.wjcRadioButton.Visible = false;
                    this.jbRadioButton.Visible = false;
                    this.fpRadioButton.Visible = false;
                    this.gwbRadioButton.Visible = false;
                    this.boRadioButton.Visible = false;
                    this.jfkRadioButton.Visible = false;
                    this.wmkRadioButton.Visible = false;
                    this.rrRadioButton.Visible = false;
                    this.ddeRadioButton.Visible = false;
                    this.mvbRadioButton.Visible = false;
                    this.gwRadioButton.Visible = false;
                    this.jaRadioButton.Visible = false;
                    this.trRadioButton.Visible = false;
                    this.tjRadioButton.Visible = true;

                    this.tjRadioButton.Checked = true;
                    break;

                case "Federalist":
                    this.bhRadioButton.Visible = false;
                    this.fdrRadioButton.Visible = false;
                    this.wjcRadioButton.Visible = false;
                    this.jbRadioButton.Visible = false;
                    this.fpRadioButton.Visible = false;
                    this.gwbRadioButton.Visible = false;
                    this.boRadioButton.Visible = false;
                    this.jfkRadioButton.Visible = false;
                    this.wmkRadioButton.Visible = false;
                    this.rrRadioButton.Visible = false;
                    this.ddeRadioButton.Visible = false;
                    this.mvbRadioButton.Visible = false;
                    this.gwRadioButton.Visible = true;
                    this.jaRadioButton.Visible = true;
                    this.trRadioButton.Visible = false;
                    this.tjRadioButton.Visible = false;

                    this.gwRadioButton.Checked = true;
                    break;

                default:
                    break;

            }
        }

        private void TextBox__KeyPress(object sender, KeyPressEventArgs e)
        {

            TextBox tb = (TextBox)sender;

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void TextBox__TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (!timer.Enabled)
            {
                timer.Start();
            }
        }

        private void TextBox__Validating(object sender, CancelEventArgs e) 
        {
            TextBox tb = (TextBox)sender;
            
            if (!timer.Enabled || TextBoxAnswer(tb.Name.Replace("TextBox", ""), tb.Text))
            {
                e.Cancel = false;
                tb.Tag = true;
            }
            else
            {
                e.Cancel = true;
                tb.Tag = false;
            }
        }


        private bool TextBoxAnswer(string pres, string answer)
        {
            switch (pres)
            {
                case "bh": if (answer == "23") { pA[0] = true; return true; } break;
                case "fdr": if (answer =="32") { pA[1] = true; return true; } break;
                case "wjc": if (answer == "42") { pA[2] = true; return true; } break;
                case "jb": if (answer == "15") { pA[3] = true; return true; } break; 
                case "fp": if (answer == "14") { pA[4] = true; return true; } break; 
                case "gwb": if (answer == "43") { pA[5] = true; return true; } break;
                case "bo": if (answer == "44") { pA[6] = true; return true; } break; 
                case "jfk": if (answer == "35") { pA[7] = true; return true; } break;
                case "wmk": if (answer == "25") { pA[8] = true; return true; } break;
                case "rr": if (answer == "40") { pA[9] = true; return true; } break; 
                case "dde": if (answer == "34") { pA[10] = true; return true; } break;
                case "mvb": if (answer == "8") { pA[11] = true; return true; } break; 
                case "gw": if (answer == "1") { pA[12] = true; return true; } break; 
                case "ja": if (answer == "2") { pA[13] = true; return true; } break; 
                case "tr": if (answer == "26") { pA[14] = true; return true; } break; 
                case "tj": if (answer == "3") { pA[15] = true; return true; } break; 
            };

            return false;
        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            --this.toolStripProgressBar.Value;


            if (this.toolStripProgressBar.Value == 0)
            {
                this.timer.Stop();
                this.toolStripProgressBar.Value = this.toolStripProgressBar.Maximum;
                exitButton.Enabled = true;
            }
            else if (CheckForWin())
            {
                timer.Stop();
                this.toolStripProgressBar.Value = this.toolStripProgressBar.Maximum;
                this.exitButton.Enabled = true;
                this.webBrowser1.Navigate("https://www.youtube.com/watch?v=18212B4yfLg");
            }
        }
        private bool CheckForWin()
        {
            for (int i = 0; i < 16; i++)
            {
                if (!pA[i]) return false;
            }

            return true;
        }


        private void ExitButton__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
