namespace WinFormsApp9
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
            this.btnClick = new System.Windows.Forms.Button();
            this.btnAsk = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(113, 83);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(150, 46);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "Click me!";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // btnAsk
            // 
            this.btnAsk.Location = new System.Drawing.Point(113, 234);
            this.btnAsk.Name = "btnAsk";
            this.btnAsk.Size = new System.Drawing.Size(150, 46);
            this.btnAsk.TabIndex = 1;
            this.btnAsk.Text = "Ask";
            this.btnAsk.UseVisualStyleBackColor = true;
            this.btnAsk.Click += new System.EventHandler(this.btnAsk_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(319, 239);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(267, 38);
            this.txt1.TabIndex = 2;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(514, 349);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(150, 46);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 445);
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

        private Button btnClick;
        private Button btnAsk;
        private TextBox txt1;
        private Button btnQuit;
    }
}