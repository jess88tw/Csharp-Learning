// »ë»ë¤l
namespace WinFormsApp07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string[] files = { "dice/d1.png", "dice/d2.png", "dice/d3.png", "dice/d4.png", "dice/d5.png", "dice/d6.png" };
            int n;
            Random rnd = new Random();

            n = rnd.Next(0, 6);
            pic1.Image = Image.FromFile(files[n]);

            n = rnd.Next(0, 6);
            pic2.Image = Image.FromFile(files[n]);

            n = rnd.Next(0, 6);
            pic3.Image = Image.FromFile(files[n]);

            n = rnd.Next(0, 6);
            pic4.Image = Image.FromFile(files[n]);
        }
    }
}