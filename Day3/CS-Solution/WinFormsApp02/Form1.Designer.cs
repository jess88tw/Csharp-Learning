namespace WinFormsApp02
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
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblAns = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(286, 142);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(2);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(56, 52);
            this.btnDiv.TabIndex = 19;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(216, 142);
            this.btnMul.Margin = new System.Windows.Forms.Padding(2);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(56, 52);
            this.btnMul.TabIndex = 18;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(147, 142);
            this.btnSub.Margin = new System.Windows.Forms.Padding(2);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(56, 52);
            this.btnSub.TabIndex = 17;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // txtAns
            // 
            this.txtAns.Location = new System.Drawing.Point(147, 93);
            this.txtAns.Margin = new System.Windows.Forms.Padding(2);
            this.txtAns.Name = "txtAns";
            this.txtAns.Size = new System.Drawing.Size(173, 23);
            this.txtAns.TabIndex = 16;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(147, 61);
            this.txtB.Margin = new System.Windows.Forms.Padding(2);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(173, 23);
            this.txtB.TabIndex = 15;
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Location = new System.Drawing.Point(80, 94);
            this.lblAns.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(42, 15);
            this.lblAns.TabIndex = 14;
            this.lblAns.Text = "Ans = ";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(80, 63);
            this.lblB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(29, 15);
            this.lblB.TabIndex = 13;
            this.lblB.Text = "B = ";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(147, 25);
            this.txtA.Margin = new System.Windows.Forms.Padding(2);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(173, 23);
            this.txtA.TabIndex = 12;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(80, 26);
            this.lblA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(30, 15);
            this.lblA.TabIndex = 11;
            this.lblA.Text = "A = ";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(80, 142);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 52);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 218);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.txtAns);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDiv;
        private Button btnMul;
        private Button btnSub;
        private TextBox txtAns;
        private TextBox txtB;
        private Label lblAns;
        private Label lblB;
        private TextBox txtA;
        private Label lblA;
        private Button btnAdd;
    }
}