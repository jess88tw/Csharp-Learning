// �q�Ʀr, �åB�ϥ� MessageBox �i�D�j�@�I or �p�@�I
namespace WinFormsApp10
{
    public partial class Form1 : Form
    {
        int ans, guess;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ans = rnd.Next(1, 100);
            Text = ans.ToString(); // ��K���թҥH������X��
            groupBox1.Enabled = true;
            btnStart.Enabled = false; // �b�}�l���᭭��ϥΪ̤���A���}�l��
            btnGuess.Enabled = true;
            txtGuess.Clear(); // �M���C�@���q���Ʀr
            txtGuess.Select(); // �b�����J��
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            int.TryParse(txtGuess.Text, out guess);
            if (guess < ans)
                MessageBox.Show("���@�I");
            else if (guess > ans)
                MessageBox.Show("�C�@�I");
            else
            {
                MessageBox.Show("�q��F", "�q�Ʀr");
                groupBox1.Enabled = false;
                btnStart.Enabled = true;
                btnGuess.Enabled = false;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e) // �ۭq���}��
        {
            Close();
        }
    }
}