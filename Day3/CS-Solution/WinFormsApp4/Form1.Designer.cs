namespace WinFormsApp4
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
            this.comboData = new System.Windows.Forms.ComboBox();
            this.lblCurr = new System.Windows.Forms.Label();
            this.txtNT = new System.Windows.Forms.TextBox();
            this.btnExchange = new System.Windows.Forms.Button();
            this.lblNT = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboData
            // 
            this.comboData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboData.FormattingEnabled = true;
            this.comboData.Items.AddRange(new object[] {
            "美金",
            "日圓",
            "歐元"});
            this.comboData.Location = new System.Drawing.Point(321, 74);
            this.comboData.Name = "comboData";
            this.comboData.Size = new System.Drawing.Size(341, 38);
            this.comboData.TabIndex = 0;
            // 
            // lblCurr
            // 
            this.lblCurr.AutoSize = true;
            this.lblCurr.Location = new System.Drawing.Point(123, 77);
            this.lblCurr.Name = "lblCurr";
            this.lblCurr.Size = new System.Drawing.Size(61, 30);
            this.lblCurr.TabIndex = 1;
            this.lblCurr.Text = "幣別";
            // 
            // txtNT
            // 
            this.txtNT.Location = new System.Drawing.Point(321, 139);
            this.txtNT.Name = "txtNT";
            this.txtNT.Size = new System.Drawing.Size(341, 38);
            this.txtNT.TabIndex = 2;
            // 
            // btnExchange
            // 
            this.btnExchange.Location = new System.Drawing.Point(512, 228);
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.Size = new System.Drawing.Size(150, 46);
            this.btnExchange.TabIndex = 3;
            this.btnExchange.Text = "兌換";
            this.btnExchange.UseVisualStyleBackColor = true;
            this.btnExchange.Click += new System.EventHandler(this.btnExchange_Click);
            // 
            // lblNT
            // 
            this.lblNT.AutoSize = true;
            this.lblNT.Location = new System.Drawing.Point(123, 142);
            this.lblNT.Name = "lblNT";
            this.lblNT.Size = new System.Drawing.Size(61, 30);
            this.lblNT.TabIndex = 4;
            this.lblNT.Text = "台幣";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(321, 322);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(341, 38);
            this.txtResult.TabIndex = 5;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(123, 325);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(109, 30);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "可換金額";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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

        private ComboBox comboData;
        private Label lblCurr;
        private TextBox txtNT;
        private Button btnExchange;
        private Label lblNT;
        private TextBox txtResult;
        private Label lblResult;
    }
}