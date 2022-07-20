// �]�p�@�Ӥ���, ���ϥΪ̥i�H��J��r, �åi�HŪ�� & �s��
// �����i�H�ϥ� Anchor �P��ةT�w
// OpenFileDialog �� Filter �]�w�� "All Files|*.*|Text Files|*.txt"
namespace WinFormsApp05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                StreamWriter wr = new StreamWriter(dlgSave.FileName);
                wr.Write(txt1.Text);
                wr.Close();
                MessageBox.Show("�s�ɦ��\", "�s��", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                StreamReader rd = new StreamReader(dlgOpen.FileName);
                txt1.Text = rd.ReadToEnd();
                rd.Close();
            }
        }
    }
}