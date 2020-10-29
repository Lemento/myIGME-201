using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEditor
{
    public partial class MyEditorParent : Form
    {
        public MyEditorParent()
        {
            InitializeComponent();

            this.newToolStripMenuItem.Click += new EventHandler(NewToolStripMenuItem__Click);
            this.tileToolStripMenuItem.Click += new EventHandler(TileToolStripMenuItem__Click);
            this.cascadeToolStripMenuItem.Click += new EventHandler(CascadeToolStripMenuItem__Click);
            this.exitToolStripMenuItem.Click += new EventHandler(ExitToolStripMenuItem__Click);

            Form1 form1 = new Form1(this);
            form1.Show();
        }
        
        private void TileToolStripMenuItem__Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void CascadeToolStripMenuItem__Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void NewToolStripMenuItem__Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(this);
            form1.Show();
        }
        private void ExitToolStripMenuItem__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MyEditorParent_Load(object sender, EventArgs e)
        {

        }
    }
}
