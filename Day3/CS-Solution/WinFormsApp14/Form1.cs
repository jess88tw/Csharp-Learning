// �P�ɿ���A�I�ƥ�
namespace WinFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkSame_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkSame.Checked)
                txtB.Text = txtA.Text;
        }
    }
}