namespace UserHell
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lastNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.moneyColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ageColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.updateButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.updateButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(292, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 450);
            this.panel2.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lastNameColumnHeader,
            this.firstNameColumnHeader,
            this.moneyColumnHeader,
            this.ageColumnHeader});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(286, 450);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // lastNameColumnHeader
            // 
            this.lastNameColumnHeader.DisplayIndex = 2;
            this.lastNameColumnHeader.Text = "Last Name";
            this.lastNameColumnHeader.Width = 100;
            // 
            // firstNameColumnHeader
            // 
            this.firstNameColumnHeader.DisplayIndex = 0;
            this.firstNameColumnHeader.Text = "First Name";
            this.firstNameColumnHeader.Width = 100;
            // 
            // moneyColumnHeader
            // 
            this.moneyColumnHeader.DisplayIndex = 1;
            this.moneyColumnHeader.Text = "$";
            this.moneyColumnHeader.Width = 40;
            // 
            // ageColumnHeader
            // 
            this.ageColumnHeader.Text = "Age";
            this.ageColumnHeader.Width = 40;
            // 
            // updateButton
            // 
            this.updateButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.updateButton.Enabled = false;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(0, 0);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(112, 450);
            this.updateButton.TabIndex = 0;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader lastNameColumnHeader;
        private System.Windows.Forms.ColumnHeader firstNameColumnHeader;
        private System.Windows.Forms.ColumnHeader moneyColumnHeader;
        private System.Windows.Forms.ColumnHeader ageColumnHeader;
        private System.Windows.Forms.Button updateButton;
    }
}