namespace WinFormsApp06
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
            this.btnLion = new System.Windows.Forms.Button();
            this.btnCat = new System.Windows.Forms.Button();
            this.btnDog = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLion
            // 
            this.btnLion.Location = new System.Drawing.Point(376, 220);
            this.btnLion.Margin = new System.Windows.Forms.Padding(2);
            this.btnLion.Name = "btnLion";
            this.btnLion.Size = new System.Drawing.Size(75, 23);
            this.btnLion.TabIndex = 7;
            this.btnLion.Text = "Lion";
            this.btnLion.UseVisualStyleBackColor = true;
            this.btnLion.Click += new System.EventHandler(this.btnLion_Click);
            // 
            // btnCat
            // 
            this.btnCat.Location = new System.Drawing.Point(376, 174);
            this.btnCat.Margin = new System.Windows.Forms.Padding(2);
            this.btnCat.Name = "btnCat";
            this.btnCat.Size = new System.Drawing.Size(75, 23);
            this.btnCat.TabIndex = 6;
            this.btnCat.Text = "Cat";
            this.btnCat.UseVisualStyleBackColor = true;
            this.btnCat.Click += new System.EventHandler(this.btnCat_Click);
            // 
            // btnDog
            // 
            this.btnDog.Location = new System.Drawing.Point(376, 128);
            this.btnDog.Margin = new System.Windows.Forms.Padding(2);
            this.btnDog.Name = "btnDog";
            this.btnDog.Size = new System.Drawing.Size(75, 23);
            this.btnDog.TabIndex = 5;
            this.btnDog.Text = "Dog";
            this.btnDog.UseVisualStyleBackColor = true;
            this.btnDog.Click += new System.EventHandler(this.btnDog_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 254);
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

        private Button btnLion;
        private Button btnCat;
        private Button btnDog;
        private PictureBox pictureBox1;
    }
}