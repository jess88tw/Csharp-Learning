namespace WinFormsApp09
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnQuit = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btnAsk = new System.Windows.Forms.Button();
            this.btnClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(240, 167);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(143, 113);
            this.txt1.Margin = new System.Windows.Forms.Padding(2);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(136, 23);
            this.txt1.TabIndex = 6;
            // 
            // btnAsk
            // 
            this.btnAsk.Location = new System.Drawing.Point(39, 110);
            this.btnAsk.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsk.Name = "btnAsk";
            this.btnAsk.Size = new System.Drawing.Size(75, 23);
            this.btnAsk.TabIndex = 5;
            this.btnAsk.Text = "Ask";
            this.btnAsk.UseVisualStyleBackColor = true;
            this.btnAsk.Click += new System.EventHandler(this.btnAsk_Click);
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(39, 35);
            this.btnClick.Margin = new System.Windows.Forms.Padding(2);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(75, 23);
            this.btnClick.TabIndex = 4;
            this.btnClick.Text = "Click me!";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 225);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btnAsk);
            this.Controls.Add(this.btnClick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnQuit;
        private TextBox txt1;
        private Button btnAsk;
        private Button btnClick;
    }
}