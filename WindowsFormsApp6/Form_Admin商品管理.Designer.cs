
namespace WindowsFormsApp6
{
    partial class Form_Admin商品管理
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
            this.components = new System.ComponentModel.Container();
            this.groupBox_修改商品 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox_新增商品 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt序號 = new System.Windows.Forms.TextBox();
            this.txt商品價格 = new System.Windows.Forms.TextBox();
            this.txt商品名稱 = new System.Windows.Forms.TextBox();
            this.地址 = new System.Windows.Forms.Label();
            this.姓名 = new System.Windows.Forms.Label();
            this.電話 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_儲存資料 = new System.Windows.Forms.Button();
            this.btn_新增商品 = new System.Windows.Forms.Button();
            this.btn_儲存修改 = new System.Windows.Forms.Button();
            this.btn_選取圖片 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_PhotoMode = new System.Windows.Forms.Button();
            this.btn_ListMode = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox_修改商品.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox_新增商品.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_修改商品
            // 
            this.groupBox_修改商品.Controls.Add(this.btn_儲存修改);
            this.groupBox_修改商品.Controls.Add(this.btn_選取圖片);
            this.groupBox_修改商品.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox_修改商品.Location = new System.Drawing.Point(0, 0);
            this.groupBox_修改商品.Name = "groupBox_修改商品";
            this.groupBox_修改商品.Size = new System.Drawing.Size(500, 127);
            this.groupBox_修改商品.TabIndex = 27;
            this.groupBox_修改商品.TabStop = false;
            this.groupBox_修改商品.Text = "修改商品";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox_新增商品);
            this.panel2.Controls.Add(this.groupBox_修改商品);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 415);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1068, 127);
            this.panel2.TabIndex = 30;
            // 
            // groupBox_新增商品
            // 
            this.groupBox_新增商品.Controls.Add(this.btn_儲存資料);
            this.groupBox_新增商品.Controls.Add(this.btn_新增商品);
            this.groupBox_新增商品.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_新增商品.Location = new System.Drawing.Point(500, 0);
            this.groupBox_新增商品.Name = "groupBox_新增商品";
            this.groupBox_新增商品.Size = new System.Drawing.Size(568, 127);
            this.groupBox_新增商品.TabIndex = 29;
            this.groupBox_新增商品.TabStop = false;
            this.groupBox_新增商品.Text = "新增商品";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 415);
            this.panel3.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(500, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 415);
            this.panel1.TabIndex = 33;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt序號
            // 
            this.txt序號.Location = new System.Drawing.Point(22, 100);
            this.txt序號.MaxLength = 30;
            this.txt序號.Name = "txt序號";
            this.txt序號.Size = new System.Drawing.Size(134, 29);
            this.txt序號.TabIndex = 21;
            // 
            // txt商品價格
            // 
            this.txt商品價格.Location = new System.Drawing.Point(22, 277);
            this.txt商品價格.MaxLength = 50;
            this.txt商品價格.Name = "txt商品價格";
            this.txt商品價格.Size = new System.Drawing.Size(134, 29);
            this.txt商品價格.TabIndex = 19;
            // 
            // txt商品名稱
            // 
            this.txt商品名稱.Location = new System.Drawing.Point(22, 186);
            this.txt商品名稱.MaxLength = 10;
            this.txt商品名稱.Name = "txt商品名稱";
            this.txt商品名稱.Size = new System.Drawing.Size(134, 29);
            this.txt商品名稱.TabIndex = 20;
            // 
            // 地址
            // 
            this.地址.AutoSize = true;
            this.地址.Location = new System.Drawing.Point(18, 254);
            this.地址.Name = "地址";
            this.地址.Size = new System.Drawing.Size(73, 20);
            this.地址.TabIndex = 22;
            this.地址.Text = "商品價格";
            // 
            // 姓名
            // 
            this.姓名.AutoSize = true;
            this.姓名.Location = new System.Drawing.Point(18, 77);
            this.姓名.Name = "姓名";
            this.姓名.Size = new System.Drawing.Size(41, 20);
            this.姓名.TabIndex = 24;
            this.姓名.Text = "序號";
            // 
            // 電話
            // 
            this.電話.AutoSize = true;
            this.電話.Location = new System.Drawing.Point(18, 163);
            this.電話.Name = "電話";
            this.電話.Size = new System.Drawing.Size(73, 20);
            this.電話.TabIndex = 23;
            this.電話.Text = "商品名稱";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(256, 256);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 415);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // btn_儲存資料
            // 
            this.btn_儲存資料.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_儲存資料.FlatAppearance.BorderSize = 0;
            this.btn_儲存資料.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_儲存資料.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_儲存資料.Image = global::WindowsFormsApp6.Properties.Resources.paper_plane;
            this.btn_儲存資料.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_儲存資料.Location = new System.Drawing.Point(183, 25);
            this.btn_儲存資料.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_儲存資料.Name = "btn_儲存資料";
            this.btn_儲存資料.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btn_儲存資料.Size = new System.Drawing.Size(158, 99);
            this.btn_儲存資料.TabIndex = 55;
            this.btn_儲存資料.Text = "     確認送出";
            this.btn_儲存資料.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_儲存資料.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_儲存資料.UseVisualStyleBackColor = true;
            this.btn_儲存資料.Click += new System.EventHandler(this.btn_儲存資料_Click);
            // 
            // btn_新增商品
            // 
            this.btn_新增商品.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_新增商品.FlatAppearance.BorderSize = 0;
            this.btn_新增商品.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_新增商品.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_新增商品.Image = global::WindowsFormsApp6.Properties.Resources.plus2;
            this.btn_新增商品.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_新增商品.Location = new System.Drawing.Point(3, 25);
            this.btn_新增商品.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_新增商品.Name = "btn_新增商品";
            this.btn_新增商品.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btn_新增商品.Size = new System.Drawing.Size(180, 99);
            this.btn_新增商品.TabIndex = 53;
            this.btn_新增商品.Text = "     新增商品";
            this.btn_新增商品.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_新增商品.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_新增商品.UseVisualStyleBackColor = true;
            this.btn_新增商品.Click += new System.EventHandler(this.btn_新增商品_Click);
            // 
            // btn_儲存修改
            // 
            this.btn_儲存修改.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_儲存修改.FlatAppearance.BorderSize = 0;
            this.btn_儲存修改.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_儲存修改.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_儲存修改.Image = global::WindowsFormsApp6.Properties.Resources.save;
            this.btn_儲存修改.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_儲存修改.Location = new System.Drawing.Point(183, 25);
            this.btn_儲存修改.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_儲存修改.Name = "btn_儲存修改";
            this.btn_儲存修改.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btn_儲存修改.Size = new System.Drawing.Size(180, 99);
            this.btn_儲存修改.TabIndex = 53;
            this.btn_儲存修改.Text = "     儲存修改";
            this.btn_儲存修改.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_儲存修改.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_儲存修改.UseVisualStyleBackColor = true;
            this.btn_儲存修改.Click += new System.EventHandler(this.btn_儲存修改_Click);
            // 
            // btn_選取圖片
            // 
            this.btn_選取圖片.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_選取圖片.FlatAppearance.BorderSize = 0;
            this.btn_選取圖片.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_選取圖片.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_選取圖片.Image = global::WindowsFormsApp6.Properties.Resources.image__1_;
            this.btn_選取圖片.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_選取圖片.Location = new System.Drawing.Point(3, 25);
            this.btn_選取圖片.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_選取圖片.Name = "btn_選取圖片";
            this.btn_選取圖片.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btn_選取圖片.Size = new System.Drawing.Size(180, 99);
            this.btn_選取圖片.TabIndex = 52;
            this.btn_選取圖片.Text = "     更換圖片";
            this.btn_選取圖片.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_選取圖片.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_選取圖片.UseVisualStyleBackColor = true;
            this.btn_選取圖片.Click += new System.EventHandler(this.btn_選取圖片_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txt序號);
            this.panel5.Controls.Add(this.電話);
            this.panel5.Controls.Add(this.姓名);
            this.panel5.Controls.Add(this.txt商品價格);
            this.panel5.Controls.Add(this.地址);
            this.panel5.Controls.Add(this.txt商品名稱);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(391, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(177, 415);
            this.panel5.TabIndex = 70;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Control;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 60);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(391, 355);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Refresh.Image = global::WindowsFormsApp6.Properties.Resources.refresh;
            this.btn_Refresh.Location = new System.Drawing.Point(261, 0);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(130, 60);
            this.btn_Refresh.TabIndex = 69;
            this.btn_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_PhotoMode
            // 
            this.btn_PhotoMode.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_PhotoMode.FlatAppearance.BorderSize = 0;
            this.btn_PhotoMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PhotoMode.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_PhotoMode.Image = global::WindowsFormsApp6.Properties.Resources.image_gallery;
            this.btn_PhotoMode.Location = new System.Drawing.Point(0, 0);
            this.btn_PhotoMode.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_PhotoMode.Name = "btn_PhotoMode";
            this.btn_PhotoMode.Size = new System.Drawing.Size(132, 60);
            this.btn_PhotoMode.TabIndex = 68;
            this.btn_PhotoMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PhotoMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_PhotoMode.UseVisualStyleBackColor = true;
            this.btn_PhotoMode.Click += new System.EventHandler(this.btn_PhotoMode_Click);
            // 
            // btn_ListMode
            // 
            this.btn_ListMode.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_ListMode.FlatAppearance.BorderSize = 0;
            this.btn_ListMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ListMode.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ListMode.Image = global::WindowsFormsApp6.Properties.Resources.task;
            this.btn_ListMode.Location = new System.Drawing.Point(132, 0);
            this.btn_ListMode.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_ListMode.Name = "btn_ListMode";
            this.btn_ListMode.Size = new System.Drawing.Size(132, 60);
            this.btn_ListMode.TabIndex = 67;
            this.btn_ListMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ListMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ListMode.UseVisualStyleBackColor = true;
            this.btn_ListMode.Click += new System.EventHandler(this.btn_ListMode_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_ListMode);
            this.panel4.Controls.Add(this.btn_PhotoMode);
            this.panel4.Controls.Add(this.btn_Refresh);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(391, 60);
            this.panel4.TabIndex = 71;
            // 
            // Form_Admin商品管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 542);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form_Admin商品管理";
            this.Text = "商品管理";
            this.Load += new System.EventHandler(this.Form_Admin商品管理_Load);
            this.groupBox_修改商品.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox_新增商品.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_修改商品;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox_新增商品;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt序號;
        private System.Windows.Forms.TextBox txt商品價格;
        private System.Windows.Forms.TextBox txt商品名稱;
        private System.Windows.Forms.Label 地址;
        private System.Windows.Forms.Label 姓名;
        private System.Windows.Forms.Label 電話;
        private System.Windows.Forms.Button btn_選取圖片;
        private System.Windows.Forms.Button btn_儲存修改;
        private System.Windows.Forms.Button btn_儲存資料;
        private System.Windows.Forms.Button btn_新增商品;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_ListMode;
        private System.Windows.Forms.Button btn_PhotoMode;
        private System.Windows.Forms.Button btn_Refresh;
    }
}