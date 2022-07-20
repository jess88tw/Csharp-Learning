// 同時選取再點事件
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