// 從工具箱新增 label, textBox, botton, 並且使按下按鈕後在 textBox 上印出 Hello World!
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            txtData.Text = "Hello World!";
        }
    }
}