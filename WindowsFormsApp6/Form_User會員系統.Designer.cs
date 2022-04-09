
namespace WindowsFormsApp6
{
    partial class Form_User會員系統
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
            this.textBox_會員編號 = new System.Windows.Forms.TextBox();
            this.textBox_點數 = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_密碼 = new System.Windows.Forms.TextBox();
            this.textBox_地址 = new System.Windows.Forms.TextBox();
            this.textBox_電話 = new System.Windows.Forms.TextBox();
            this.textBox_姓名 = new System.Windows.Forms.TextBox();
            this.textBox_帳號 = new System.Windows.Forms.TextBox();
            this.會員編號 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.密碼 = new System.Windows.Forms.Label();
            this.帳號 = new System.Windows.Forms.Label();
            this.點數 = new System.Windows.Forms.Label();
            this.生日 = new System.Windows.Forms.Label();
            this.地址 = new System.Windows.Forms.Label();
            this.電話 = new System.Windows.Forms.Label();
            this.姓名 = new System.Windows.Forms.Label();
            this.btn_註冊會員 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_確認密碼 = new System.Windows.Forms.TextBox();
            this.DTP_生日 = new System.Windows.Forms.DateTimePicker();
            this.btn_返回登入 = new System.Windows.Forms.Button();
            this.groupBox_註冊 = new System.Windows.Forms.GroupBox();
            this.groupBox_修改 = new System.Windows.Forms.GroupBox();
            this.btn_刪除資料 = new System.Windows.Forms.Button();
            this.btn_修改資料 = new System.Windows.Forms.Button();
            this.groupBox_註冊.SuspendLayout();
            this.groupBox_修改.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_會員編號
            // 
            this.textBox_會員編號.Enabled = false;
            this.textBox_會員編號.Location = new System.Drawing.Point(200, 75);
            this.textBox_會員編號.Name = "textBox_會員編號";
            this.textBox_會員編號.Size = new System.Drawing.Size(200, 29);
            this.textBox_會員編號.TabIndex = 0;
            // 
            // textBox_點數
            // 
            this.textBox_點數.Enabled = false;
            this.textBox_點數.Location = new System.Drawing.Point(557, 74);
            this.textBox_點數.MaxLength = 20;
            this.textBox_點數.Name = "textBox_點數";
            this.textBox_點數.Size = new System.Drawing.Size(200, 29);
            this.textBox_點數.TabIndex = 1;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(557, 333);
            this.textBox_Email.MaxLength = 50;
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(200, 29);
            this.textBox_Email.TabIndex = 2;
            // 
            // textBox_密碼
            // 
            this.textBox_密碼.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_密碼.Location = new System.Drawing.Point(557, 202);
            this.textBox_密碼.MaxLength = 15;
            this.textBox_密碼.Name = "textBox_密碼";
            this.textBox_密碼.Size = new System.Drawing.Size(200, 29);
            this.textBox_密碼.TabIndex = 3;
            // 
            // textBox_地址
            // 
            this.textBox_地址.Location = new System.Drawing.Point(200, 261);
            this.textBox_地址.MaxLength = 50;
            this.textBox_地址.Name = "textBox_地址";
            this.textBox_地址.Size = new System.Drawing.Size(200, 29);
            this.textBox_地址.TabIndex = 5;
            // 
            // textBox_電話
            // 
            this.textBox_電話.Location = new System.Drawing.Point(200, 199);
            this.textBox_電話.MaxLength = 10;
            this.textBox_電話.Name = "textBox_電話";
            this.textBox_電話.Size = new System.Drawing.Size(200, 29);
            this.textBox_電話.TabIndex = 6;
            // 
            // textBox_姓名
            // 
            this.textBox_姓名.Location = new System.Drawing.Point(200, 136);
            this.textBox_姓名.MaxLength = 30;
            this.textBox_姓名.Name = "textBox_姓名";
            this.textBox_姓名.Size = new System.Drawing.Size(200, 29);
            this.textBox_姓名.TabIndex = 7;
            // 
            // textBox_帳號
            // 
            this.textBox_帳號.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_帳號.Location = new System.Drawing.Point(557, 135);
            this.textBox_帳號.MaxLength = 15;
            this.textBox_帳號.Name = "textBox_帳號";
            this.textBox_帳號.Size = new System.Drawing.Size(200, 29);
            this.textBox_帳號.TabIndex = 8;
            this.textBox_帳號.TextChanged += new System.EventHandler(this.textBox_帳號_TextChanged);
            // 
            // 會員編號
            // 
            this.會員編號.AutoSize = true;
            this.會員編號.Location = new System.Drawing.Point(101, 78);
            this.會員編號.Name = "會員編號";
            this.會員編號.Size = new System.Drawing.Size(73, 20);
            this.會員編號.TabIndex = 9;
            this.會員編號.Text = "會員編號";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(468, 333);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(50, 20);
            this.Email.TabIndex = 11;
            this.Email.Text = "Email";
            // 
            // 密碼
            // 
            this.密碼.AutoSize = true;
            this.密碼.Location = new System.Drawing.Point(468, 202);
            this.密碼.Name = "密碼";
            this.密碼.Size = new System.Drawing.Size(41, 20);
            this.密碼.TabIndex = 12;
            this.密碼.Text = "密碼";
            // 
            // 帳號
            // 
            this.帳號.AutoSize = true;
            this.帳號.Location = new System.Drawing.Point(468, 135);
            this.帳號.Name = "帳號";
            this.帳號.Size = new System.Drawing.Size(41, 20);
            this.帳號.TabIndex = 13;
            this.帳號.Text = "帳號";
            // 
            // 點數
            // 
            this.點數.AutoSize = true;
            this.點數.Location = new System.Drawing.Point(468, 74);
            this.點數.Name = "點數";
            this.點數.Size = new System.Drawing.Size(41, 20);
            this.點數.TabIndex = 14;
            this.點數.Text = "點數";
            // 
            // 生日
            // 
            this.生日.AutoSize = true;
            this.生日.Location = new System.Drawing.Point(118, 330);
            this.生日.Name = "生日";
            this.生日.Size = new System.Drawing.Size(41, 20);
            this.生日.TabIndex = 15;
            this.生日.Text = "生日";
            // 
            // 地址
            // 
            this.地址.AutoSize = true;
            this.地址.Location = new System.Drawing.Point(118, 261);
            this.地址.Name = "地址";
            this.地址.Size = new System.Drawing.Size(41, 20);
            this.地址.TabIndex = 16;
            this.地址.Text = "地址";
            // 
            // 電話
            // 
            this.電話.AutoSize = true;
            this.電話.Location = new System.Drawing.Point(118, 202);
            this.電話.Name = "電話";
            this.電話.Size = new System.Drawing.Size(41, 20);
            this.電話.TabIndex = 17;
            this.電話.Text = "電話";
            // 
            // 姓名
            // 
            this.姓名.AutoSize = true;
            this.姓名.Location = new System.Drawing.Point(118, 136);
            this.姓名.Name = "姓名";
            this.姓名.Size = new System.Drawing.Size(41, 20);
            this.姓名.TabIndex = 18;
            this.姓名.Text = "姓名";
            // 
            // btn_註冊會員
            // 
            this.btn_註冊會員.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_註冊會員.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_註冊會員.FlatAppearance.BorderSize = 0;
            this.btn_註冊會員.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_註冊會員.Location = new System.Drawing.Point(150, 22);
            this.btn_註冊會員.Name = "btn_註冊會員";
            this.btn_註冊會員.Size = new System.Drawing.Size(150, 58);
            this.btn_註冊會員.TabIndex = 20;
            this.btn_註冊會員.Text = "註冊會員";
            this.btn_註冊會員.UseVisualStyleBackColor = true;
            this.btn_註冊會員.Click += new System.EventHandler(this.btn_註冊會員_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "確認密碼";
            // 
            // textBox_確認密碼
            // 
            this.textBox_確認密碼.Location = new System.Drawing.Point(557, 265);
            this.textBox_確認密碼.MaxLength = 15;
            this.textBox_確認密碼.Name = "textBox_確認密碼";
            this.textBox_確認密碼.Size = new System.Drawing.Size(200, 29);
            this.textBox_確認密碼.TabIndex = 21;
            // 
            // DTP_生日
            // 
            this.DTP_生日.Location = new System.Drawing.Point(200, 330);
            this.DTP_生日.Name = "DTP_生日";
            this.DTP_生日.Size = new System.Drawing.Size(200, 29);
            this.DTP_生日.TabIndex = 23;
            this.DTP_生日.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // btn_返回登入
            // 
            this.btn_返回登入.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_返回登入.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_返回登入.FlatAppearance.BorderSize = 0;
            this.btn_返回登入.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_返回登入.Location = new System.Drawing.Point(0, 22);
            this.btn_返回登入.Name = "btn_返回登入";
            this.btn_返回登入.Size = new System.Drawing.Size(150, 58);
            this.btn_返回登入.TabIndex = 19;
            this.btn_返回登入.Text = "返回登入";
            this.btn_返回登入.UseVisualStyleBackColor = true;
            this.btn_返回登入.Click += new System.EventHandler(this.btn_返回登入_Click);
            // 
            // groupBox_註冊
            // 
            this.groupBox_註冊.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox_註冊.Controls.Add(this.btn_返回登入);
            this.groupBox_註冊.Controls.Add(this.btn_註冊會員);
            this.groupBox_註冊.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_註冊.Location = new System.Drawing.Point(513, 425);
            this.groupBox_註冊.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox_註冊.Name = "groupBox_註冊";
            this.groupBox_註冊.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox_註冊.Size = new System.Drawing.Size(300, 80);
            this.groupBox_註冊.TabIndex = 24;
            this.groupBox_註冊.TabStop = false;
            // 
            // groupBox_修改
            // 
            this.groupBox_修改.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox_修改.Controls.Add(this.btn_刪除資料);
            this.groupBox_修改.Controls.Add(this.btn_修改資料);
            this.groupBox_修改.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_修改.Location = new System.Drawing.Point(122, 425);
            this.groupBox_修改.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox_修改.Name = "groupBox_修改";
            this.groupBox_修改.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox_修改.Size = new System.Drawing.Size(300, 80);
            this.groupBox_修改.TabIndex = 25;
            this.groupBox_修改.TabStop = false;
            // 
            // btn_刪除資料
            // 
            this.btn_刪除資料.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_刪除資料.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_刪除資料.FlatAppearance.BorderSize = 0;
            this.btn_刪除資料.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_刪除資料.Location = new System.Drawing.Point(0, 22);
            this.btn_刪除資料.Name = "btn_刪除資料";
            this.btn_刪除資料.Size = new System.Drawing.Size(150, 58);
            this.btn_刪除資料.TabIndex = 21;
            this.btn_刪除資料.Text = "刪除資料";
            this.btn_刪除資料.UseVisualStyleBackColor = true;
            this.btn_刪除資料.Click += new System.EventHandler(this.btn_刪除資料_Click);
            // 
            // btn_修改資料
            // 
            this.btn_修改資料.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_修改資料.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_修改資料.FlatAppearance.BorderSize = 0;
            this.btn_修改資料.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_修改資料.Location = new System.Drawing.Point(150, 22);
            this.btn_修改資料.Name = "btn_修改資料";
            this.btn_修改資料.Size = new System.Drawing.Size(150, 58);
            this.btn_修改資料.TabIndex = 20;
            this.btn_修改資料.Text = "修改資料";
            this.btn_修改資料.UseVisualStyleBackColor = true;
            this.btn_修改資料.Click += new System.EventHandler(this.btn_修改資料_Click);
            // 
            // Form_User會員系統
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 542);
            this.Controls.Add(this.groupBox_修改);
            this.Controls.Add(this.groupBox_註冊);
            this.Controls.Add(this.DTP_生日);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_確認密碼);
            this.Controls.Add(this.姓名);
            this.Controls.Add(this.電話);
            this.Controls.Add(this.地址);
            this.Controls.Add(this.生日);
            this.Controls.Add(this.點數);
            this.Controls.Add(this.帳號);
            this.Controls.Add(this.密碼);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.會員編號);
            this.Controls.Add(this.textBox_帳號);
            this.Controls.Add(this.textBox_姓名);
            this.Controls.Add(this.textBox_電話);
            this.Controls.Add(this.textBox_地址);
            this.Controls.Add(this.textBox_密碼);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_點數);
            this.Controls.Add(this.textBox_會員編號);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_User會員系統";
            this.Text = "會員系統";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox_註冊.ResumeLayout(false);
            this.groupBox_修改.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_會員編號;
        private System.Windows.Forms.TextBox textBox_點數;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_密碼;
        private System.Windows.Forms.TextBox textBox_地址;
        private System.Windows.Forms.TextBox textBox_電話;
        private System.Windows.Forms.TextBox textBox_姓名;
        private System.Windows.Forms.TextBox textBox_帳號;
        private System.Windows.Forms.Label 會員編號;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label 密碼;
        private System.Windows.Forms.Label 帳號;
        private System.Windows.Forms.Label 點數;
        private System.Windows.Forms.Label 生日;
        private System.Windows.Forms.Label 地址;
        private System.Windows.Forms.Label 電話;
        private System.Windows.Forms.Label 姓名;
        private System.Windows.Forms.Button btn_註冊會員;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_確認密碼;
        private System.Windows.Forms.DateTimePicker DTP_生日;
        private System.Windows.Forms.Button btn_返回登入;
        private System.Windows.Forms.GroupBox groupBox_註冊;
        private System.Windows.Forms.GroupBox groupBox_修改;
        private System.Windows.Forms.Button btn_刪除資料;
        private System.Windows.Forms.Button btn_修改資料;
    }
}