// 要先同時到事件去設定 btn_Click
namespace WinFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // boxing(盒裝)
        private void btn_Click(object sender, EventArgs e)
        {
            // unboxing(解開Box)
            Button btn = (Button)sender;
            MessageBox.Show("You click " + btn.Text + "!");
        }
    }
}