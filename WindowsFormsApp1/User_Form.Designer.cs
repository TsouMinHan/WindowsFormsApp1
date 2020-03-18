namespace WindowsFormsApp1 {
    partial class User_Form {
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.name_label = new System.Windows.Forms.Label();
            this.info_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(48, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 178);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("PMingLiU", 16F);
            this.name_label.Location = new System.Drawing.Point(293, 45);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(74, 27);
            this.name_label.TabIndex = 1;
            this.name_label.Text = "label1";
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.Font = new System.Drawing.Font("PMingLiU", 16F);
            this.info_label.Location = new System.Drawing.Point(293, 133);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(74, 27);
            this.info_label.TabIndex = 2;
            this.info_label.Text = "label1";
            // 
            // User_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.info_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.pictureBox1);
            this.Name = "User_Form";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label info_label;
    }
}