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

            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("product_name"));
            dt.Columns.Add(new DataColumn("price"));

            string[] name_arr = new string[3] { "奶茶", "紅茶", "綠茶" };
            string[] price_arr = new string[3] { "50", "30", "10" };
            
            for (int i = 0; i < 3; i++)
            {
                DataRow rowz = dt.NewRow();
                rowz["product_name"] = name_arr[i];
                rowz["price"] = price_arr[i];
                dt.Rows.Add(rowz);
            }

            dataGridView1.DataSource = dt;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            dataGridView1.Columns["product_name"].HeaderText = "產品名稱";
            dataGridView1.Columns["price"].HeaderText = "價錢";
            dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 8);
            dataGridView1.AllowUserToAddRows = false;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            int total_row = dgv.RowCount;

            if (e.RowIndex >= 0)
            {
                string name = dgv.Rows[e.RowIndex].Cells["product_name"].Value.ToString();
                string price = dgv.Rows[e.RowIndex].Cells["price"].Value.ToString();
                string result = String.Format("Row: {0}, Column: {1}, Total Row: {2}, Name: {3}, Price: {4}",
                         e.RowIndex, e.ColumnIndex, total_row, name, price);
                MessageBox.Show(result);

            }
            if (e.RowIndex >= 0 && e.ColumnIndex == -1)
            {
                string result = String.Format("Row: {0}, Column: {1}, Total Row: {2}, Name: {3}, Price: {4}",
                         e.RowIndex, e.ColumnIndex, total_row, 1, 1);
                MessageBox.Show(result);
                dgv.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
