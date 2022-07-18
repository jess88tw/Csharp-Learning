namespace WinFormsApp5
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
            this.rdoNo1 = new System.Windows.Forms.RadioButton();
            this.rdoNo2 = new System.Windows.Forms.RadioButton();
            this.rdoNo3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnData = new System.Windows.Forms.Button();
            this.chkCream = new System.Windows.Forms.CheckBox();
            this.chkPie = new System.Windows.Forms.CheckBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoNo1
            // 
            this.rdoNo1.AutoSize = true;
            this.rdoNo1.Location = new System.Drawing.Point(41, 49);
            this.rdoNo1.Name = "rdoNo1";
            this.rdoNo1.Size = new System.Drawing.Size(136, 34);
            this.rdoNo1.TabIndex = 0;
            this.rdoNo1.TabStop = true;
            this.rdoNo1.Text = "No1(95)";
            this.rdoNo1.UseVisualStyleBackColor = true;
            // 
            // rdoNo2
            // 
            this.rdoNo2.AutoSize = true;
            this.rdoNo2.Location = new System.Drawing.Point(41, 89);
            this.rdoNo2.Name = "rdoNo2";
            this.rdoNo2.Size = new System.Drawing.Size(150, 34);
            this.rdoNo2.TabIndex = 1;
            this.rdoNo2.TabStop = true;
            this.rdoNo2.Text = "No2(105)";
            this.rdoNo2.UseVisualStyleBackColor = true;
            // 
            // rdoNo3
            // 
            this.rdoNo3.AutoSize = true;
            this.rdoNo3.Location = new System.Drawing.Point(41, 129);
            this.rdoNo3.Name = "rdoNo3";
            this.rdoNo3.Size = new System.Drawing.Size(150, 34);
            this.rdoNo3.TabIndex = 2;
            this.rdoNo3.TabStop = true;
            this.rdoNo3.Text = "No3(120)";
            this.rdoNo3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoNo3);
            this.groupBox1.Controls.Add(this.rdoNo2);
            this.groupBox1.Controls.Add(this.rdoNo1);
            this.groupBox1.Location = new System.Drawing.Point(129, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 192);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "餐點";
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(170, 480);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(167, 46);
            this.btnData.TabIndex = 0;
            this.btnData.Text = "計算";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkCream
            // 
            this.chkCream.AutoSize = true;
            this.chkCream.Location = new System.Drawing.Point(170, 272);
            this.chkCream.Name = "chkCream";
            this.chkCream.Size = new System.Drawing.Size(202, 34);
            this.chkCream.TabIndex = 10;
            this.chkCream.Text = "Ice Cream(15)";
            this.chkCream.UseVisualStyleBackColor = true;
            // 
            // chkPie
            // 
            this.chkPie.AutoSize = true;
            this.chkPie.Location = new System.Drawing.Point(170, 325);
            this.chkPie.Name = "chkPie";
            this.chkPie.Size = new System.Drawing.Size(196, 34);
            this.chkPie.TabIndex = 11;
            this.chkPie.Text = "Apple Pie(25)";
            this.chkPie.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(129, 405);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(61, 30);
            this.lblResult.TabIndex = 12;
            this.lblResult.Text = "小計";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(196, 402);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(210, 38);
            this.txtResult.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 569);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.chkPie);
            this.Controls.Add(this.chkCream);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rdoNo1;
        private RadioButton rdoNo2;
        private RadioButton rdoNo3;
        private GroupBox groupBox1;
        private Button btnData;
        private CheckBox chkCream;
        private CheckBox chkPie;
        private Label lblResult;
        private TextBox txtResult;
    }
}