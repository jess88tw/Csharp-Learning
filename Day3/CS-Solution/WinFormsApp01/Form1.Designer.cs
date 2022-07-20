namespace WinFormsApp01
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
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.btnData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(110, 47);
            this.txtData.Margin = new System.Windows.Forms.Padding(2);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(102, 23);
            this.txtData.TabIndex = 5;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(28, 49);
            this.lblData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(34, 15);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Data";
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(243, 45);
            this.btnData.Margin = new System.Windows.Forms.Padding(2);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(75, 23);
            this.btnData.TabIndex = 3;
            this.btnData.Text = "OK";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 114);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.btnData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtData;
        private Label lblData;
        private Button btnData;
    }
}