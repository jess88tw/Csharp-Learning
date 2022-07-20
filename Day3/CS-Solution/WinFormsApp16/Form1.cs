// 8 個文字方塊, 可以使上下鍵控制游標, 可以向上或向下一個文字方塊
namespace WinFormsApp16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 當有文字在格子裡可以全選
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
                    SendKeys.Send("+{Tab}"); // 這裡的 + 是反著的意思
                    break;
                default:
                    break;
            }
        }
    }
}