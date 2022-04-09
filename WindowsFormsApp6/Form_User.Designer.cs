
namespace WindowsFormsApp6
{
    partial class Form_User
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.myDBDataSet = new WindowsFormsApp6.MyDBDataSet();
            this.drinkProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drinkProductTableAdapter = new WindowsFormsApp6.MyDBDataSetTableAdapters.DrinkProductTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp6.MyDBDataSetTableAdapters.TableAdapterManager();
            this.lbl_帳號 = new System.Windows.Forms.Label();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.btn_新增至購物車 = new System.Windows.Forms.Button();
            this.btn_查看購物車 = new System.Windows.Forms.Button();
            this.btn_最愛商品 = new System.Windows.Forms.Button();
            this.btn_訂購紀錄 = new System.Windows.Forms.Button();
            this.btn_修改會員資料 = new System.Windows.Forms.Button();
            this.btn_登出會員 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_鹹酥雞訂購 = new System.Windows.Forms.Button();
            this.panel_NavBar = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panel_Desktop = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.btn_ListMode = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.btn_PhotoMode = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.lbl_TotalPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_TotalCup = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.lbl品項總價幾元 = new System.Windows.Forms.Label();
            this.lbl小計 = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.numUpDown_CupNum = new System.Windows.Forms.NumericUpDown();
            this.lbl杯數 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.comboBox辣度 = new System.Windows.Forms.ComboBox();
            this.lbl甜度 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.comboBox配料 = new System.Windows.Forms.ComboBox();
            this.lbl配料 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl單價幾元 = new System.Windows.Forms.Label();
            this.lbl單價 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt商品名稱 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox商品品項 = new System.Windows.Forms.ListBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinkProductBindingSource)).BeginInit();
            this.panel_Menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_NavBar.SuspendLayout();
            this.panel_Desktop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_CupNum)).BeginInit();
            this.panel19.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // myDBDataSet
            // 
            this.myDBDataSet.DataSetName = "MyDBDataSet";
            this.myDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // drinkProductBindingSource
            // 
            this.drinkProductBindingSource.DataMember = "DrinkProduct";
            this.drinkProductBindingSource.DataSource = this.myDBDataSet;
            // 
            // drinkProductTableAdapter
            // 
            this.drinkProductTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.DrinkOrderDetailsTableAdapter = null;
            this.tableAdapterManager.DrinkOrderTableAdapter = null;
            this.tableAdapterManager.DrinkProductTableAdapter = this.drinkProductTableAdapter;
            this.tableAdapterManager.DrinkToppingTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.personsTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp6.MyDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lbl_帳號
            // 
            this.lbl_帳號.BackColor = System.Drawing.Color.BurlyWood;
            this.lbl_帳號.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_帳號.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_帳號.Location = new System.Drawing.Point(52, 593);
            this.lbl_帳號.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_帳號.Name = "lbl_帳號";
            this.lbl_帳號.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_帳號.Size = new System.Drawing.Size(80, 30);
            this.lbl_帳號.TabIndex = 46;
            this.lbl_帳號.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.BurlyWood;
            this.panel_Menu.Controls.Add(this.btn_新增至購物車);
            this.panel_Menu.Controls.Add(this.lbl_帳號);
            this.panel_Menu.Controls.Add(this.btn_查看購物車);
            this.panel_Menu.Controls.Add(this.btn_最愛商品);
            this.panel_Menu.Controls.Add(this.btn_訂購紀錄);
            this.panel_Menu.Controls.Add(this.btn_修改會員資料);
            this.panel_Menu.Controls.Add(this.btn_登出會員);
            this.panel_Menu.Controls.Add(this.panel1);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(192, 691);
            this.panel_Menu.TabIndex = 47;
            this.panel_Menu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_新增至購物車
            // 
            this.btn_新增至購物車.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_新增至購物車.FlatAppearance.BorderSize = 0;
            this.btn_新增至購物車.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_新增至購物車.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_新增至購物車.Image = global::WindowsFormsApp6.Properties.Resources.add_to_cart;
            this.btn_新增至購物車.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_新增至購物車.Location = new System.Drawing.Point(0, 500);
            this.btn_新增至購物車.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_新增至購物車.Name = "btn_新增至購物車";
            this.btn_新增至購物車.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btn_新增至購物車.Size = new System.Drawing.Size(192, 80);
            this.btn_新增至購物車.TabIndex = 51;
            this.btn_新增至購物車.Text = "     新增購物車";
            this.btn_新增至購物車.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_新增至購物車.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_新增至購物車.UseVisualStyleBackColor = true;
            this.btn_新增至購物車.Click += new System.EventHandler(this.btn加入訂購單_Click);
            // 
            // btn_查看購物車
            // 
            this.btn_查看購物車.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_查看購物車.FlatAppearance.BorderSize = 0;
            this.btn_查看購物車.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_查看購物車.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_查看購物車.Image = global::WindowsFormsApp6.Properties.Resources.shopping_cart__1_;
            this.btn_查看購物車.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_查看購物車.Location = new System.Drawing.Point(0, 420);
            this.btn_查看購物車.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_查看購物車.Name = "btn_查看購物車";
            this.btn_查看購物車.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btn_查看購物車.Size = new System.Drawing.Size(192, 80);
            this.btn_查看購物車.TabIndex = 50;
            this.btn_查看購物車.Text = "     查看購物車";
            this.btn_查看購物車.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_查看購物車.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_查看購物車.UseVisualStyleBackColor = true;
            this.btn_查看購物車.Click += new System.EventHandler(this.btn查看訂購單_Click);
            // 
            // btn_最愛商品
            // 
            this.btn_最愛商品.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_最愛商品.FlatAppearance.BorderSize = 0;
            this.btn_最愛商品.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_最愛商品.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_最愛商品.Image = global::WindowsFormsApp6.Properties.Resources.wishlist;
            this.btn_最愛商品.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_最愛商品.Location = new System.Drawing.Point(0, 340);
            this.btn_最愛商品.Name = "btn_最愛商品";
            this.btn_最愛商品.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btn_最愛商品.Size = new System.Drawing.Size(192, 80);
            this.btn_最愛商品.TabIndex = 49;
            this.btn_最愛商品.Text = "     最愛商品";
            this.btn_最愛商品.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_最愛商品.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_最愛商品.UseVisualStyleBackColor = true;
            this.btn_最愛商品.Click += new System.EventHandler(this.btn_最愛商品_Click);
            // 
            // btn_訂購紀錄
            // 
            this.btn_訂購紀錄.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_訂購紀錄.FlatAppearance.BorderSize = 0;
            this.btn_訂購紀錄.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_訂購紀錄.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_訂購紀錄.Image = global::WindowsFormsApp6.Properties.Resources.dollar;
            this.btn_訂購紀錄.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_訂購紀錄.Location = new System.Drawing.Point(0, 260);
            this.btn_訂購紀錄.Name = "btn_訂購紀錄";
            this.btn_訂購紀錄.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btn_訂購紀錄.Size = new System.Drawing.Size(192, 80);
            this.btn_訂購紀錄.TabIndex = 43;
            this.btn_訂購紀錄.Text = "     訂購紀錄";
            this.btn_訂購紀錄.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_訂購紀錄.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_訂購紀錄.UseVisualStyleBackColor = true;
            this.btn_訂購紀錄.Click += new System.EventHandler(this.btn_訂購紀錄_Click);
            // 
            // btn_修改會員資料
            // 
            this.btn_修改會員資料.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_修改會員資料.FlatAppearance.BorderSize = 0;
            this.btn_修改會員資料.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_修改會員資料.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_修改會員資料.Image = global::WindowsFormsApp6.Properties.Resources.editt;
            this.btn_修改會員資料.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_修改會員資料.Location = new System.Drawing.Point(0, 180);
            this.btn_修改會員資料.Name = "btn_修改會員資料";
            this.btn_修改會員資料.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btn_修改會員資料.Size = new System.Drawing.Size(192, 80);
            this.btn_修改會員資料.TabIndex = 45;
            this.btn_修改會員資料.Text = "     修改資料";
            this.btn_修改會員資料.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_修改會員資料.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_修改會員資料.UseVisualStyleBackColor = true;
            this.btn_修改會員資料.Click += new System.EventHandler(this.btn_修改會員資料_Click);
            // 
            // btn_登出會員
            // 
            this.btn_登出會員.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_登出會員.FlatAppearance.BorderSize = 0;
            this.btn_登出會員.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_登出會員.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_登出會員.Image = global::WindowsFormsApp6.Properties.Resources.log_out1;
            this.btn_登出會員.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_登出會員.Location = new System.Drawing.Point(0, 100);
            this.btn_登出會員.Name = "btn_登出會員";
            this.btn_登出會員.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btn_登出會員.Size = new System.Drawing.Size(192, 80);
            this.btn_登出會員.TabIndex = 42;
            this.btn_登出會員.Text = "     登出會員";
            this.btn_登出會員.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_登出會員.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_登出會員.UseVisualStyleBackColor = true;
            this.btn_登出會員.Click += new System.EventHandler(this.btn_登出會員_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.btn_鹹酥雞訂購);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 100);
            this.panel1.TabIndex = 0;
            // 
            // btn_鹹酥雞訂購
            // 
            this.btn_鹹酥雞訂購.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_鹹酥雞訂購.FlatAppearance.BorderSize = 0;
            this.btn_鹹酥雞訂購.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_鹹酥雞訂購.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_鹹酥雞訂購.Image = global::WindowsFormsApp6.Properties.Resources.hen2;
            this.btn_鹹酥雞訂購.Location = new System.Drawing.Point(0, 0);
            this.btn_鹹酥雞訂購.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_鹹酥雞訂購.Name = "btn_鹹酥雞訂購";
            this.btn_鹹酥雞訂購.Size = new System.Drawing.Size(192, 100);
            this.btn_鹹酥雞訂購.TabIndex = 52;
            this.btn_鹹酥雞訂購.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_鹹酥雞訂購.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_鹹酥雞訂購.UseVisualStyleBackColor = true;
            this.btn_鹹酥雞訂購.Click += new System.EventHandler(this.btn_鹹酥雞訂購_Click);
            // 
            // panel_NavBar
            // 
            this.panel_NavBar.BackColor = System.Drawing.Color.BurlyWood;
            this.panel_NavBar.Controls.Add(this.lbl_Title);
            this.panel_NavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_NavBar.Location = new System.Drawing.Point(192, 0);
            this.panel_NavBar.Name = "panel_NavBar";
            this.panel_NavBar.Size = new System.Drawing.Size(1072, 100);
            this.panel_NavBar.TabIndex = 48;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_Title.Location = new System.Drawing.Point(466, 40);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(117, 26);
            this.lbl_Title.TabIndex = 77;
            this.lbl_Title.Text = "香香雞訂購";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Desktop
            // 
            this.panel_Desktop.Controls.Add(this.groupBox1);
            this.panel_Desktop.Controls.Add(this.listBox商品品項);
            this.panel_Desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Desktop.Location = new System.Drawing.Point(192, 100);
            this.panel_Desktop.Name = "panel_Desktop";
            this.panel_Desktop.Size = new System.Drawing.Size(1072, 591);
            this.panel_Desktop.TabIndex = 49;
            this.panel_Desktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Desktop_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Location = new System.Drawing.Point(9, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1051, 556);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.listView1);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(511, 25);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(537, 428);
            this.panel7.TabIndex = 70;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Control;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 55);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(500, 351);
            this.listView1.TabIndex = 61;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel17);
            this.panel8.Controls.Add(this.panel16);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(537, 50);
            this.panel8.TabIndex = 0;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.btn_ListMode);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel17.Location = new System.Drawing.Point(250, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(250, 50);
            this.panel17.TabIndex = 1;
            // 
            // btn_ListMode
            // 
            this.btn_ListMode.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_ListMode.FlatAppearance.BorderSize = 0;
            this.btn_ListMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ListMode.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ListMode.Image = global::WindowsFormsApp6.Properties.Resources.task;
            this.btn_ListMode.Location = new System.Drawing.Point(0, 0);
            this.btn_ListMode.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_ListMode.Name = "btn_ListMode";
            this.btn_ListMode.Size = new System.Drawing.Size(250, 50);
            this.btn_ListMode.TabIndex = 64;
            this.btn_ListMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ListMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ListMode.UseVisualStyleBackColor = true;
            this.btn_ListMode.Click += new System.EventHandler(this.btn_ListMode_Click);
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.btn_PhotoMode);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel16.Location = new System.Drawing.Point(0, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(250, 50);
            this.panel16.TabIndex = 0;
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
            this.btn_PhotoMode.Size = new System.Drawing.Size(250, 50);
            this.btn_PhotoMode.TabIndex = 65;
            this.btn_PhotoMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PhotoMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_PhotoMode.UseVisualStyleBackColor = true;
            this.btn_PhotoMode.Click += new System.EventHandler(this.btn_PhotoMode_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(3, 25);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(500, 428);
            this.panel6.TabIndex = 69;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 406);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel23);
            this.panel3.Controls.Add(this.panel22);
            this.panel3.Controls.Add(this.panel21);
            this.panel3.Controls.Add(this.panel20);
            this.panel3.Controls.Add(this.panel19);
            this.panel3.Controls.Add(this.panel15);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 453);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1045, 100);
            this.panel3.TabIndex = 68;
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.lbl_TotalPrice);
            this.panel23.Controls.Add(this.label5);
            this.panel23.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel23.Location = new System.Drawing.Point(960, 0);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(100, 100);
            this.panel23.TabIndex = 7;
            // 
            // lbl_TotalPrice
            // 
            this.lbl_TotalPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_TotalPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_TotalPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_TotalPrice.Location = new System.Drawing.Point(0, 40);
            this.lbl_TotalPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_TotalPrice.Name = "lbl_TotalPrice";
            this.lbl_TotalPrice.Size = new System.Drawing.Size(100, 63);
            this.lbl_TotalPrice.TabIndex = 60;
            this.lbl_TotalPrice.Text = "  ____ 元";
            this.lbl_TotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 40);
            this.label5.TabIndex = 58;
            this.label5.Text = "總金額";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.label4);
            this.panel22.Controls.Add(this.lbl_TotalCup);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel22.Location = new System.Drawing.Point(860, 0);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(100, 100);
            this.panel22.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 40);
            this.label4.TabIndex = 57;
            this.label4.Text = "總份數";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_TotalCup
            // 
            this.lbl_TotalCup.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_TotalCup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_TotalCup.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_TotalCup.Location = new System.Drawing.Point(0, 40);
            this.lbl_TotalCup.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_TotalCup.Name = "lbl_TotalCup";
            this.lbl_TotalCup.Size = new System.Drawing.Size(100, 60);
            this.lbl_TotalCup.TabIndex = 59;
            this.lbl_TotalCup.Text = "  ____ 杯";
            this.lbl_TotalCup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.lbl品項總價幾元);
            this.panel21.Controls.Add(this.lbl小計);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel21.Location = new System.Drawing.Point(770, 0);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(90, 100);
            this.panel21.TabIndex = 5;
            // 
            // lbl品項總價幾元
            // 
            this.lbl品項總價幾元.BackColor = System.Drawing.SystemColors.Control;
            this.lbl品項總價幾元.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl品項總價幾元.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl品項總價幾元.Location = new System.Drawing.Point(0, 40);
            this.lbl品項總價幾元.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl品項總價幾元.Name = "lbl品項總價幾元";
            this.lbl品項總價幾元.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.lbl品項總價幾元.Size = new System.Drawing.Size(90, 60);
            this.lbl品項總價幾元.TabIndex = 53;
            this.lbl品項總價幾元.Text = "   ____ 元";
            this.lbl品項總價幾元.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl小計
            // 
            this.lbl小計.BackColor = System.Drawing.SystemColors.Control;
            this.lbl小計.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl小計.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl小計.Location = new System.Drawing.Point(0, 0);
            this.lbl小計.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl小計.Name = "lbl小計";
            this.lbl小計.Size = new System.Drawing.Size(90, 40);
            this.lbl小計.TabIndex = 49;
            this.lbl小計.Text = "小計";
            this.lbl小計.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.numUpDown_CupNum);
            this.panel20.Controls.Add(this.lbl杯數);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel20.Location = new System.Drawing.Point(680, 0);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(90, 100);
            this.panel20.TabIndex = 4;
            // 
            // numUpDown_CupNum
            // 
            this.numUpDown_CupNum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numUpDown_CupNum.Location = new System.Drawing.Point(0, 51);
            this.numUpDown_CupNum.Margin = new System.Windows.Forms.Padding(4);
            this.numUpDown_CupNum.Name = "numUpDown_CupNum";
            this.numUpDown_CupNum.Size = new System.Drawing.Size(90, 29);
            this.numUpDown_CupNum.TabIndex = 56;
            this.numUpDown_CupNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDown_CupNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_CupNum.ValueChanged += new System.EventHandler(this.numUpDown_CupNum_ValueChanged);
            // 
            // lbl杯數
            // 
            this.lbl杯數.BackColor = System.Drawing.SystemColors.Control;
            this.lbl杯數.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl杯數.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl杯數.Location = new System.Drawing.Point(0, 0);
            this.lbl杯數.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl杯數.Name = "lbl杯數";
            this.lbl杯數.Size = new System.Drawing.Size(90, 40);
            this.lbl杯數.TabIndex = 47;
            this.lbl杯數.Text = "份數";
            this.lbl杯數.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.comboBox辣度);
            this.panel19.Controls.Add(this.lbl甜度);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel19.Location = new System.Drawing.Point(590, 0);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(90, 100);
            this.panel19.TabIndex = 3;
            // 
            // comboBox辣度
            // 
            this.comboBox辣度.BackColor = System.Drawing.Color.White;
            this.comboBox辣度.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox辣度.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox辣度.FormattingEnabled = true;
            this.comboBox辣度.Location = new System.Drawing.Point(0, 52);
            this.comboBox辣度.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.comboBox辣度.Name = "comboBox辣度";
            this.comboBox辣度.Size = new System.Drawing.Size(90, 28);
            this.comboBox辣度.TabIndex = 54;
            // 
            // lbl甜度
            // 
            this.lbl甜度.BackColor = System.Drawing.SystemColors.Control;
            this.lbl甜度.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl甜度.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl甜度.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl甜度.Location = new System.Drawing.Point(0, 0);
            this.lbl甜度.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl甜度.Name = "lbl甜度";
            this.lbl甜度.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl甜度.Size = new System.Drawing.Size(90, 40);
            this.lbl甜度.TabIndex = 50;
            this.lbl甜度.Text = "辣度";
            this.lbl甜度.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.comboBox配料);
            this.panel15.Controls.Add(this.lbl配料);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel15.Location = new System.Drawing.Point(500, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(90, 100);
            this.panel15.TabIndex = 2;
            // 
            // comboBox配料
            // 
            this.comboBox配料.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox配料.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox配料.FormattingEnabled = true;
            this.comboBox配料.Location = new System.Drawing.Point(0, 52);
            this.comboBox配料.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.comboBox配料.Name = "comboBox配料";
            this.comboBox配料.Size = new System.Drawing.Size(90, 28);
            this.comboBox配料.TabIndex = 55;
            this.comboBox配料.SelectedIndexChanged += new System.EventHandler(this.comboBox配料_SelectedIndexChanged);
            // 
            // lbl配料
            // 
            this.lbl配料.BackColor = System.Drawing.SystemColors.Control;
            this.lbl配料.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl配料.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl配料.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl配料.Location = new System.Drawing.Point(0, 0);
            this.lbl配料.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl配料.Name = "lbl配料";
            this.lbl配料.Size = new System.Drawing.Size(90, 40);
            this.lbl配料.TabIndex = 51;
            this.lbl配料.Text = "配料";
            this.lbl配料.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbl單價幾元);
            this.panel5.Controls.Add(this.lbl單價);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(300, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 1;
            // 
            // lbl單價幾元
            // 
            this.lbl單價幾元.BackColor = System.Drawing.SystemColors.Control;
            this.lbl單價幾元.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl單價幾元.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl單價幾元.Location = new System.Drawing.Point(0, 40);
            this.lbl單價幾元.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl單價幾元.Name = "lbl單價幾元";
            this.lbl單價幾元.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.lbl單價幾元.Size = new System.Drawing.Size(200, 60);
            this.lbl單價幾元.TabIndex = 52;
            this.lbl單價幾元.Text = "  ____ 元";
            this.lbl單價幾元.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl單價
            // 
            this.lbl單價.BackColor = System.Drawing.SystemColors.Control;
            this.lbl單價.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl單價.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl單價.Location = new System.Drawing.Point(0, 0);
            this.lbl單價.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl單價.Name = "lbl單價";
            this.lbl單價.Size = new System.Drawing.Size(200, 40);
            this.lbl單價.TabIndex = 48;
            this.lbl單價.Text = "單價";
            this.lbl單價.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txt商品名稱);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 100);
            this.panel4.TabIndex = 0;
            // 
            // txt商品名稱
            // 
            this.txt商品名稱.BackColor = System.Drawing.SystemColors.Control;
            this.txt商品名稱.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt商品名稱.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt商品名稱.Location = new System.Drawing.Point(0, 40);
            this.txt商品名稱.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txt商品名稱.Name = "txt商品名稱";
            this.txt商品名稱.Size = new System.Drawing.Size(300, 60);
            this.txt商品名稱.TabIndex = 53;
            this.txt商品名稱.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 40);
            this.label1.TabIndex = 49;
            this.label1.Text = "名稱";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox商品品項
            // 
            this.listBox商品品項.BackColor = System.Drawing.SystemColors.Control;
            this.listBox商品品項.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox商品品項.FormattingEnabled = true;
            this.listBox商品品項.ItemHeight = 20;
            this.listBox商品品項.Location = new System.Drawing.Point(940, 640);
            this.listBox商品品項.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.listBox商品品項.Name = "listBox商品品項";
            this.listBox商品品項.Size = new System.Drawing.Size(117, 24);
            this.listBox商品品項.TabIndex = 16;
            this.listBox商品品項.Visible = false;
            this.listBox商品品項.SelectedIndexChanged += new System.EventHandler(this.listBox冷飲品項_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(256, 256);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 691);
            this.Controls.Add(this.panel_Desktop);
            this.Controls.Add(this.panel_NavBar);
            this.Controls.Add(this.panel_Menu);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form_User";
            this.Text = "UserMainMenu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinkProductBindingSource)).EndInit();
            this.panel_Menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel_NavBar.ResumeLayout(false);
            this.panel_NavBar.PerformLayout();
            this.panel_Desktop.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_CupNum)).EndInit();
            this.panel19.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MyDBDataSet myDBDataSet;
        private System.Windows.Forms.BindingSource drinkProductBindingSource;
        private MyDBDataSetTableAdapters.DrinkProductTableAdapter drinkProductTableAdapter;
        private MyDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lbl_帳號;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_新增至購物車;
        private System.Windows.Forms.Button btn_查看購物車;
        private System.Windows.Forms.Button btn_最愛商品;
        private System.Windows.Forms.Button btn_訂購紀錄;
        private System.Windows.Forms.Button btn_修改會員資料;
        private System.Windows.Forms.Button btn_登出會員;
        private System.Windows.Forms.Panel panel_NavBar;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_鹹酥雞訂購;
        private System.Windows.Forms.Panel panel_Desktop;
        private System.Windows.Forms.Label lbl_TotalPrice;
        private System.Windows.Forms.Label lbl_TotalCup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numUpDown_CupNum;
        private System.Windows.Forms.ComboBox comboBox配料;
        private System.Windows.Forms.ComboBox comboBox辣度;
        private System.Windows.Forms.Label lbl品項總價幾元;
        private System.Windows.Forms.Label lbl配料;
        private System.Windows.Forms.Label lbl甜度;
        private System.Windows.Forms.Label lbl小計;
        private System.Windows.Forms.Label lbl杯數;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label txt商品名稱;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl單價幾元;
        private System.Windows.Forms.Label lbl單價;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_PhotoMode;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListBox listBox商品品項;
        private System.Windows.Forms.Button btn_ListMode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
    }
}

