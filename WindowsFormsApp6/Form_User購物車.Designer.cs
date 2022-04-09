
namespace WindowsFormsApp6
{
    partial class Form_User購物車
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
            this.listBox訂購品項列表 = new System.Windows.Forms.ListBox();
            this.lbl訂購總價幾元 = new System.Windows.Forms.Label();
            this.btn移除所選品項 = new System.Windows.Forms.Button();
            this.btn清除所有品項 = new System.Windows.Forms.Button();
            this.btn_送出訂單 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_CustInfo = new System.Windows.Forms.Label();
            this.radioBtn_SelfTake = new System.Windows.Forms.RadioButton();
            this.radioBtn_Delivery = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_餐巾紙 = new System.Windows.Forms.CheckBox();
            this.checkBox_竹籤 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox訂購品項列表
            // 
            this.listBox訂購品項列表.BackColor = System.Drawing.SystemColors.Control;
            this.listBox訂購品項列表.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox訂購品項列表.FormattingEnabled = true;
            this.listBox訂購品項列表.ItemHeight = 20;
            this.listBox訂購品項列表.Location = new System.Drawing.Point(14, 94);
            this.listBox訂購品項列表.Margin = new System.Windows.Forms.Padding(5);
            this.listBox訂購品項列表.Name = "listBox訂購品項列表";
            this.listBox訂購品項列表.Size = new System.Drawing.Size(1040, 324);
            this.listBox訂購品項列表.TabIndex = 3;
            this.listBox訂購品項列表.SelectedIndexChanged += new System.EventHandler(this.listBox訂購品項列表_SelectedIndexChanged);
            // 
            // lbl訂購總價幾元
            // 
            this.lbl訂購總價幾元.BackColor = System.Drawing.SystemColors.Control;
            this.lbl訂購總價幾元.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂購總價幾元.Location = new System.Drawing.Point(61, 454);
            this.lbl訂購總價幾元.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl訂購總價幾元.Name = "lbl訂購總價幾元";
            this.lbl訂購總價幾元.Size = new System.Drawing.Size(203, 50);
            this.lbl訂購總價幾元.TabIndex = 4;
            this.lbl訂購總價幾元.Text = "訂購總金額 ______ 元";
            this.lbl訂購總價幾元.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl訂購總價幾元.Click += new System.EventHandler(this.lbl訂購總價幾元_Click);
            // 
            // btn移除所選品項
            // 
            this.btn移除所選品項.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn移除所選品項.FlatAppearance.BorderSize = 0;
            this.btn移除所選品項.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn移除所選品項.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn移除所選品項.Location = new System.Drawing.Point(0, 22);
            this.btn移除所選品項.Margin = new System.Windows.Forms.Padding(5);
            this.btn移除所選品項.Name = "btn移除所選品項";
            this.btn移除所選品項.Size = new System.Drawing.Size(150, 58);
            this.btn移除所選品項.TabIndex = 12;
            this.btn移除所選品項.Text = "移除所選品項";
            this.btn移除所選品項.UseVisualStyleBackColor = true;
            this.btn移除所選品項.Click += new System.EventHandler(this.btn移除所選品項_Click);
            // 
            // btn清除所有品項
            // 
            this.btn清除所有品項.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn清除所有品項.FlatAppearance.BorderSize = 0;
            this.btn清除所有品項.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn清除所有品項.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清除所有品項.Location = new System.Drawing.Point(150, 22);
            this.btn清除所有品項.Margin = new System.Windows.Forms.Padding(5);
            this.btn清除所有品項.Name = "btn清除所有品項";
            this.btn清除所有品項.Size = new System.Drawing.Size(150, 58);
            this.btn清除所有品項.TabIndex = 13;
            this.btn清除所有品項.Text = "清除購物車";
            this.btn清除所有品項.UseVisualStyleBackColor = true;
            this.btn清除所有品項.Click += new System.EventHandler(this.btn清除所有品項_Click);
            // 
            // btn_送出訂單
            // 
            this.btn_送出訂單.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_送出訂單.FlatAppearance.BorderSize = 0;
            this.btn_送出訂單.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_送出訂單.Location = new System.Drawing.Point(300, 22);
            this.btn_送出訂單.Name = "btn_送出訂單";
            this.btn_送出訂單.Size = new System.Drawing.Size(150, 58);
            this.btn_送出訂單.TabIndex = 21;
            this.btn_送出訂單.Text = "送出訂單";
            this.btn_送出訂單.UseVisualStyleBackColor = true;
            this.btn_送出訂單.Click += new System.EventHandler(this.btn_送出訂單_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_送出訂單);
            this.groupBox1.Controls.Add(this.btn清除所有品項);
            this.groupBox1.Controls.Add(this.btn移除所選品項);
            this.groupBox1.Location = new System.Drawing.Point(604, 432);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(450, 80);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // lbl_CustInfo
            // 
            this.lbl_CustInfo.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_CustInfo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_CustInfo.Location = new System.Drawing.Point(14, 660);
            this.lbl_CustInfo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_CustInfo.Name = "lbl_CustInfo";
            this.lbl_CustInfo.Size = new System.Drawing.Size(102, 32);
            this.lbl_CustInfo.TabIndex = 2;
            this.lbl_CustInfo.Text = "CustInfo";
            this.lbl_CustInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radioBtn_SelfTake
            // 
            this.radioBtn_SelfTake.AutoSize = true;
            this.radioBtn_SelfTake.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioBtn_SelfTake.Location = new System.Drawing.Point(125, 18);
            this.radioBtn_SelfTake.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtn_SelfTake.Name = "radioBtn_SelfTake";
            this.radioBtn_SelfTake.Size = new System.Drawing.Size(59, 24);
            this.radioBtn_SelfTake.TabIndex = 40;
            this.radioBtn_SelfTake.Text = "自取";
            this.radioBtn_SelfTake.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Delivery
            // 
            this.radioBtn_Delivery.AutoSize = true;
            this.radioBtn_Delivery.Checked = true;
            this.radioBtn_Delivery.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioBtn_Delivery.Location = new System.Drawing.Point(32, 18);
            this.radioBtn_Delivery.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtn_Delivery.Name = "radioBtn_Delivery";
            this.radioBtn_Delivery.Size = new System.Drawing.Size(59, 24);
            this.radioBtn_Delivery.TabIndex = 39;
            this.radioBtn_Delivery.TabStop = true;
            this.radioBtn_Delivery.Text = "外送";
            this.radioBtn_Delivery.UseVisualStyleBackColor = true;
            this.radioBtn_Delivery.CheckedChanged += new System.EventHandler(this.radioBtn_Delivery_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioBtn_Delivery);
            this.groupBox2.Controls.Add(this.radioBtn_SelfTake);
            this.groupBox2.Controls.Add(this.checkBox_餐巾紙);
            this.groupBox2.Controls.Add(this.checkBox_竹籤);
            this.groupBox2.Location = new System.Drawing.Point(14, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 50);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            // 
            // checkBox_餐巾紙
            // 
            this.checkBox_餐巾紙.AutoSize = true;
            this.checkBox_餐巾紙.Location = new System.Drawing.Point(350, 19);
            this.checkBox_餐巾紙.Name = "checkBox_餐巾紙";
            this.checkBox_餐巾紙.Size = new System.Drawing.Size(76, 24);
            this.checkBox_餐巾紙.TabIndex = 27;
            this.checkBox_餐巾紙.Text = "餐巾紙";
            this.checkBox_餐巾紙.UseVisualStyleBackColor = true;
            // 
            // checkBox_竹籤
            // 
            this.checkBox_竹籤.AutoSize = true;
            this.checkBox_竹籤.Location = new System.Drawing.Point(258, 19);
            this.checkBox_竹籤.Name = "checkBox_竹籤";
            this.checkBox_竹籤.Size = new System.Drawing.Size(60, 24);
            this.checkBox_竹籤.TabIndex = 26;
            this.checkBox_竹籤.Text = "竹籤";
            this.checkBox_竹籤.UseVisualStyleBackColor = true;
            // 
            // Form_User購物車
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1068, 542);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl訂購總價幾元);
            this.Controls.Add(this.listBox訂購品項列表);
            this.Controls.Add(this.lbl_CustInfo);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_User購物車";
            this.Text = "購物車";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox訂購品項列表;
        private System.Windows.Forms.Label lbl訂購總價幾元;
        private System.Windows.Forms.Button btn移除所選品項;
        private System.Windows.Forms.Button btn清除所有品項;
        private System.Windows.Forms.Button btn_送出訂單;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_CustInfo;
        private System.Windows.Forms.RadioButton radioBtn_SelfTake;
        private System.Windows.Forms.RadioButton radioBtn_Delivery;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox_餐巾紙;
        private System.Windows.Forms.CheckBox checkBox_竹籤;
    }
}