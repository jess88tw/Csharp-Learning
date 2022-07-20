// 可以運球的籃球, 記得查看 picture box 的屬性
namespace WinFormsApp02
{
    public partial class Form1 : Form
    {
        int dy = 5, dx = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += dy;
            pictureBox1.Left += dx;
            if (pictureBox1.Top + pictureBox1.Height + 40 >= this.Height)
                dy = -5;
            if (pictureBox1.Top <= 0)
                dy = 5;
            if (pictureBox1.Left + pictureBox1.Width + 20 >= this.Width)
                dx = -5;
            if (pictureBox1.Left <= 0)
                dx = 5;
        }
    }
}