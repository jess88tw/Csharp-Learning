// �ϥΨƥ�, ���Xø�ϪO
namespace WinFormsApp13
{
    public partial class Form1 : Form
    {
        int x0, y0; // �_�l�y��
        public Form1()
        {
            InitializeComponent();
        }

        private void picBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = picBox.CreateGraphics();
                g.DrawLine(new Pen(Color.Black), x0, y0, e.X, e.Y); // �ƹ����������e���
                x0 = e.X; // �Y�����|�ܦ����u
                y0 = e.Y;
            }
            textData.Text = String.Format("X = {0}, Y = {1}, Button = {2}", e.X, e.Y, e.Button); // ��ܷƹ���m
        }

        private void picBox_MouseDown(object sender, MouseEventArgs e)
        {
            x0 = e.X;
            y0 = e.Y;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            Graphics g = picBox.CreateGraphics();
            g.DrawLine(new Pen(Color.Blue), 10, 10, 110, 110);
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            Graphics g = picBox.CreateGraphics();
            g.DrawRectangle(new Pen(Color.Green), 10, 10, 100, 100);
        }
        
        private void btnEllipse_Click(object sender, EventArgs e)
        {
            Graphics g = picBox.CreateGraphics();
            g.DrawEllipse(new Pen(Color.Red), 10, 10, 100, 100);
        }
    }
}