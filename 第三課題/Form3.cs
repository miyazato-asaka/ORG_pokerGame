using System.Windows.Forms;
using System;

namespace 第三課題
{
    public partial class Error : Form
    {
        public Error()
        {
            InitializeComponent();
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            // アプリケーション終了
            Application.Exit();
        }
    }
}
