namespace WinFormsApp14
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
            this.chkSame = new System.Windows.Forms.CheckBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkSame
            // 
            this.chkSame.AutoSize = true;
            this.chkSame.Location = new System.Drawing.Point(48, 75);
            this.chkSame.Margin = new System.Windows.Forms.Padding(2);
            this.chkSame.Name = "chkSame";
            this.chkSame.Size = new System.Drawing.Size(50, 19);
            this.chkSame.TabIndex = 5;
            this.chkSame.Text = "同上";
            this.chkSame.UseVisualStyleBackColor = true;
            this.chkSame.CheckedChanged += new System.EventHandler(this.chkSame_CheckStateChanged);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(48, 95);
            this.txtB.Margin = new System.Windows.Forms.Padding(2);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(266, 23);
            this.txtB.TabIndex = 4;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(48, 35);
            this.txtA.Margin = new System.Windows.Forms.Padding(2);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(266, 23);
            this.txtA.TabIndex = 3;
            this.txtA.TextChanged += new System.EventHandler(this.chkSame_CheckStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 153);
            this.Controls.Add(this.chkSame);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox chkSame;
        private TextBox txtB;
        private TextBox txtA;
    }
}