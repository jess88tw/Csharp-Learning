// �q�u��c�s�W label, textBox, botton, �åB�ϫ��U���s��b textBox �W�L�X Hello World!
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            txtData.Text = "Hello World!";
        }
    }
}