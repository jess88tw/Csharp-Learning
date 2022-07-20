// 計時器
// 文字框上的 0 可以在屬性面板做一開始的展示
namespace WinFormsApp01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int n;
            int.TryParse(txtTime.Text, out n);
            txtTime.Text = (++n).ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            txtTime.Text = "0";
        }
    }
}