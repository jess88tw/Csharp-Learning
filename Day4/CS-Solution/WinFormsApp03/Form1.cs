// 做一個能讀取文字檔, 存文字檔的程式
namespace WinFormsApp03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            StreamWriter wr = new StreamWriter(@"TextFile\test.txt");
            wr.Write(txt1.Text);
            wr.Close();
            MessageBox.Show("存檔成功");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            StreamReader rd = new StreamReader(@"TextFile\test.txt");
            txt1.Text = rd.ReadToEnd();
            rd.Close(); // 記得關文字檔
        }
    }
}
