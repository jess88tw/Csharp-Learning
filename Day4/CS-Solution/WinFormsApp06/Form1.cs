// 設計一個介面, 讓使用者可以輸入文字, 並可以讀檔 & 存檔, 並且可以更改文字顏色及背景
namespace WinFormsApp06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuNewFile_Click(object sender, EventArgs e)
        {
            txt1.Clear();
        }

        private void mnuOpenFile_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                StreamReader rd = new StreamReader(dlgOpen.FileName);
                txt1.Text = rd.ReadToEnd();
                rd.Close();
            }
        }

        private void mnuSaveFile_Click(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                StreamWriter wr = new StreamWriter(dlgSave.FileName);
                wr.Write(txt1.Text);
                wr.Close();
                MessageBox.Show("存檔成功", "存檔", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mnuQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuForeColor_Click(object sender, EventArgs e)
        {
            if (dlgColor.ShowDialog() == DialogResult.OK)
                txt1.ForeColor = dlgColor.Color;
        }

        private void mnuBackeColor_Click(object sender, EventArgs e)
        {
            if (dlgColor.ShowDialog() == DialogResult.OK)
                txt1.BackColor = dlgColor.Color;
        }

        private void mnuFont_Click(object sender, EventArgs e)
        {
            if (dlgFont.ShowDialog() == DialogResult.OK)
                txt1.Font = dlgFont.Font;
        }
    }
}