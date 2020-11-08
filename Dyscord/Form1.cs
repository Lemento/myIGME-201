using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dyscord
{
    public partial class SettingsForm : Form
    {
        public int myPort;

        public SettingsForm(Form owner, int nPort)
        {
            InitializeComponent();

            this.Owner = owner;
            this.CenterToParent();
            this.myPort = nPort;
            this.portTextBox.Text = nPort.ToString();
            this.startButton.Click += new EventHandler(StartButton__Click);
            this.portTextBox.KeyPress += new KeyPressEventHandler(PortTextBox__KeyPress);

        }

        private void StartButton__Click(object sender, EventArgs e)
        {
            this.myPort = Int32.Parse(this.portTextBox.Text);
            this.Close();
        }

        private void PortTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if( Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
