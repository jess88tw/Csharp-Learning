// MessageBox 用法
namespace WinFormsApp09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world!", "Greeting", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        private void btnAsk_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Yes or No", "Ask", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (ans == DialogResult.Yes)
                txt1.Text = "Yep!";
            else if (ans == DialogResult.No)
                txt1.Text = "Nooooooooooooo!!";
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("確定要離開???", "離開", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (ans == DialogResult.Yes)
                this.Close();
        }
    }
}