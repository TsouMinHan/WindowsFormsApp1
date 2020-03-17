namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.user_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.msg_label = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.user_txtBox = new System.Windows.Forms.TextBox();
            this.password_txtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // user_label
            // 
            this.user_label.AutoSize = true;
            this.user_label.Font = new System.Drawing.Font("PMingLiU", 16F);
            this.user_label.Location = new System.Drawing.Point(76, 60);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(73, 27);
            this.user_label.TabIndex = 0;
            this.user_label.Text = "帳號:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 16F);
            this.label1.Location = new System.Drawing.Point(76, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "密碼:";
            // 
            // msg_label
            // 
            this.msg_label.AutoSize = true;
            this.msg_label.Font = new System.Drawing.Font("PMingLiU", 16F);
            this.msg_label.Location = new System.Drawing.Point(155, 256);
            this.msg_label.Name = "msg_label";
            this.msg_label.Size = new System.Drawing.Size(73, 27);
            this.msg_label.TabIndex = 2;
            this.msg_label.Text = "提示:";
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("PMingLiU", 16F);
            this.login_btn.Location = new System.Drawing.Point(160, 189);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(239, 44);
            this.login_btn.TabIndex = 3;
            this.login_btn.Text = "登入";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // user_txtBox
            // 
            this.user_txtBox.Location = new System.Drawing.Point(160, 60);
            this.user_txtBox.Multiline = true;
            this.user_txtBox.Name = "user_txtBox";
            this.user_txtBox.Size = new System.Drawing.Size(239, 33);
            this.user_txtBox.TabIndex = 4;
            // 
            // password_txtBox
            // 
            this.password_txtBox.Location = new System.Drawing.Point(160, 137);
            this.password_txtBox.Multiline = true;
            this.password_txtBox.Name = "password_txtBox";
            this.password_txtBox.Size = new System.Drawing.Size(239, 33);
            this.password_txtBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 292);
            this.Controls.Add(this.password_txtBox);
            this.Controls.Add(this.user_txtBox);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.msg_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user_label);
            this.Name = "Form1";
            this.Text = "找你找的好苦啊";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label msg_label;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox user_txtBox;
        private System.Windows.Forms.TextBox password_txtBox;
    }
}

