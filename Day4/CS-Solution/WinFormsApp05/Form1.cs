// 設計一個介面, 讓使用者可以輸入文字, 並可以讀檔 & 存檔
// 介面可以使用 Anchor 與邊框固定
// OpenFileDialog 的 Filter 設定成 "All Files|*.*|Text Files|*.txt"
namespace WinFormsApp05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                StreamWriter wr = new StreamWriter(dlgSave.FileName);
                wr.Write(txt1.Text);
                wr.Close();
                MessageBox.Show("存檔成功", "存檔", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                StreamReader rd = new StreamReader(dlgOpen.FileName);
                txt1.Text = rd.ReadToEnd();
                rd.Close();
            }
        }
    }
}