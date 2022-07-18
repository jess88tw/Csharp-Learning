namespace WinFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // boxing(²°¸Ë)
        private void btn_Click(object sender, EventArgs e)
        {
            // unboxing(¸Ñ¶}Box)
            Button btn = (Button)sender;
            MessageBox.Show("You click " + btn.Text + "!");
        }
    }
}