namespace WindowsFormsApp1 {
    partial class Member_Form {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.會員管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_member = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_order = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.會員管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 會員管理ToolStripMenuItem
            // 
            this.會員管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_member,
            this.ToolStripMenuItem_order});
            this.會員管理ToolStripMenuItem.Name = "會員管理ToolStripMenuItem";
            this.會員管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.會員管理ToolStripMenuItem.Text = "功能管理";
            
            // 
            // ToolStripMenuItem_member
            // 
            this.ToolStripMenuItem_member.Name = "ToolStripMenuItem_member";
            this.ToolStripMenuItem_member.Size = new System.Drawing.Size(224, 26);
            this.ToolStripMenuItem_member.Text = "會員管理";
           
            // 
            // ToolStripMenuItem_order
            // 
            this.ToolStripMenuItem_order.Name = "ToolStripMenuItem_order";
            this.ToolStripMenuItem_order.Size = new System.Drawing.Size(224, 26);
            this.ToolStripMenuItem_order.Text = "訂購管理";
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Member";
            this.Text = "User";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 會員管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_member;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_order;
    }
}