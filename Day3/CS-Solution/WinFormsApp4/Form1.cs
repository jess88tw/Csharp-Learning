// �x���I���p��
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
                case "����":
                    amount = nt / 30.05M;
                    break;
                case "���":
                    amount = nt / 0.2756M;
                    break;
                case "�ڤ�":
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