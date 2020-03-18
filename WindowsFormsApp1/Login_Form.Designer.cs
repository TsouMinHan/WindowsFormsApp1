namespace WindowsFormsApp1
{
    partial class Login_Form
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
            this.logo_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // user_label
            // 
            this.user_label.AutoSize = true;
            this.user_label.Font = new System.Drawing.Font("PMingLiU", 16F);
            this.user_label.Location = new System.Drawing.Point(299, 28);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(73, 27);
            this.user_label.TabIndex = 0;
            this.user_label.Text = "帳號:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 16F);
            this.label1.Location = new System.Drawing.Point(299, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "密碼:";
            // 
            // msg_label
            // 
            this.msg_label.AutoSize = true;
            this.msg_label.Font = new System.Drawing.Font("PMingLiU", 16F);
            this.msg_label.Location = new System.Drawing.Point(339, 224);
            this.msg_label.Name = "msg_label";
            this.msg_label.Size = new System.Drawing.Size(73, 27);
            this.msg_label.TabIndex = 2;
            this.msg_label.Text = "提示:";
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("PMingLiU", 16F);
            this.login_btn.Location = new System.Drawing.Point(383, 157);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(239, 44);
            this.login_btn.TabIndex = 3;
            this.login_btn.Text = "登入";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // user_txtBox
            // 
            this.user_txtBox.Font = new System.Drawing.Font("PMingLiU", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.user_txtBox.Location = new System.Drawing.Point(383, 25);
            this.user_txtBox.Name = "user_txtBox";
            this.user_txtBox.Size = new System.Drawing.Size(239, 39);
            this.user_txtBox.TabIndex = 4;
            this.user_txtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_Form_KeyDown);
            // 
            // password_txtBox
            // 
            this.password_txtBox.Font = new System.Drawing.Font("PMingLiU", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.password_txtBox.Location = new System.Drawing.Point(383, 102);
            this.password_txtBox.Name = "password_txtBox";
            this.password_txtBox.PasswordChar = '*';
            this.password_txtBox.Size = new System.Drawing.Size(239, 39);
            this.password_txtBox.TabIndex = 5;
            this.password_txtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_Form_KeyDown);
            // 
            // logo_pictureBox
            // 
            this.logo_pictureBox.Image = global::WindowsFormsApp1.Properties.Resources._17005584;
            this.logo_pictureBox.Location = new System.Drawing.Point(45, 28);
            this.logo_pictureBox.Name = "logo_pictureBox";
            this.logo_pictureBox.Size = new System.Drawing.Size(235, 223);
            this.logo_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_pictureBox.TabIndex = 6;
            this.logo_pictureBox.TabStop = false;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 280);
            this.Controls.Add(this.logo_pictureBox);
            this.Controls.Add(this.password_txtBox);
            this.Controls.Add(this.user_txtBox);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.msg_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user_label);
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "找你找的好苦啊";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_Form_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.logo_pictureBox)).EndInit();
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
        private System.Windows.Forms.PictureBox logo_pictureBox;
    }
}

