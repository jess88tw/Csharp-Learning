namespace WinFormsApp03
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
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(177, 112);
            this.txtResult.Margin = new System.Windows.Forms.Padding(2);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(176, 23);
            this.txtResult.TabIndex = 9;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(97, 114);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(31, 15);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "結果";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(177, 66);
            this.txtScore.Margin = new System.Windows.Forms.Padding(2);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(176, 23);
            this.txtScore.TabIndex = 7;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(97, 68);
            this.lblScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(31, 15);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "成績";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(276, 158);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "計算";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 244);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnCalc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtResult;
        private Label lblResult;
        private TextBox txtScore;
        private Label lblScore;
        private Button btnCalc;
    }
}