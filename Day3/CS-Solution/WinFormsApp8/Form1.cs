// ���l, �åB�p���I��
namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            string[] files = { "dice/d1.png", "dice/d2.png", "dice/d3.png", "dice/d4.png", "dice/d5.png", "dice/d6.png" };
            int[] ar = new int[4];
            Random rnd = new Random();

            ar[0] = rnd.Next(0, 6);
            ar[1] = rnd.Next(0, 6);
            ar[2] = rnd.Next(0, 6);
            ar[3] = rnd.Next(0, 6);

            Array.Sort(ar); // �ǥѱƧǥi�H�o��Ҧ����p

            pct1.Image = Image.FromFile(files[ar[0]]);
            pct2.Image = Image.FromFile(files[ar[1]]);
            pct3.Image = Image.FromFile(files[ar[2]]);
            pct4.Image = Image.FromFile(files[ar[3]]);

            if (ar[0] == ar[3])
                lblPoint.Text = "�@��";
            else if (ar[0] == ar[2] || ar[1] == ar[3])
                lblPoint.Text = "�S�I���Y";
            else if (ar[0] == ar[1])
                lblPoint.Text = string.Format("�I��:{0}�I", ar[2] + ar[3] + 2); // 0 + 0 �ҥH�� 2
            else if (ar[1] == ar[2])
                lblPoint.Text = string.Format("�I��:{0}�I", ar[0] + ar[3] + 2);
            else if (ar[2] == ar[3])
                lblPoint.Text = string.Format("�I��:{0}�I", ar[0] + ar[1] + 2);
            else
                lblPoint.Text = "�S�I���Y";
        }
    }
}