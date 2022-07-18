// 猜數字, 並且使用 MessageBox 告訴大一點 or 小一點
namespace WinFormsApp10
{
    public partial class Form1 : Form
    {
        int ans, guess;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ans = rnd.Next(1, 100);
            Text = ans.ToString(); // 方便測試所以直接放出來
            groupBox1.Enabled = true;
            btnStart.Enabled = false; // 在開始之後限制使用者不能再按開始建
            btnGuess.Enabled = true;
            txtGuess.Clear(); // 清除每一次猜的數字
            txtGuess.Select(); // 在選取輸入框
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            int.TryParse(txtGuess.Text, out guess);
            if (guess < ans)
                MessageBox.Show("高一點");
            else if (guess > ans)
                MessageBox.Show("低一點");
            else
            {
                MessageBox.Show("猜對了", "猜數字");
                groupBox1.Enabled = false;
                btnStart.Enabled = true;
                btnGuess.Enabled = false;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e) // 自訂離開建
        {
            Close();
        }
    }
}