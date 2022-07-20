namespace WinFormsApp08
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
            this.lblPoint = new System.Windows.Forms.Label();
            this.btnRoll = new System.Windows.Forms.Button();
            this.pct4 = new System.Windows.Forms.PictureBox();
            this.pct3 = new System.Windows.Forms.PictureBox();
            this.pct2 = new System.Windows.Forms.PictureBox();
            this.pct1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pct4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPoint.Location = new System.Drawing.Point(58, 189);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(34, 15);
            this.lblPoint.TabIndex = 16;
            this.lblPoint.Text = "點數:";
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(463, 189);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(117, 43);
            this.btnRoll.TabIndex = 15;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // pct4
            // 
            this.pct4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pct4.Location = new System.Drawing.Point(454, 47);
            this.pct4.Name = "pct4";
            this.pct4.Size = new System.Drawing.Size(126, 114);
            this.pct4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct4.TabIndex = 14;
            this.pct4.TabStop = false;
            // 
            // pct3
            // 
            this.pct3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pct3.Location = new System.Drawing.Point(322, 47);
            this.pct3.Name = "pct3";
            this.pct3.Size = new System.Drawing.Size(126, 114);
            this.pct3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct3.TabIndex = 13;
            this.pct3.TabStop = false;
            // 
            // pct2
            // 
            this.pct2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pct2.Location = new System.Drawing.Point(190, 47);
            this.pct2.Name = "pct2";
            this.pct2.Size = new System.Drawing.Size(126, 114);
            this.pct2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct2.TabIndex = 12;
            this.pct2.TabStop = false;
            // 
            // pct1
            // 
            this.pct1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pct1.Location = new System.Drawing.Point(58, 47);
            this.pct1.Name = "pct1";
            this.pct1.Size = new System.Drawing.Size(126, 114);
            this.pct1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct1.TabIndex = 11;
            this.pct1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(638, 272);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.pct4);
            this.Controls.Add(this.pct3);
            this.Controls.Add(this.pct2);
            this.Controls.Add(this.pct1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pct4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPoint;
        private Button btnRoll;
        private PictureBox pct4;
        private PictureBox pct3;
        private PictureBox pct2;
        private PictureBox pct1;
    }
}