﻿namespace WindowsFormsApp1 {
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
            this.total_title_label = new System.Windows.Forms.Label();
            this.total_lebel = new System.Windows.Forms.Label();
            this.shopping_list_label = new System.Windows.Forms.Label();
            this.list_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.guest_radioButton = new System.Windows.Forms.RadioButton();
            this.VIP_radioButton = new System.Windows.Forms.RadioButton();
            this.discount_label = new System.Windows.Forms.Label();
            this.discount_title_label = new System.Windows.Forms.Label();
            this.pay_label = new System.Windows.Forms.Label();
            this.pay_title_label = new System.Windows.Forms.Label();
            this.production_listBox = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // total_title_label
            // 
            this.total_title_label.AutoSize = true;
            this.total_title_label.Font = new System.Drawing.Font("新細明體", 16F);
            this.total_title_label.Location = new System.Drawing.Point(849, 230);
            this.total_title_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.total_title_label.Name = "total_title_label";
            this.total_title_label.Size = new System.Drawing.Size(76, 22);
            this.total_title_label.TabIndex = 3;
            this.total_title_label.Text = "總價：";
            // 
            // total_lebel
            // 
            this.total_lebel.AutoSize = true;
            this.total_lebel.Font = new System.Drawing.Font("新細明體", 16F);
            this.total_lebel.Location = new System.Drawing.Point(923, 230);
            this.total_lebel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.total_lebel.Name = "total_lebel";
            this.total_lebel.Size = new System.Drawing.Size(20, 22);
            this.total_lebel.TabIndex = 4;
            this.total_lebel.Text = "0";
            // 
            // shopping_list_label
            // 
            this.shopping_list_label.AutoSize = true;
            this.shopping_list_label.Font = new System.Drawing.Font("新細明體", 16F);
            this.shopping_list_label.Location = new System.Drawing.Point(29, 39);
            this.shopping_list_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shopping_list_label.Name = "shopping_list_label";
            this.shopping_list_label.Size = new System.Drawing.Size(120, 22);
            this.shopping_list_label.TabIndex = 6;
            this.shopping_list_label.Text = "購買清單：";
            // 
            // list_label
            // 
            this.list_label.AutoSize = true;
            this.list_label.Font = new System.Drawing.Font("新細明體", 16F);
            this.list_label.Location = new System.Drawing.Point(29, 78);
            this.list_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.list_label.Name = "list_label";
            this.list_label.Size = new System.Drawing.Size(0, 22);
            this.list_label.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(400, 129);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 74);
            this.button1.TabIndex = 0;
            this.button1.Tag = "50";
            this.button1.Text = "奶茶($50)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(537, 129);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 74);
            this.button2.TabIndex = 1;
            this.button2.Tag = "30";
            this.button2.Text = "紅茶($30)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(673, 129);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 74);
            this.button3.TabIndex = 2;
            this.button3.Tag = "70";
            this.button3.Text = "嘎逼($70)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(852, 129);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 74);
            this.button4.TabIndex = 5;
            this.button4.Text = "清除";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(602, 32);
            this.comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(92, 20);
            this.comboBox.TabIndex = 8;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.guest_radioButton);
            this.groupBox.Controls.Add(this.VIP_radioButton);
            this.groupBox.Location = new System.Drawing.Point(400, 17);
            this.groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox.Size = new System.Drawing.Size(177, 95);
            this.groupBox.TabIndex = 9;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "身分識別";
            // 
            // guest_radioButton
            // 
            this.guest_radioButton.AutoSize = true;
            this.guest_radioButton.Location = new System.Drawing.Point(5, 62);
            this.guest_radioButton.Margin = new System.Windows.Forms.Padding(2);
            this.guest_radioButton.Name = "guest_radioButton";
            this.guest_radioButton.Size = new System.Drawing.Size(59, 16);
            this.guest_radioButton.TabIndex = 1;
            this.guest_radioButton.TabStop = true;
            this.guest_radioButton.Text = "非會員";
            this.guest_radioButton.UseVisualStyleBackColor = true;
            this.guest_radioButton.CheckedChanged += new System.EventHandler(this.guest_radioButton_CheckedChanged);
            // 
            // VIP_radioButton
            // 
            this.VIP_radioButton.AutoSize = true;
            this.VIP_radioButton.Location = new System.Drawing.Point(5, 30);
            this.VIP_radioButton.Margin = new System.Windows.Forms.Padding(2);
            this.VIP_radioButton.Name = "VIP_radioButton";
            this.VIP_radioButton.Size = new System.Drawing.Size(103, 16);
            this.VIP_radioButton.TabIndex = 0;
            this.VIP_radioButton.TabStop = true;
            this.VIP_radioButton.Text = "VIP會員(打9折)";
            this.VIP_radioButton.UseVisualStyleBackColor = true;
            this.VIP_radioButton.CheckedChanged += new System.EventHandler(this.VIP_radioButton_CheckedChanged);
            // 
            // discount_label
            // 
            this.discount_label.AutoSize = true;
            this.discount_label.Font = new System.Drawing.Font("新細明體", 16F);
            this.discount_label.Location = new System.Drawing.Point(923, 275);
            this.discount_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.discount_label.Name = "discount_label";
            this.discount_label.Size = new System.Drawing.Size(20, 22);
            this.discount_label.TabIndex = 11;
            this.discount_label.Text = "0";
            // 
            // discount_title_label
            // 
            this.discount_title_label.AutoSize = true;
            this.discount_title_label.Font = new System.Drawing.Font("新細明體", 16F);
            this.discount_title_label.Location = new System.Drawing.Point(849, 275);
            this.discount_title_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.discount_title_label.Name = "discount_title_label";
            this.discount_title_label.Size = new System.Drawing.Size(76, 22);
            this.discount_title_label.TabIndex = 10;
            this.discount_title_label.Text = "折扣：";
            // 
            // pay_label
            // 
            this.pay_label.AutoSize = true;
            this.pay_label.Font = new System.Drawing.Font("新細明體", 16F);
            this.pay_label.Location = new System.Drawing.Point(923, 321);
            this.pay_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pay_label.Name = "pay_label";
            this.pay_label.Size = new System.Drawing.Size(20, 22);
            this.pay_label.TabIndex = 13;
            this.pay_label.Text = "0";
            // 
            // pay_title_label
            // 
            this.pay_title_label.AutoSize = true;
            this.pay_title_label.Font = new System.Drawing.Font("新細明體", 16F);
            this.pay_title_label.Location = new System.Drawing.Point(849, 321);
            this.pay_title_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pay_title_label.Name = "pay_title_label";
            this.pay_title_label.Size = new System.Drawing.Size(76, 22);
            this.pay_title_label.TabIndex = 12;
            this.pay_title_label.Text = "應付：";
            // 
            // production_listBox
            // 
            this.production_listBox.FormattingEnabled = true;
            this.production_listBox.ItemHeight = 12;
            this.production_listBox.Location = new System.Drawing.Point(400, 382);
            this.production_listBox.Margin = new System.Windows.Forms.Padding(2);
            this.production_listBox.Name = "production_listBox";
            this.production_listBox.Size = new System.Drawing.Size(393, 76);
            this.production_listBox.TabIndex = 14;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.Location = new System.Drawing.Point(400, 230);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 74);
            this.button5.TabIndex = 15;
            this.button5.Tag = "10";
            this.button5.Text = "綠茶($10)";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button6.Location = new System.Drawing.Point(537, 230);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(119, 74);
            this.button6.TabIndex = 16;
            this.button6.Tag = "20";
            this.button6.Text = "可樂($20)";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button7.Location = new System.Drawing.Point(673, 230);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(119, 74);
            this.button7.TabIndex = 17;
            this.button7.Tag = "40";
            this.button7.Text = "果汁($40)";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(306, 373);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Order_From
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 506);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.production_listBox);
            this.Controls.Add(this.pay_label);
            this.Controls.Add(this.pay_title_label);
            this.Controls.Add(this.discount_label);
            this.Controls.Add(this.discount_title_label);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.list_label);
            this.Controls.Add(this.shopping_list_label);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.total_lebel);
            this.Controls.Add(this.total_title_label);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Order_From";
            this.Text = "Order_From";
            this.Load += new System.EventHandler(this.Order_From_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label total_title_label;
        private System.Windows.Forms.Label total_lebel;
        private System.Windows.Forms.Label shopping_list_label;
        private System.Windows.Forms.Label list_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton guest_radioButton;
        private System.Windows.Forms.RadioButton VIP_radioButton;
        private System.Windows.Forms.Label discount_label;
        private System.Windows.Forms.Label discount_title_label;
        private System.Windows.Forms.Label pay_label;
        private System.Windows.Forms.Label pay_title_label;
        private System.Windows.Forms.ListBox production_listBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}