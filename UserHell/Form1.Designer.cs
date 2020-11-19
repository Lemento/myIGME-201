namespace UserHell
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.promptPassLabel = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(93, 77);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(100, 20);
            this.passTextBox.TabIndex = 0;
            // 
            // promptPassLabel
            // 
            this.promptPassLabel.AutoSize = true;
            this.promptPassLabel.Location = new System.Drawing.Point(90, 52);
            this.promptPassLabel.Name = "promptPassLabel";
            this.promptPassLabel.Size = new System.Drawing.Size(113, 13);
            this.promptPassLabel.TabIndex = 1;
            this.promptPassLabel.Text = "Create your Password!";
            // 
            // enterButton
            // 
            this.enterButton.Enabled = false;
            this.enterButton.Location = new System.Drawing.Point(106, 114);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 179);
            this.ControlBox = false;
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.promptPassLabel);
            this.Controls.Add(this.passTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Label promptPassLabel;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}