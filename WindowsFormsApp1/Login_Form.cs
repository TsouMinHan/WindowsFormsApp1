using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Login_Form : Form {
        string user = "admin";
        string password = "123";
        int login_count = 0;

        public Login_Form() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            user_txtBox.Focus();
            msg_label.Text = "";
        }

        private void login_btn_Click(object sender, EventArgs e) {
            if (user_txtBox.Text.Length==0 || password_txtBox.Text.Length==0) {
                msg_label.Text = "帳號和密碼不能為空白";
                return;
            }
            if (user_txtBox.Text == user && password_txtBox.Text == password) {
                msg_label.Text = String.Format("提示:歡迎你，{0}!", user_txtBox.Text);
                DialogResult = DialogResult.OK;
            }
            else {
                login_count += 1;
                msg_label.Text = String.Format("提示:失敗{0}次", login_count);

                if (login_count == 3) {
                    MessageBox.Show("提示:您已經超過認證次數!!!");
                    //Application.Exit();
                    DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void Login_Form_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                login_btn_Click(this, null);
            }
        }
    }
}
