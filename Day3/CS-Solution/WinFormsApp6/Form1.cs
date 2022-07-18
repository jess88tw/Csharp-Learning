// 顯示圖片
namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDog_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("animal/dog.jpg"); // 放在 CS-Solution\WinFormsApp6\bin\Debug\net6.0-windows\Animal 裡面
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("animal/cat.jpg");
        }

        private void btnLion_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("animal/lion.jpg");
        }
    }
}