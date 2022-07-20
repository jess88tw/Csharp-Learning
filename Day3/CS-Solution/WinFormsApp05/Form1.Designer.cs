namespace WinFormsApp05
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.chkPie = new System.Windows.Forms.CheckBox();
            this.chkCream = new System.Windows.Forms.CheckBox();
            this.btnData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoNo3 = new System.Windows.Forms.RadioButton();
            this.rdoNo2 = new System.Windows.Forms.RadioButton();
            this.rdoNo1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(107, 231);
            this.txtResult.Margin = new System.Windows.Forms.Padding(2);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(107, 23);
            this.txtResult.TabIndex = 19;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(73, 232);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(31, 15);
            this.lblResult.TabIndex = 18;
            this.lblResult.Text = "小計";
            // 
            // chkPie
            // 
            this.chkPie.AutoSize = true;
            this.chkPie.Location = new System.Drawing.Point(94, 192);
            this.chkPie.Margin = new System.Windows.Forms.Padding(2);
            this.chkPie.Name = "chkPie";
            this.chkPie.Size = new System.Drawing.Size(102, 19);
            this.chkPie.TabIndex = 17;
            this.chkPie.Text = "Apple Pie(25)";
            this.chkPie.UseVisualStyleBackColor = true;
            // 
            // chkCream
            // 
            this.chkCream.AutoSize = true;
            this.chkCream.Location = new System.Drawing.Point(94, 166);
            this.chkCream.Margin = new System.Windows.Forms.Padding(2);
            this.chkCream.Name = "chkCream";
            this.chkCream.Size = new System.Drawing.Size(104, 19);
            this.chkCream.TabIndex = 16;
            this.chkCream.Text = "Ice Cream(15)";
            this.chkCream.UseVisualStyleBackColor = true;
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(94, 270);
            this.btnData.Margin = new System.Windows.Forms.Padding(2);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(84, 23);
            this.btnData.TabIndex = 14;
            this.btnData.Text = "計算";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoNo3);
            this.groupBox1.Controls.Add(this.rdoNo2);
            this.groupBox1.Controls.Add(this.rdoNo1);
            this.groupBox1.Location = new System.Drawing.Point(73, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(138, 96);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "餐點";
            // 
            // rdoNo3
            // 
            this.rdoNo3.AutoSize = true;
            this.rdoNo3.Location = new System.Drawing.Point(19, 63);
            this.rdoNo3.Margin = new System.Windows.Forms.Padding(2);
            this.rdoNo3.Name = "rdoNo3";
            this.rdoNo3.Size = new System.Drawing.Size(79, 19);
            this.rdoNo3.TabIndex = 2;
            this.rdoNo3.TabStop = true;
            this.rdoNo3.Text = "No3(120)";
            this.rdoNo3.UseVisualStyleBackColor = true;
            // 
            // rdoNo2
            // 
            this.rdoNo2.AutoSize = true;
            this.rdoNo2.Location = new System.Drawing.Point(19, 43);
            this.rdoNo2.Margin = new System.Windows.Forms.Padding(2);
            this.rdoNo2.Name = "rdoNo2";
            this.rdoNo2.Size = new System.Drawing.Size(79, 19);
            this.rdoNo2.TabIndex = 1;
            this.rdoNo2.TabStop = true;
            this.rdoNo2.Text = "No2(105)";
            this.rdoNo2.UseVisualStyleBackColor = true;
            // 
            // rdoNo1
            // 
            this.rdoNo1.AutoSize = true;
            this.rdoNo1.Location = new System.Drawing.Point(19, 23);
            this.rdoNo1.Margin = new System.Windows.Forms.Padding(2);
            this.rdoNo1.Name = "rdoNo1";
            this.rdoNo1.Size = new System.Drawing.Size(72, 19);
            this.rdoNo1.TabIndex = 0;
            this.rdoNo1.TabStop = true;
            this.rdoNo1.Text = "No1(95)";
            this.rdoNo1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 355);
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

        private TextBox txtResult;
        private Label lblResult;
        private CheckBox chkPie;
        private CheckBox chkCream;
        private Button btnData;
        private GroupBox groupBox1;
        private RadioButton rdoNo3;
        private RadioButton rdoNo2;
        private RadioButton rdoNo1;
    }
}