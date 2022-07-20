namespace WinFormsApp13
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
            this.picBox = new System.Windows.Forms.PictureBox();
            this.textData = new System.Windows.Forms.TextBox();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.White;
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox.Location = new System.Drawing.Point(33, 27);
            this.picBox.Margin = new System.Windows.Forms.Padding(2);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(358, 236);
            this.picBox.TabIndex = 9;
            this.picBox.TabStop = false;
            this.picBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseDown);
            this.picBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseMove);
            // 
            // textData
            // 
            this.textData.Location = new System.Drawing.Point(33, 273);
            this.textData.Margin = new System.Windows.Forms.Padding(2);
            this.textData.Name = "textData";
            this.textData.Size = new System.Drawing.Size(444, 23);
            this.textData.TabIndex = 8;
            // 
            // btnEllipse
            // 
            this.btnEllipse.Location = new System.Drawing.Point(400, 125);
            this.btnEllipse.Margin = new System.Windows.Forms.Padding(2);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(75, 23);
            this.btnEllipse.TabIndex = 7;
            this.btnEllipse.Text = "Ellipse";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Location = new System.Drawing.Point(400, 76);
            this.btnRectangle.Margin = new System.Windows.Forms.Padding(2);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(75, 23);
            this.btnRectangle.TabIndex = 6;
            this.btnRectangle.Text = "Rectange";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(400, 26);
            this.btnLine.Margin = new System.Windows.Forms.Padding(2);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(75, 23);
            this.btnLine.TabIndex = 5;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 323);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.textData);
            this.Controls.Add(this.btnEllipse);
            this.Controls.Add(this.btnRectangle);
            this.Controls.Add(this.btnLine);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picBox;
        private TextBox textData;
        private Button btnEllipse;
        private Button btnRectangle;
        private Button btnLine;
    }
}