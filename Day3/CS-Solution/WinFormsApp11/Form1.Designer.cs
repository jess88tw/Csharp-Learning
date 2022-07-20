namespace WinFormsApp11
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
            this.btnB = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(110, 115);
            this.btnB.Margin = new System.Windows.Forms.Padding(2);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(171, 62);
            this.btnB.TabIndex = 3;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(110, 31);
            this.btnA.Margin = new System.Windows.Forms.Padding(2);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(171, 62);
            this.btnA.TabIndex = 2;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 208);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnB;
        private Button btnA;
    }
}