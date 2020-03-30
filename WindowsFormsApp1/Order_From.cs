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
            int test = 0;
        }

        private void Order_From_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            cal(sender);
            //total += 50;
            //milk_tea += 1;
            //total_lebel.Text = total.ToString();
            //list_label.Text = String.Format("奶茶{0}杯\n紅茶{1}杯\n嘎逼{2}杯", milk_tea, black_tea, coffee);
        }

        private void button2_Click(object sender, EventArgs e) {
            cal(sender);
            //total += 30;
            //black_tea += 1;
            //total_lebel.Text = total.ToString();
            //list_label.Text = String.Format("奶茶{0}杯\n紅茶{1}杯\n嘎逼{2}杯", milk_tea, black_tea, coffee);
        }

        private void button3_Click(object sender, EventArgs e) {
            cal(sender);
            //total += 80;
            //coffee += 1;
            //total_lebel.Text = total.ToString();
            //list_label.Text = String.Format("奶茶{0}杯\n紅茶{1}杯\n嘎逼{2}杯", milk_tea, black_tea, coffee);
        }

        private void button4_Click(object sender, EventArgs e) {
            total = 0;
            milk_tea = 0;
            black_tea = 0;
            coffee = 0;
            total_lebel.Text = total.ToString();
            //list_label.Text = String.Format("奶茶{0}杯\n紅茶{1}杯\n嘎逼{2}杯", milk_tea, black_tea, coffee);
        }

        public void cal(object sender) {
            Button b = sender as Button;
            total += Convert.ToInt32(b.Tag);
            total_lebel.Text = total.ToString();
            list_label.Text += "\r\n" + b.Text;

        }
    }
}
