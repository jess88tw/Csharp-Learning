namespace WinFormsApp15
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtASCII = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtUpper = new System.Windows.Forms.TextBox();
            this.lblUpper = new System.Windows.Forms.Label();
            this.lblLower = new System.Windows.Forms.Label();
            this.txtLower = new System.Windows.Forms.TextBox();
            this.lblDigit = new System.Windows.Forms.Label();
            this.txtDigit = new System.Windows.Forms.TextBox();
            this.lblLetter = new System.Windows.Forms.Label();
            this.txtLetter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(24, 20);
            this.txtA.Margin = new System.Windows.Forms.Padding(2);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(287, 23);
            this.txtA.TabIndex = 0;
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // txtASCII
            // 
            this.txtASCII.Location = new System.Drawing.Point(24, 50);
            this.txtASCII.Margin = new System.Windows.Forms.Padding(2);
            this.txtASCII.Name = "txtASCII";
            this.txtASCII.Size = new System.Drawing.Size(102, 23);
            this.txtASCII.TabIndex = 1;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(24, 118);
            this.txtCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(102, 23);
            this.txtCode.TabIndex = 3;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(24, 88);
            this.txtB.Margin = new System.Windows.Forms.Padding(2);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(287, 23);
            this.txtB.TabIndex = 2;
            this.txtB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtB_KeyDown);
            // 
            // txtUpper
            // 
            this.txtUpper.Location = new System.Drawing.Point(78, 177);
            this.txtUpper.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpper.Name = "txtUpper";
            this.txtUpper.Size = new System.Drawing.Size(102, 23);
            this.txtUpper.TabIndex = 4;
            this.txtUpper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpper_KeyPress);
            // 
            // lblUpper
            // 
            this.lblUpper.AutoSize = true;
            this.lblUpper.Location = new System.Drawing.Point(26, 178);
            this.lblUpper.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpper.Name = "lblUpper";
            this.lblUpper.Size = new System.Drawing.Size(43, 15);
            this.lblUpper.TabIndex = 5;
            this.lblUpper.Text = "Upper";
            // 
            // lblLower
            // 
            this.lblLower.AutoSize = true;
            this.lblLower.Location = new System.Drawing.Point(26, 215);
            this.lblLower.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLower.Name = "lblLower";
            this.lblLower.Size = new System.Drawing.Size(41, 15);
            this.lblLower.TabIndex = 7;
            this.lblLower.Text = "Lower";
            // 
            // txtLower
            // 
            this.txtLower.Location = new System.Drawing.Point(78, 214);
            this.txtLower.Margin = new System.Windows.Forms.Padding(2);
            this.txtLower.Name = "txtLower";
            this.txtLower.Size = new System.Drawing.Size(102, 23);
            this.txtLower.TabIndex = 6;
            this.txtLower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLower_KeyPress);
            // 
            // lblDigit
            // 
            this.lblDigit.AutoSize = true;
            this.lblDigit.Location = new System.Drawing.Point(26, 252);
            this.lblDigit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDigit.Name = "lblDigit";
            this.lblDigit.Size = new System.Drawing.Size(32, 15);
            this.lblDigit.TabIndex = 9;
            this.lblDigit.Text = "1 - 9";
            // 
            // txtDigit
            // 
            this.txtDigit.Location = new System.Drawing.Point(78, 251);
            this.txtDigit.Margin = new System.Windows.Forms.Padding(2);
            this.txtDigit.Name = "txtDigit";
            this.txtDigit.Size = new System.Drawing.Size(102, 23);
            this.txtDigit.TabIndex = 8;
            this.txtDigit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDigit_KeyPress);
            // 
            // lblLetter
            // 
            this.lblLetter.AutoSize = true;
            this.lblLetter.Location = new System.Drawing.Point(26, 286);
            this.lblLetter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLetter.Name = "lblLetter";
            this.lblLetter.Size = new System.Drawing.Size(33, 15);
            this.lblLetter.TabIndex = 11;
            this.lblLetter.Text = "A - Z";
            // 
            // txtLetter
            // 
            this.txtLetter.Location = new System.Drawing.Point(78, 285);
            this.txtLetter.Margin = new System.Windows.Forms.Padding(2);
            this.txtLetter.Name = "txtLetter";
            this.txtLetter.Size = new System.Drawing.Size(102, 23);
            this.txtLetter.TabIndex = 10;
            this.txtLetter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetter_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 368);
            this.Controls.Add(this.lblLetter);
            this.Controls.Add(this.txtLetter);
            this.Controls.Add(this.lblDigit);
            this.Controls.Add(this.txtDigit);
            this.Controls.Add(this.lblLower);
            this.Controls.Add(this.txtLower);
            this.Controls.Add(this.lblUpper);
            this.Controls.Add(this.txtUpper);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtASCII);
            this.Controls.Add(this.txtA);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtA;
        private TextBox txtASCII;
        private TextBox txtCode;
        private TextBox txtB;
        private TextBox txtUpper;
        private Label lblUpper;
        private Label lblLower;
        private TextBox txtLower;
        private Label lblDigit;
        private TextBox txtDigit;
        private Label lblLetter;
        private TextBox txtLetter;
    }
}