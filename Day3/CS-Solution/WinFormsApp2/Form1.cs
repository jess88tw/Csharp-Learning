// 兩數字相互做運算
namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double a, b;
            double.TryParse(txtA.Text, out a);
            double.TryParse(txtB.Text, out b);
            txtAns.Text = (a + b).ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            double a, b;
            double.TryParse(txtA.Text, out a);
            double.TryParse(txtB.Text, out b);
            txtAns.Text = (a - b).ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            double a, b;
            double.TryParse(txtA.Text, out a);
            double.TryParse(txtB.Text, out b);
            txtAns.Text = (a * b).ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double a, b;
            double.TryParse(txtA.Text, out a);
            double.TryParse(txtB.Text, out b);
            txtAns.Text = (a / b).ToString();
        }
    }
}