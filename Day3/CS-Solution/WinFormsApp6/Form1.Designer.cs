namespace WinFormsApp6
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDog = new System.Windows.Forms.Button();
            this.btnCat = new System.Windows.Forms.Button();
            this.btnLion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(41, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnDog
            // 
            this.btnDog.Location = new System.Drawing.Point(517, 56);
            this.btnDog.Name = "btnDog";
            this.btnDog.Size = new System.Drawing.Size(150, 46);
            this.btnDog.TabIndex = 1;
            this.btnDog.Text = "Dog";
            this.btnDog.UseVisualStyleBackColor = true;
            this.btnDog.Click += new System.EventHandler(this.btnDog_Click);
            // 
            // btnCat
            // 
            this.btnCat.Location = new System.Drawing.Point(517, 147);
            this.btnCat.Name = "btnCat";
            this.btnCat.Size = new System.Drawing.Size(150, 46);
            this.btnCat.TabIndex = 2;
            this.btnCat.Text = "Cat";
            this.btnCat.UseVisualStyleBackColor = true;
            this.btnCat.Click += new System.EventHandler(this.btnCat_Click);
            // 
            // btnLion
            // 
            this.btnLion.Location = new System.Drawing.Point(517, 241);
            this.btnLion.Name = "btnLion";
            this.btnLion.Size = new System.Drawing.Size(150, 46);
            this.btnLion.TabIndex = 3;
            this.btnLion.Text = "Lion";
            this.btnLion.UseVisualStyleBackColor = true;
            this.btnLion.Click += new System.EventHandler(this.btnLion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 344);
            this.Controls.Add(this.btnLion);
            this.Controls.Add(this.btnCat);
            this.Controls.Add(this.btnDog);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnDog;
        private Button btnCat;
        private Button btnLion;
    }
}