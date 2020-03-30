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
    public partial class Main_Form : Form {
        public Main_Form() {
            InitializeComponent();
        }

        private void ToolStripMenuItem_member_Click(object sender, EventArgs e) {
            Member_From f = new Member_From();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void ToolStripMenuItem_order_Click(object sender, EventArgs e) {
            Order_From f = new Order_From();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }
    }
}
