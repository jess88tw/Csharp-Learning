// �n���P�ɨ�ƥ�h�]�w btn_Click
namespace WinFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // boxing(����)
        private void btn_Click(object sender, EventArgs e)
        {
            // unboxing(�Ѷ}Box)
            Button btn = (Button)sender;
            MessageBox.Show("You click " + btn.Text + "!");
        }
    }
}