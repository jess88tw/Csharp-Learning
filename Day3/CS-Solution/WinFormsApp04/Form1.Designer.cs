namespace WinFormsApp04
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
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblNT = new System.Windows.Forms.Label();
            this.btnExchange = new System.Windows.Forms.Button();
            this.txtNT = new System.Windows.Forms.TextBox();
            this.lblCurr = new System.Windows.Forms.Label();
            this.comboData = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(68, 170);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(55, 15);
            this.lblResult.TabIndex = 13;
            this.lblResult.Text = "可換金額";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(166, 169);
            this.txtResult.Margin = new System.Windows.Forms.Padding(2);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(172, 23);
            this.txtResult.TabIndex = 12;
            // 
            // lblNT
            // 
            this.lblNT.AutoSize = true;
            this.lblNT.Location = new System.Drawing.Point(68, 79);
            this.lblNT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNT.Name = "lblNT";
            this.lblNT.Size = new System.Drawing.Size(31, 15);
            this.lblNT.TabIndex = 11;
            this.lblNT.Text = "台幣";
            // 
            // btnExchange
            // 
            this.btnExchange.Location = new System.Drawing.Point(262, 122);
            this.btnExchange.Margin = new System.Windows.Forms.Padding(2);
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.Size = new System.Drawing.Size(75, 23);
            this.btnExchange.TabIndex = 10;
            this.btnExchange.Text = "兌換";
            this.btnExchange.UseVisualStyleBackColor = true;
            this.btnExchange.Click += new System.EventHandler(this.btnExchange_Click);
            // 
            // txtNT
            // 
            this.txtNT.Location = new System.Drawing.Point(166, 78);
            this.txtNT.Margin = new System.Windows.Forms.Padding(2);
            this.txtNT.Name = "txtNT";
            this.txtNT.Size = new System.Drawing.Size(172, 23);
            this.txtNT.TabIndex = 9;
            // 
            // lblCurr
            // 
            this.lblCurr.AutoSize = true;
            this.lblCurr.Location = new System.Drawing.Point(68, 46);
            this.lblCurr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurr.Name = "lblCurr";
            this.lblCurr.Size = new System.Drawing.Size(31, 15);
            this.lblCurr.TabIndex = 8;
            this.lblCurr.Text = "幣別";
            // 
            // comboData
            // 
            this.comboData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboData.FormattingEnabled = true;
            this.comboData.Items.AddRange(new object[] {
            "美金",
            "日圓",
            "歐元"});
            this.comboData.Location = new System.Drawing.Point(166, 45);
            this.comboData.Margin = new System.Windows.Forms.Padding(2);
            this.comboData.Name = "comboData";
            this.comboData.Size = new System.Drawing.Size(172, 23);
            this.comboData.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 236);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblNT);
            this.Controls.Add(this.btnExchange);
            this.Controls.Add(this.txtNT);
            this.Controls.Add(this.lblCurr);
            this.Controls.Add(this.comboData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblResult;
        private TextBox txtResult;
        private Label lblNT;
        private Button btnExchange;
        private TextBox txtNT;
        private Label lblCurr;
        private ComboBox comboData;
    }
}