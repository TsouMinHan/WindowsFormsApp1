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
        int buy_num = 1;   

        public Order_From() {
            InitializeComponent();
        }

        private void Order_From_Load(object sender, EventArgs e) {
            guest_radioButton.Checked = true;
            for (int i=1; i<=500; i++){
                comboBox.Items.Add(i);
            }
            comboBox.SelectedIndex = 0;
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
            //list_label.Text = "";
            production_listBox.Items.Clear();
            cal_pay();
        }

        public void cal(object sender) {
            //Button b = (Button)sender;
            Button b = sender as Button;
            total += Convert.ToInt32(b.Tag);
            //list_label.Text += b.Text + "\r\n";
            production_listBox.Items.Add(b.Text);
            cal_pay();
        }

        public void cal_pay() {
            double pay = 0;
            double discount = 0;

            if (VIP_radioButton.Checked) {
                discount = total * 0.1;
            }
            else if (guest_radioButton.Checked) {
                discount = 0;
            }
            pay = total - discount;
            total_lebel.Text = total.ToString();
            discount_label.Text = discount.ToString();
            pay_label.Text = pay.ToString();
        }
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e) {
            buy_num = Convert.ToInt32(comboBox.SelectedItem.ToString());
        }

        private void button5_Click(object sender, EventArgs e) {
            cal(sender);
        }

        private void button6_Click(object sender, EventArgs e) {
            cal(sender);
        }

        private void button7_Click(object sender, EventArgs e) {
            cal(sender);
        }

        private void VIP_radioButton_CheckedChanged(object sender, EventArgs e) {
            cal_pay();
        }

        private void guest_radioButton_CheckedChanged(object sender, EventArgs e) {
            cal_pay();
        }
    }
}
