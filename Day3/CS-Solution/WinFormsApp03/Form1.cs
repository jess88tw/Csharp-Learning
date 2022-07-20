// 輸入成績計算是否及格
namespace WinFormsApp03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int score;
            int.TryParse(txtScore.Text, out score);

            if (score < 60)
            {
                txtResult.Text = "不及格當掉!";
                txtResult.BackColor = Color.Red;
            }
            else
            {
                txtResult.Text = "恭喜!";
                txtResult.BackColor = Color.Green;
            }
        }
    }
}