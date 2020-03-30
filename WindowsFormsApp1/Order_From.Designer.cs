namespace WindowsFormsApp1 {
    partial class Order_From {
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.total_title_label = new System.Windows.Forms.Label();
            this.total_lebel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.shopping_list_label = new System.Windows.Forms.Label();
            this.list_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("PMingLiU", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(306, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 92);
            this.button1.TabIndex = 0;
            this.button1.Text = "奶茶($50)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("PMingLiU", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(602, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 92);
            this.button2.TabIndex = 1;
            this.button2.Text = "紅茶($30)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("PMingLiU", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(870, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 92);
            this.button3.TabIndex = 2;
            this.button3.Text = "嘎逼($70)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // total_title_label
            // 
            this.total_title_label.AutoSize = true;
            this.total_title_label.Font = new System.Drawing.Font("PMingLiU", 16F);
            this.total_title_label.Location = new System.Drawing.Point(39, 314);
            this.total_title_label.Name = "total_title_label";
            this.total_title_label.Size = new System.Drawing.Size(93, 27);
            this.total_title_label.TabIndex = 3;
            this.total_title_label.Text = "總價：";
            // 
            // total_lebel
            // 
            this.total_lebel.AutoSize = true;
            this.total_lebel.Font = new System.Drawing.Font("PMingLiU", 16F);
            this.total_lebel.Location = new System.Drawing.Point(138, 314);
            this.total_lebel.Name = "total_lebel";
            this.total_lebel.Size = new System.Drawing.Size(25, 27);
            this.total_lebel.TabIndex = 4;
            this.total_lebel.Text = "0";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("PMingLiU", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(870, 249);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 92);
            this.button4.TabIndex = 5;
            this.button4.Text = "清除";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // shopping_list_label
            // 
            this.shopping_list_label.AutoSize = true;
            this.shopping_list_label.Font = new System.Drawing.Font("PMingLiU", 16F);
            this.shopping_list_label.Location = new System.Drawing.Point(39, 49);
            this.shopping_list_label.Name = "shopping_list_label";
            this.shopping_list_label.Size = new System.Drawing.Size(147, 27);
            this.shopping_list_label.TabIndex = 6;
            this.shopping_list_label.Text = "購買清單：";
            // 
            // list_label
            // 
            this.list_label.AutoSize = true;
            this.list_label.Font = new System.Drawing.Font("PMingLiU", 16F);
            this.list_label.Location = new System.Drawing.Point(39, 98);
            this.list_label.Name = "list_label";
            this.list_label.Size = new System.Drawing.Size(147, 27);
            this.list_label.TabIndex = 7;
            this.list_label.Text = "購買清單：";
            // 
            // Order_From
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 450);
            this.Controls.Add(this.list_label);
            this.Controls.Add(this.shopping_list_label);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.total_lebel);
            this.Controls.Add(this.total_title_label);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Order_From";
            this.Text = "Order_From";
            this.Load += new System.EventHandler(this.Order_From_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label total_title_label;
        private System.Windows.Forms.Label total_lebel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label shopping_list_label;
        private System.Windows.Forms.Label list_label;
    }
}