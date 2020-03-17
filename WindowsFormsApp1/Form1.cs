using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int login_times = 0;
        string original_msg_label_text = "提示:";

        public Form1()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string user = "admin";
            string password = "123";

            if(user_txtBox.Text == user && password_txtBox.Text == password)
            {
                msg_label.Text += "asiodjoaisdj";
            }
            else if (login_times == 2)
            {
                Application.Exit();
            }
            else
            {
                login_times += 1;
                msg_label.Text = original_msg_label_text + "Failure " + login_times;
            }
        }
    }
}
