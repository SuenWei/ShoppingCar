using System;
//
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient; //ADO.net元件 SqlClient
using System.Drawing;
using System.Windows.Forms;
//
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public partial class Form_User : Form
    {
        //Fields
        private Button currentButon;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList2.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList2.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList2[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (currentButon != (Button)btnSender)
            {
                DisableButton();
                Color color = SelectThemeColor();
                currentButon = (Button)btnSender;
                currentButon.BackColor = color;
                currentButon.ForeColor = Color.White;
                currentButon.Font = new System.Drawing.Font("微軟正黑體", 13.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
                panel_NavBar.BackColor = color;
                //panel_NavBar.ForeColor = Color.White;
                panel_NavBar.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                btn_鹹酥雞訂購.Visible = true;
                lbl_Title.ForeColor = Color.White;

            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panel_Menu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(222, 184, 135);
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_Desktop.Controls.Add(childForm);
            this.panel_Desktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbl_Title.Text = childForm.Text;
        }

        //SQL
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = ""; //

        List<int> list價格 = new List<int>();
        List<string> list品項 = new List<string>();       
        List<string> list辣度 = new List<string>();        
        List<string> list配料 = new List<string>();
        //List<string> list冰塊 = new List<string>();
        List<string> listName = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listId = new List<int>();

        public int pid = 1;
        //string myDBConnectionString = "";
        string image_dir = @"images\";
        string image_name = "";
        //bool is已修改圖檔 = false;



        //OrderInfo //加進list
        string 訂購品項;
        int 單價;
        string 甜度;
        string 冰塊;
        string 配料;
        int 數量;           
        int 品項總價;


        //CustInfo  //step1 變數宣告
        string CustName;
        int CustPhone;
        string CustAddress;
        string Delivery;
        string Straw;
        string Bag;


        public Form_User()
        {
            InitializeComponent();
            random = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'myDBDataSet.DrinkProduct' 資料表。您可以視需要進行移動或移除。
            //this.drinkProductTableAdapter.Fill(this.myDBDataSet.DrinkProduct);

            //SQL讀取 品項,價格,配料
            scsb = new SqlConnectionStringBuilder(); //初始化 SqlConnectionStringBuilder 類別的新執行個體

            //server database 雲端版本
            //scsb.DataSource = @"server-02.database.windows.net"; //資料來源
            //scsb.InitialCatalog = "ColdDrink"; //資料庫名稱 
            //scsb.IntegratedSecurity = false; //使用者ID和密碼false
            //scsb.UserID = "Suen";
            //scsb.Password = "MicrosoftAzure123";

            //地端版本
            scsb.DataSource = @".";  //資料來源 地端 @"." "127.0.0.1"?
            scsb.InitialCatalog = "myDB"; //資料庫名稱 
            scsb.IntegratedSecurity = true; // Windows帳戶認證true 

            myDBConnectionString = scsb.ToString();
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open(); //SQL server 資料庫開啟連接  

            string strSQL = "select top 50 * from  FriedChicken;"; //對資料庫執行陳述式 
            SqlCommand cmd = new SqlCommand(strSQL, con); //SqlCommand(String, SqlConnection)
            SqlDataReader reader = cmd.ExecuteReader(); //執行順向讀取 

            while (reader.Read())
            {
                list品項.Add(reader["ProductName"].ToString()); //讀取表格欄位
                list價格.Add(Convert.ToInt32(reader["ProductPrice"]) );
            }

            reader.Close(); //執行閱讀關閉
           
            //配料
            string strSQL2 = "select top 50 * from Topping;"; 
            SqlCommand cmd2 = new SqlCommand(strSQL2, con); 
            SqlDataReader reader2 = cmd2.ExecuteReader(); 

            while (reader2.Read())
            {
                list配料.Add(reader2["ToppingName"].ToString());
            }

            reader2.Close(); //執行閱讀關閉

            //辣度
            string strSQL3 = "select top 50 * from Spicy;";
            SqlCommand cmd3 = new SqlCommand(strSQL3, con);
            SqlDataReader reader3 = cmd3.ExecuteReader();

            while (reader3.Read())
            {
                list辣度.Add(reader3["SpicyDegree"].ToString());
            }

            reader3.Close(); //執行閱讀關閉
            con.Close(); //連接關閉

          
            //來源改成SQL
            //list-key
            //list品項.Add("紅茶");     
            //list價格.Add(100);
            //list甜度.Add("全糖");
            //list冰塊.Add("正常");
            //list配料.Add("無");


            //DataSource
            //comboBox冰塊.DataSource = list冰塊;
            comboBox辣度.DataSource = list辣度;            
            comboBox配料.DataSource = list配料;
         

            //將list品項的飲料名稱  在listBox冷飲品項 顯示出來
            foreach (string 飲料名稱 in list品項)  
            {
                listBox商品品項.Items.Add(飲料名稱);            
            }
            listBox商品品項.SelectedIndex = 0; // 預選第一個


            ////外送自取 RadioBtn
            //radioBtn_Delivery.Checked = true ;
            //radioBtn_SelfTake.Checked = false;

            ////吸管袋子checkBox
            //checkBox_Straw.Checked = false;
            //checkBox_Bag.Checked = false;

            //杯數 numUpDown
            numUpDown_CupNum.Value = 1;

            //甜度冰塊配料 //避免ComboBox編輯文字產生錯誤 
            //comboBox冰塊.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox辣度.DropDownStyle = ComboBoxStyle.DropDownList;            
            comboBox配料.DropDownStyle = ComboBoxStyle.DropDownList;
            
            //小計
            NumxPrice();
            //現在登入會員
            lbl_帳號.Text ="Hi " + GlobalVar.CustAccountNow;

            //ListView
            讀取資料庫();
            listView產生商品展示_圖片模式();
            顯示商品細項資訊();

         

        }

        //ListView

        void 讀取資料庫()
        {
            SqlConnection con2 = new SqlConnection(myDBConnectionString);
            con2.Open();
            string strSQL4 = "select * from FriedChicken;";
            SqlCommand cmd4 = new SqlCommand(strSQL4, con2);
            SqlDataReader reader4 = cmd4.ExecuteReader();

            string image_dir = @"images\";
            string image_name = "";
            int i = 0;

            while (reader4.Read())
            {
                listId.Add((int)reader4["ProductID"]);
                listName.Add((string)reader4["ProductName"]);
                listPrice.Add((int)reader4["ProductPrice"]);
                image_name = (string)reader4["ProductPhoto"];
                imageList1.Images.Add(Image.FromFile(image_dir + image_name));
                i += 1;
            }
            Console.WriteLine("讀取{0}筆資料", i);
            reader4.Close();
            con2.Close();
        }

        void listView產生商品展示_圖片模式()
        {
            listView1.Clear();
            listView1.View = View.LargeIcon;//LargeIcon, SmallIcon, List, Tile
            imageList1.ImageSize = new Size(110, 84);
            listView1.LargeImageList = imageList1; //LargeIcon, Tile
                                                   //listView1.SmallImageList = imageList1; //SmallIcon, List

            for (int i = 0; i < imageList1.Images.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
                //item.Text = listName[i];
                item.Tag = listId[i];
                listView1.Items.Add(item);
            }
        }

        void listView產生商品展示_列表模式()
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("序號", 100);
            listView1.Columns.Add("商品名稱", 200);
            listView1.Columns.Add("商品價格", 80);
            listView1.FullRowSelect = true;

            for (int i = 0; i < listId.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
                item.Text = listId[i].ToString();
                item.SubItems.Add((string)listName[i]);
                item.SubItems.Add(listPrice[i].ToString());
                item.Tag = listId[i];

                listView1.Items.Add(item);
            }
        }

        void 顯示商品細項資訊()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from FriedChicken where ProductID = @SearchId";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchId", pid);
            SqlDataReader reader = cmd.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                //txt序號.Text = reader["ProductID"].ToString();
                txt商品名稱.Text = reader["ProductName"].ToString();
                lbl單價幾元.Text = reader["ProductPrice"].ToString();
                image_name = reader["ProductPhoto"].ToString();
                pictureBox1.Image = Image.FromFile(image_dir + image_name);
                i += 1;
            }
            //NumxPrice();
            reader.Close();
            con.Close();
        }



        //新增至購物車 //按鈕
        private void btn加入訂購單_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            //建立Arraylist 在從form讀出來
            //甜度 = Convert.ToString(comboBox甜度.SelectedValue);
            //冰塊= list冰塊[comboBox冰塊.SelectedIndex];
            甜度 = list辣度[comboBox辣度.SelectedIndex];            
            配料= list配料[comboBox配料.SelectedIndex];

            訂購品項 = txt商品名稱.Text;
            單價 = Convert.ToInt32(lbl單價幾元.Text);
            //訂單資料 ArrayList
            ArrayList 品項訂購資訊 = new ArrayList(); 
            品項訂購資訊.Add(訂購品項);
            品項訂購資訊.Add(單價);
            品項訂購資訊.Add(甜度);
            品項訂購資訊.Add(冰塊);
            品項訂購資訊.Add(配料);
            品項訂購資訊.Add(數量);
            品項訂購資訊.Add(品項總價);


            //要加全域變數 因為要讀出來
            GlobalVar.list訂購品項列表.Add(品項訂購資訊);

            // TotalCup and TotalPrice 
            TotalPrice();
            TotalCup();

            //MessageBox.Show("已加入訂單"); 

        }

        //查看購物車 //按鈕
        private void btn查看訂購單_Click(object sender, EventArgs e)
        {
            //groupBox1.Hide();
            //ActivateButton(sender);
            OpenChildForm(new Form_User購物車(), sender);
            btn_新增至購物車.Enabled = false;

            //讀取客戶輸入的資訊 指定到變數  //欄位輸入檢查
            //try
            //{
            //    CustName
            //    if (textBox_CustName.Text == "")
            //    {
            //        MessageBox.Show("請輸入訂購人姓名", "錯誤");
            //        return;
            //    }
            //    else
            //    {
            //        CustName = Convert.ToString(textBox_CustName.Text);
            //    }

            //    //CustPhone
            //    if (textBox_CustPhone.Text == "")
            //    {
            //        MessageBox.Show("請輸入訂購人電話", "錯誤");
            //        return;
            //    }
            //    else
            //    {
            //        CustPhone = Convert.ToInt32(textBox_CustPhone.Text);
            //    }

            //    //CusAddress 
            //    //Delivery and SelfTake //radioBtn
            //    if (radioBtn_Delivery.Checked) //外送
            //    {
            //        Delivery = radioBtn_Delivery.Text;
            //        if (textBox_CustAddress.Text == "") //未輸入地址
            //        {
            //            MessageBox.Show("請輸入訂購人地址", "錯誤");
            //            return;
            //        }
            //        else  
            //        {                        
            //            CustAddress = Convert.ToString(textBox_CustAddress.Text);
            //        }
            //    }
            //    else //自取
            //    {
            //        Delivery = radioBtn_SelfTake.Text;
            //        CustAddress = "";
            //    }
                                
            //}
            //catch (Exception error)
            //{
            //    MessageBox.Show("錯誤");
            //    return;
            //};

            //Straw and Bag //checkBox
            //if (checkBox_Straw.Checked) //吸管
            //{
            //    Straw = checkBox_Straw.Text;
            //}
            //else
            //{
            //    Straw = "";
            //}

            //if (checkBox_Bag.Checked) //袋子
            //{
            //    Bag = checkBox_Bag.Text;
            //}
            //else
            //{
            //    Bag = "";
            //}

            //CustInfo   
            ArrayList CustInfo = new ArrayList(); //step2  創建ArrayList()
            CustInfo.Add(CustName);
            CustInfo.Add(CustPhone);
            CustInfo.Add(CustAddress);
            CustInfo.Add(Delivery);
            CustInfo.Add(Straw);
            CustInfo.Add(Bag);

            //要加全域變數 因為要讀出來
            GlobalVar.CustInfo_list.Add(CustInfo);  //step4

            ////欄位檢查無誤 開啟Form2 
            //Form_User購物車 form訂購單列表 = new Form_User購物車();
            ////form訂購單列表.show();  //單純開啟另一個 Form表單 還是可以對原表單做動作
            //form訂購單列表.ShowDialog(); //強化型Form表單開啟 開啟後原表單不可執行動作 在關閉時可以設定回傳訊息

        }

        //選擇下拉表單 冷飲品項 顯示單價
        private void listBox冷飲品項_SelectedIndexChanged(object sender, EventArgs e)
        {
            //參考課本13-8頁
            int setIndex = listBox商品品項.SelectedIndex; //  設一個 整數變數setIndex = listBox冷飲品項下拉選擇表單的索引index

            //等號左邊設定值, 等號右邊取值
            訂購品項 = list品項[setIndex];  // 所選擇的 訂購品項(字串變數)= list品項[setIndex]
            單價 = list價格[setIndex];          // 所選擇的 單價(整數變數)= list品項[setIndex]            



            lbl單價幾元.Text = 單價.ToString() + " 元";  //單價轉換成字串 顯示在form1

            NumxPrice();
        }

        //CupNum //numUpDown 
        private void numUpDown_CupNum_ValueChanged(object sender, EventArgs e)
        {
            NumxPrice();
        }

        // Methods 1. 小計
        private void NumxPrice()
        {
            try
            {
                int setIndex = listBox商品品項.SelectedIndex;
                //單價 = list價格[setIndex];               
                數量 = Convert.ToInt32(numUpDown_CupNum.Value);
                品項總價 = 數量 * list價格[setIndex];
                //單價 = Convert.ToInt32(lbl單價幾元.Text);
                //品項總價 = 數量 * 單價;
                lbl品項總價幾元.Text = Convert.ToString(品項總價) + " 元";        
            }
            catch (Exception error)
            {
                MessageBox.Show("錯誤");
            }
        }
        
        // Methosd 2. 總金額
        private void TotalPrice() 
        {
            int TotalPrice = 0;
            foreach (ArrayList item in GlobalVar.list訂購品項列表)
            {                         
                TotalPrice += (int)item[6];
                lbl_TotalPrice.Text =Convert.ToString(TotalPrice) + " 元";
            }
        }
       
        // Methosd 3. 總杯數
        private void TotalCup()
        {
            int TotalCup = 0;
            foreach (ArrayList item in GlobalVar.list訂購品項列表)
            {
                TotalCup += (int)item[5];
                lbl_TotalCup.Text = Convert.ToString(TotalCup) + " 杯";
            }
        }

        private void drinkProductBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.drinkProductBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDBDataSet);

        }

        private void btn_登出會員_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            

            this.Hide(); //原先表單隱藏
            Form_Login form返回登入 = new Form_Login();            
            form返回登入.ShowDialog(); //強化型Form表單開啟 開啟後原表單不可執行動作 在關閉時可以設定回傳訊息
        }

        private void btn_修改會員資料_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            OpenChildForm(new Form_User會員系統(), sender);
            
            btn_新增至購物車.Enabled = false;
            //if (GlobalVar.CustAccountNow != "")
            //{
            //    欄位檢查無誤 開啟Form4
            //    this.Hide(); //原先表單隱藏
            //    Form_User會員系統 form註冊帳號 = new Form_User會員系統();
            //    form訂購單列表.show();  //單純開啟另一個 Form表單 還是可以對原表單做動作
            //    form註冊帳號.ShowDialog(); //強化型Form表單開啟 開啟後原表單不可執行動作 在關閉時可以設定回傳訊息
            //}

        }             

        private void btn_訂購紀錄_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            OpenChildForm(new Form_User訂購紀錄(), sender);
            btn_新增至購物車.Enabled = false;
        }

        private void btn_最愛商品_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            OpenChildForm(new Form_User最愛商品(), sender);
            btn_新增至購物車.Enabled = false;
        }                

        private void btn_鹹酥雞訂購_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
            TotalCup();
            TotalPrice();
            if (GlobalVar.list訂購品項列表.Count == 0) 
            {
                lbl_TotalPrice.Text =  " 0 元";
                lbl_TotalCup.Text =  " 0 杯";

            }
            


        }
        
        private void Reset()
        {
            DisableButton();
            lbl_Title.Text = "香香雞訂購";
            lbl_Title.ForeColor = Color.Black;            

            panel_NavBar.BackColor = Color.FromArgb(222, 184, 135);
            //panel_Logo.BackColor = Color.FromArgb(153, 180, 209);
            currentButon = null;
            //btn_管理系統.Visible = false;              

            btn_新增至購物車.Enabled = true;
        }

        private void panel_Desktop_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_ListMode_Click(object sender, EventArgs e)
        {
            listView產生商品展示_列表模式();
        }

        private void btn_PhotoMode_Click(object sender, EventArgs e)
        {
            listView產生商品展示_圖片模式();
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            int selID = (int)listView1.SelectedItems[0].Tag;
            //Form_Admin商品管理 myFormDetail = new Form_Admin商品管理();
            pid = selID;
            //myFormDetail.ShowDialog();
            顯示商品細項資訊();
            NumxPrice();
            try
            {
                //int setIndex = listBox商品品項.SelectedIndex;
                //單價 = list價格[setIndex];               
                數量 = Convert.ToInt32(numUpDown_CupNum.Value);
                //品項總價 = 數量 * list價格[setIndex];
                單價 = Convert.ToInt32(lbl單價幾元.Text);
                品項總價 = 數量 * 單價;
                lbl品項總價幾元.Text = Convert.ToString(品項總價) + " 元";
            }
            catch (Exception error)
            {
                MessageBox.Show("錯誤");
            }

        }

        private void comboBox配料_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
     }
}
