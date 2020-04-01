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
    public partial class Order_From : Form {
        int total = 0;
        int milk_tea = 0;
        int black_tea = 0;
        int coffee = 0;

        public Order_From() {
            InitializeComponent();
        }

        private void Order_From_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            cal(sender);
        }

        private void button2_Click(object sender, EventArgs e) {
            cal(sender);
        }

        private void button3_Click(object sender, EventArgs e) {
            cal(sender);
        }

        private void button4_Click(object sender, EventArgs e) {
            total = 0;
            milk_tea = 0;
            black_tea = 0;
            coffee = 0;
            total_lebel.Text = total.ToString();
            list_label.Text = "";
        }

        public void cal(object sender) {
            //Button b = (Button)sender;
            Button b = sender as Button;
            total += Convert.ToInt32(b.Tag);
            total_lebel.Text = total.ToString();
            list_label.Text += b.Text + "\r\n";

        }
    }
}
