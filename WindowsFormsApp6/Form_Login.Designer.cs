
namespace WindowsFormsApp6
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.btn_註冊帳號 = new System.Windows.Forms.Button();
            this.textBox_帳號 = new System.Windows.Forms.TextBox();
            this.btn_登入 = new System.Windows.Forms.Button();
            this.textBox_密碼 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioBtn_Admin = new System.Windows.Forms.RadioButton();
            this.radioBtn_User = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_註冊帳號
            // 
            this.btn_註冊帳號.Location = new System.Drawing.Point(368, 362);
            this.btn_註冊帳號.Name = "btn_註冊帳號";
            this.btn_註冊帳號.Size = new System.Drawing.Size(96, 40);
            this.btn_註冊帳號.TabIndex = 0;
            this.btn_註冊帳號.Text = "註冊帳號";
            this.btn_註冊帳號.UseVisualStyleBackColor = true;
            this.btn_註冊帳號.Click += new System.EventHandler(this.btn_註冊帳號_Click);
            // 
            // textBox_帳號
            // 
            this.textBox_帳號.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox_帳號.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.textBox_帳號.Location = new System.Drawing.Point(368, 224);
            this.textBox_帳號.MaxLength = 15;
            this.textBox_帳號.Name = "textBox_帳號";
            this.textBox_帳號.Size = new System.Drawing.Size(200, 29);
            this.textBox_帳號.TabIndex = 1;
            // 
            // btn_登入
            // 
            this.btn_登入.Location = new System.Drawing.Point(470, 362);
            this.btn_登入.Name = "btn_登入";
            this.btn_登入.Size = new System.Drawing.Size(98, 40);
            this.btn_登入.TabIndex = 4;
            this.btn_登入.Text = "登入";
            this.btn_登入.UseVisualStyleBackColor = true;
            this.btn_登入.Click += new System.EventHandler(this.btn_登入_Click);
            // 
            // textBox_密碼
            // 
            this.textBox_密碼.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox_密碼.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.textBox_密碼.Location = new System.Drawing.Point(368, 294);
            this.textBox_密碼.MaxLength = 15;
            this.textBox_密碼.Name = "textBox_密碼";
            this.textBox_密碼.Size = new System.Drawing.Size(200, 29);
            this.textBox_密碼.TabIndex = 5;
            this.textBox_密碼.TextChanged += new System.EventHandler(this.textBox_密碼_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp6.Properties.Resources.henn;
            this.pictureBox3.Location = new System.Drawing.Point(425, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(72, 75);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(292, 223);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(292, 294);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // radioBtn_Admin
            // 
            this.radioBtn_Admin.AutoSize = true;
            this.radioBtn_Admin.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioBtn_Admin.Image = global::WindowsFormsApp6.Properties.Resources.wrench;
            this.radioBtn_Admin.Location = new System.Drawing.Point(479, 145);
            this.radioBtn_Admin.Name = "radioBtn_Admin";
            this.radioBtn_Admin.Size = new System.Drawing.Size(89, 38);
            this.radioBtn_Admin.TabIndex = 3;
            this.radioBtn_Admin.Text = "        ";
            this.radioBtn_Admin.UseVisualStyleBackColor = true;
            // 
            // radioBtn_User
            // 
            this.radioBtn_User.AutoSize = true;
            this.radioBtn_User.Checked = true;
            this.radioBtn_User.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioBtn_User.Image = global::WindowsFormsApp6.Properties.Resources.user2;
            this.radioBtn_User.Location = new System.Drawing.Point(368, 145);
            this.radioBtn_User.Name = "radioBtn_User";
            this.radioBtn_User.Size = new System.Drawing.Size(82, 38);
            this.radioBtn_User.TabIndex = 2;
            this.radioBtn_User.TabStop = true;
            this.radioBtn_User.Text = "       ";
            this.radioBtn_User.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_密碼);
            this.Controls.Add(this.btn_登入);
            this.Controls.Add(this.radioBtn_Admin);
            this.Controls.Add(this.radioBtn_User);
            this.Controls.Add(this.textBox_帳號);
            this.Controls.Add(this.btn_註冊帳號);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form3";
            this.Text = "登入";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_註冊帳號;
        private System.Windows.Forms.TextBox textBox_帳號;
        private System.Windows.Forms.RadioButton radioBtn_User;
        private System.Windows.Forms.RadioButton radioBtn_Admin;
        private System.Windows.Forms.Button btn_登入;
        private System.Windows.Forms.TextBox textBox_密碼;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}