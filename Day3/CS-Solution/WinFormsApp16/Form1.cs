// 8 �Ӥ�r���, �i�H�ϤW�U�䱱����, �i�H�V�W�ΦV�U�@�Ӥ�r���
namespace WinFormsApp16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ����r�b��l�̥i�H����
        private void txt_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.SelectAll();
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                case Keys.Down:
                    SendKeys.Send("{Tab}");
                    break;
                case Keys.Up:
                    SendKeys.Send("+{Tab}"); // �o�̪� + �O�ϵ۪��N��
                    break;
                default:
                    break;
            }
        }
    }
}