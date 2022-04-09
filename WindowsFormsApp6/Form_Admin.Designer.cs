
namespace WindowsFormsApp6
{
    partial class Form_Admin
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
            this.姓名 = new System.Windows.Forms.Label();
            this.員工編號 = new System.Windows.Forms.Label();
            this.textBox_姓名 = new System.Windows.Forms.TextBox();
            this.textBox_員工編號 = new System.Windows.Forms.TextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.btn_登出 = new System.Windows.Forms.Button();
            this.btn_員工管理 = new System.Windows.Forms.Button();
            this.btn_會員管理 = new System.Windows.Forms.Button();
            this.btn_商品管理 = new System.Windows.Forms.Button();
            this.btn_訂單管理 = new System.Windows.Forms.Button();
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.btn_管理系統 = new System.Windows.Forms.Button();
            this.panel_NavBar = new System.Windows.Forms.Panel();
            this.panel_Desktop = new System.Windows.Forms.Panel();
            this.panel_Menu.SuspendLayout();
            this.panel_Logo.SuspendLayout();
            this.panel_NavBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // 姓名
            // 
            this.姓名.AutoSize = true;
            this.姓名.Location = new System.Drawing.Point(830, 43);
            this.姓名.Name = "姓名";
            this.姓名.Size = new System.Drawing.Size(41, 20);
            this.姓名.TabIndex = 62;
            this.姓名.Text = "姓名";
            // 
            // 員工編號
            // 
            this.員工編號.AutoSize = true;
            this.員工編號.Location = new System.Drawing.Point(496, 43);
            this.員工編號.Name = "員工編號";
            this.員工編號.Size = new System.Drawing.Size(73, 20);
            this.員工編號.TabIndex = 54;
            this.員工編號.Text = "員工編號";
            // 
            // textBox_姓名
            // 
            this.textBox_姓名.Enabled = false;
            this.textBox_姓名.Location = new System.Drawing.Point(905, 43);
            this.textBox_姓名.Name = "textBox_姓名";
            this.textBox_姓名.Size = new System.Drawing.Size(200, 29);
            this.textBox_姓名.TabIndex = 52;
            // 
            // textBox_員工編號
            // 
            this.textBox_員工編號.Enabled = false;
            this.textBox_員工編號.Location = new System.Drawing.Point(590, 40);
            this.textBox_員工編號.Name = "textBox_員工編號";
            this.textBox_員工編號.Size = new System.Drawing.Size(200, 29);
            this.textBox_員工編號.TabIndex = 46;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_Title.Location = new System.Drawing.Point(472, 37);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(110, 31);
            this.lbl_Title.TabIndex = 76;
            this.lbl_Title.Text = "管理系統";
            this.lbl_Title.Click += new System.EventHandler(this.lbl_管理系統_Click);
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.panel_Menu.Controls.Add(this.btn_登出);
            this.panel_Menu.Controls.Add(this.btn_員工管理);
            this.panel_Menu.Controls.Add(this.btn_會員管理);
            this.panel_Menu.Controls.Add(this.btn_商品管理);
            this.panel_Menu.Controls.Add(this.btn_訂單管理);
            this.panel_Menu.Controls.Add(this.panel_Logo);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(180, 681);
            this.panel_Menu.TabIndex = 81;
            // 
            // btn_登出
            // 
            this.btn_登出.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_登出.FlatAppearance.BorderSize = 0;
            this.btn_登出.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_登出.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btn_登出.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_登出.Image = global::WindowsFormsApp6.Properties.Resources.log_out1;
            this.btn_登出.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_登出.Location = new System.Drawing.Point(0, 460);
            this.btn_登出.Name = "btn_登出";
            this.btn_登出.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_登出.Size = new System.Drawing.Size(180, 90);
            this.btn_登出.TabIndex = 77;
            this.btn_登出.Text = "        登出";
            this.btn_登出.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_登出.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_登出.UseVisualStyleBackColor = true;
            this.btn_登出.Click += new System.EventHandler(this.btn_登出_Click);
            // 
            // btn_員工管理
            // 
            this.btn_員工管理.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_員工管理.FlatAppearance.BorderSize = 0;
            this.btn_員工管理.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_員工管理.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_員工管理.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_員工管理.Image = global::WindowsFormsApp6.Properties.Resources.profile1;
            this.btn_員工管理.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_員工管理.Location = new System.Drawing.Point(0, 370);
            this.btn_員工管理.Name = "btn_員工管理";
            this.btn_員工管理.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btn_員工管理.Size = new System.Drawing.Size(180, 90);
            this.btn_員工管理.TabIndex = 76;
            this.btn_員工管理.Text = "     員工管理";
            this.btn_員工管理.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_員工管理.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_員工管理.UseVisualStyleBackColor = true;
            this.btn_員工管理.Click += new System.EventHandler(this.btn_員工管理_Click);
            // 
            // btn_會員管理
            // 
            this.btn_會員管理.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_會員管理.FlatAppearance.BorderSize = 0;
            this.btn_會員管理.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_會員管理.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_會員管理.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_會員管理.Image = global::WindowsFormsApp6.Properties.Resources.edit3;
            this.btn_會員管理.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_會員管理.Location = new System.Drawing.Point(0, 280);
            this.btn_會員管理.Name = "btn_會員管理";
            this.btn_會員管理.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btn_會員管理.Size = new System.Drawing.Size(180, 90);
            this.btn_會員管理.TabIndex = 75;
            this.btn_會員管理.Text = "     會員管理";
            this.btn_會員管理.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_會員管理.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_會員管理.UseVisualStyleBackColor = true;
            this.btn_會員管理.Click += new System.EventHandler(this.btn_會員管理_Click);
            // 
            // btn_商品管理
            // 
            this.btn_商品管理.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_商品管理.FlatAppearance.BorderSize = 0;
            this.btn_商品管理.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_商品管理.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_商品管理.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_商品管理.Image = global::WindowsFormsApp6.Properties.Resources.cart1;
            this.btn_商品管理.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_商品管理.Location = new System.Drawing.Point(0, 190);
            this.btn_商品管理.Name = "btn_商品管理";
            this.btn_商品管理.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btn_商品管理.Size = new System.Drawing.Size(180, 90);
            this.btn_商品管理.TabIndex = 72;
            this.btn_商品管理.Text = "      商品管理";
            this.btn_商品管理.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_商品管理.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_商品管理.UseVisualStyleBackColor = true;
            this.btn_商品管理.Click += new System.EventHandler(this.btn_商品管理_Click);
            // 
            // btn_訂單管理
            // 
            this.btn_訂單管理.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_訂單管理.FlatAppearance.BorderSize = 0;
            this.btn_訂單管理.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_訂單管理.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_訂單管理.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_訂單管理.Image = global::WindowsFormsApp6.Properties.Resources.edit2;
            this.btn_訂單管理.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_訂單管理.Location = new System.Drawing.Point(0, 100);
            this.btn_訂單管理.Name = "btn_訂單管理";
            this.btn_訂單管理.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btn_訂單管理.Size = new System.Drawing.Size(180, 90);
            this.btn_訂單管理.TabIndex = 72;
            this.btn_訂單管理.Text = "     訂單管理";
            this.btn_訂單管理.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_訂單管理.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_訂單管理.UseVisualStyleBackColor = true;
            this.btn_訂單管理.Click += new System.EventHandler(this.btn_訂單管理_Click);
            // 
            // panel_Logo
            // 
            this.panel_Logo.BackColor = System.Drawing.Color.Tan;
            this.panel_Logo.Controls.Add(this.btn_管理系統);
            this.panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.Size = new System.Drawing.Size(180, 100);
            this.panel_Logo.TabIndex = 0;
            this.panel_Logo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Logo_Paint);
            // 
            // btn_管理系統
            // 
            this.btn_管理系統.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btn_管理系統.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_管理系統.FlatAppearance.BorderSize = 0;
            this.btn_管理系統.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_管理系統.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btn_管理系統.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_管理系統.Image = global::WindowsFormsApp6.Properties.Resources.wrench;
            this.btn_管理系統.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_管理系統.Location = new System.Drawing.Point(0, 0);
            this.btn_管理系統.Name = "btn_管理系統";
            this.btn_管理系統.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_管理系統.Size = new System.Drawing.Size(180, 100);
            this.btn_管理系統.TabIndex = 81;
            this.btn_管理系統.Text = "     管理系統";
            this.btn_管理系統.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_管理系統.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_管理系統.UseVisualStyleBackColor = false;
            this.btn_管理系統.Click += new System.EventHandler(this.btn_管理系統_Click);
            // 
            // panel_NavBar
            // 
            this.panel_NavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.panel_NavBar.Controls.Add(this.lbl_Title);
            this.panel_NavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_NavBar.Location = new System.Drawing.Point(180, 0);
            this.panel_NavBar.Name = "panel_NavBar";
            this.panel_NavBar.Size = new System.Drawing.Size(1084, 100);
            this.panel_NavBar.TabIndex = 82;
            this.panel_NavBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel_Desktop
            // 
            this.panel_Desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Desktop.Location = new System.Drawing.Point(180, 100);
            this.panel_Desktop.Name = "panel_Desktop";
            this.panel_Desktop.Size = new System.Drawing.Size(1084, 581);
            this.panel_Desktop.TabIndex = 83;
            this.panel_Desktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel_Desktop);
            this.Controls.Add(this.panel_NavBar);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.姓名);
            this.Controls.Add(this.員工編號);
            this.Controls.Add(this.textBox_姓名);
            this.Controls.Add(this.textBox_員工編號);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_Admin";
            this.Text = "AdminMainMenu";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.panel_Menu.ResumeLayout(false);
            this.panel_Logo.ResumeLayout(false);
            this.panel_NavBar.ResumeLayout(false);
            this.panel_NavBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label 姓名;
        private System.Windows.Forms.Label 員工編號;
        private System.Windows.Forms.TextBox textBox_姓名;
        private System.Windows.Forms.TextBox textBox_員工編號;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Button btn_訂單管理;
        private System.Windows.Forms.Panel panel_NavBar;
        private System.Windows.Forms.Button btn_員工管理;
        private System.Windows.Forms.Button btn_會員管理;
        private System.Windows.Forms.Button btn_商品管理;
        private System.Windows.Forms.Button btn_登出;
        private System.Windows.Forms.Panel panel_Desktop;
        private System.Windows.Forms.Panel panel_Logo;
        private System.Windows.Forms.Button btn_管理系統;
    }
}