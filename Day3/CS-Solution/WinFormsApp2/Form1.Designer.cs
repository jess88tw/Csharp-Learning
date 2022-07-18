namespace WinFormsApp2
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.lblAns = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(108, 302);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 104);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(108, 70);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(60, 30);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "A = ";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(242, 67);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(342, 38);
            this.txtA.TabIndex = 2;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(108, 144);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(58, 30);
            this.lblB.TabIndex = 3;
            this.lblB.Text = "B = ";
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Location = new System.Drawing.Point(108, 206);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(86, 30);
            this.lblAns.TabIndex = 4;
            this.lblAns.Text = "Ans = ";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(242, 141);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(342, 38);
            this.txtB.TabIndex = 5;
            // 
            // txtAns
            // 
            this.txtAns.Location = new System.Drawing.Point(242, 203);
            this.txtAns.Name = "txtAns";
            this.txtAns.Size = new System.Drawing.Size(342, 38);
            this.txtAns.TabIndex = 6;
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(242, 302);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(112, 104);
            this.btnSub.TabIndex = 7;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(379, 302);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(112, 104);
            this.btnMul.TabIndex = 8;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(519, 302);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(112, 104);
            this.btnDiv.TabIndex = 9;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 429);
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

        private Button btnAdd;
        private Label lblA;
        private TextBox txtA;
        private Label lblB;
        private Label lblAns;
        private TextBox txtB;
        private TextBox txtAns;
        private Button btnSub;
        private Button btnMul;
        private Button btnDiv;
    }
}