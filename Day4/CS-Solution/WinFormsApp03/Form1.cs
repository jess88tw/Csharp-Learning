// ���@�ӯ�Ū����r��, �s��r�ɪ��{��
namespace WinFormsApp03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            StreamWriter wr = new StreamWriter(@"TextFile\test.txt");
            wr.Write(txt1.Text);
            wr.Close();
            MessageBox.Show("�s�ɦ��\");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            StreamReader rd = new StreamReader(@"TextFile\test.txt");
            txt1.Text = rd.ReadToEnd();
            rd.Close(); // �O�o����r��
        }
    }
}
