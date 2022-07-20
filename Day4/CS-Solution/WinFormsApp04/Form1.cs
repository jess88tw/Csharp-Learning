// �ϥ� OpenFileDialog & SaveFileDialog �s�@�@�ӥi�}���ɮ� & ���{��
namespace WinFormsApp04
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
                txtFileName.Text = dlgSave.FileName;
            else
                txtFileName.Text = "<Cancel>"; // ��������ܨ���
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() == DialogResult.OK)
                txtFileName.Text = dlgOpen.FileName;
            else
                txtFileName.Text = "<Cancel>";
        }
    }
}