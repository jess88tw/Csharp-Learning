// 使用 OpenFileDialog & SaveFileDialog 製作一個可開啟檔案 & 的程式
namespace WinFormsApp04
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
                txtFileName.Text = dlgSave.FileName;
            else
                txtFileName.Text = "<Cancel>"; // 取消時顯示取消
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() == DialogResult.OK)
                txtFileName.Text = dlgOpen.FileName;
            else
                txtFileName.Text = "<Cancel>";
        }
    }
}