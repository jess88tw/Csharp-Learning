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
            this.lblLetter = new System.Windows.Forms.Label();
            this.txtLetter = new System.Windows.Forms.TextBox();
            this.lblDigit = new System.Windows.Forms.Label();
            this.txtDigit = new System.Windows.Forms.TextBox();
            this.lblLower = new System.Windows.Forms.Label();
            this.txtLower = new System.Windows.Forms.TextBox();
            this.lblUpper = new System.Windows.Forms.Label();
            this.txtUpper = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtASCII = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLetter
            // 
            this.lblLetter.AutoSize = true;
            this.lblLetter.Location = new System.Drawing.Point(35, 293);
            this.lblLetter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLetter.Name = "lblLetter";
            this.lblLetter.Size = new System.Drawing.Size(33, 15);
            this.lblLetter.TabIndex = 23;
            this.lblLetter.Text = "A - Z";
            // 
            // txtLetter
            // 
            this.txtLetter.Location = new System.Drawing.Point(87, 292);
            this.txtLetter.Margin = new System.Windows.Forms.Padding(2);
            this.txtLetter.Name = "txtLetter";
            this.txtLetter.Size = new System.Drawing.Size(102, 23);
            this.txtLetter.TabIndex = 22;
            this.txtLetter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetter_KeyPress);
            // 
            // lblDigit
            // 
            this.lblDigit.AutoSize = true;
            this.lblDigit.Location = new System.Drawing.Point(35, 259);
            this.lblDigit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDigit.Name = "lblDigit";
            this.lblDigit.Size = new System.Drawing.Size(32, 15);
            this.lblDigit.TabIndex = 21;
            this.lblDigit.Text = "1 - 9";
            // 
            // txtDigit
            // 
            this.txtDigit.Location = new System.Drawing.Point(87, 258);
            this.txtDigit.Margin = new System.Windows.Forms.Padding(2);
            this.txtDigit.Name = "txtDigit";
            this.txtDigit.Size = new System.Drawing.Size(102, 23);
            this.txtDigit.TabIndex = 20;
            this.txtDigit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDigit_KeyPress);
            // 
            // lblLower
            // 
            this.lblLower.AutoSize = true;
            this.lblLower.Location = new System.Drawing.Point(35, 222);
            this.lblLower.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLower.Name = "lblLower";
            this.lblLower.Size = new System.Drawing.Size(41, 15);
            this.lblLower.TabIndex = 19;
            this.lblLower.Text = "Lower";
            // 
            // txtLower
            // 
            this.txtLower.Location = new System.Drawing.Point(87, 221);
            this.txtLower.Margin = new System.Windows.Forms.Padding(2);
            this.txtLower.Name = "txtLower";
            this.txtLower.Size = new System.Drawing.Size(102, 23);
            this.txtLower.TabIndex = 18;
            this.txtLower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLower_KeyPress);
            // 
            // lblUpper
            // 
            this.lblUpper.AutoSize = true;
            this.lblUpper.Location = new System.Drawing.Point(35, 185);
            this.lblUpper.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpper.Name = "lblUpper";
            this.lblUpper.Size = new System.Drawing.Size(43, 15);
            this.lblUpper.TabIndex = 17;
            this.lblUpper.Text = "Upper";
            // 
            // txtUpper
            // 
            this.txtUpper.Location = new System.Drawing.Point(87, 184);
            this.txtUpper.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpper.Name = "txtUpper";
            this.txtUpper.Size = new System.Drawing.Size(102, 23);
            this.txtUpper.TabIndex = 16;
            this.txtUpper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpper_KeyPress);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(33, 125);
            this.txtCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(102, 23);
            this.txtCode.TabIndex = 15;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(33, 95);
            this.txtB.Margin = new System.Windows.Forms.Padding(2);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(287, 23);
            this.txtB.TabIndex = 14;
            this.txtB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtB_KeyDown);
            // 
            // txtASCII
            // 
            this.txtASCII.Location = new System.Drawing.Point(33, 57);
            this.txtASCII.Margin = new System.Windows.Forms.Padding(2);
            this.txtASCII.Name = "txtASCII";
            this.txtASCII.Size = new System.Drawing.Size(102, 23);
            this.txtASCII.TabIndex = 13;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(33, 27);
            this.txtA.Margin = new System.Windows.Forms.Padding(2);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(287, 23);
            this.txtA.TabIndex = 12;
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 343);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblLetter;
        private TextBox txtLetter;
        private Label lblDigit;
        private TextBox txtDigit;
        private Label lblLower;
        private TextBox txtLower;
        private Label lblUpper;
        private TextBox txtUpper;
        private TextBox txtCode;
        private TextBox txtB;
        private TextBox txtASCII;
        private TextBox txtA;
    }
}