// 製作菜單, 並且將價錢計算
namespace WinFormsApp05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            int total = 0;

            if (rdoNo1.Checked)
                total += 95; // total = total + 95
            else if (rdoNo2.Checked)
                total += 105;
            else if (rdoNo3.Checked)
                total += 120;

            if (chkCream.Checked)
                total += 15;

            if (chkPie.Checked)
                total += 25;

            txtResult.Text = total.ToString();
        }
    }
}