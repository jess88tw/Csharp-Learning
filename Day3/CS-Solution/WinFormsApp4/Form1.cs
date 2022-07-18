// 台幣兌換計算
namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExchange_Click(object sender, EventArgs e)
        {
            int nt;
            decimal amount;
            int.TryParse(txtNT.Text, out nt);

            switch (comboData.Text)
            {
                case "美金":
                    amount = nt / 30.05M;
                    break;
                case "日圓":
                    amount = nt / 0.2756M;
                    break;
                case "歐元":
                    amount = nt / 32.15M;
                    break;
                default:
                    amount = 0;
                    break;
            }
            txtResult.Text = amount.ToString("#,##0.00");
        }
    }
}