using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using System.Collections;
//
using System.Data.SqlClient; //ADO.net元件
using System.Security.Cryptography; //MD5


namespace WindowsFormsApp6
{
    public partial class Form_User購物車 : Form 
    {

        int TotalPrice = 0;


        //
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";
        //
        List<int> searchIDs = new List<int>(); //進階搜尋結果;

        public Form_User購物車()
        {
            InitializeComponent();
        }


        //Methods
        //清空輸入
        public void ClearTexbox()
        {
            //textBox_姓名.Text = "";
            //textBox_電話.Text = "";
            //textBox_地址.Text = "";
            //textBox_帳號.Text = "";
            //textBox_密碼.Text = "";
            //textBox_確認密碼.Text = "";
            //textBox_Email.Text = "";
            //textBox_點數.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //讀取全域變數
            //lbl訂購人資料.Text = "訂購人資料" + GlobalVar.訂購人資訊;
            foreach(ArrayList item in GlobalVar.list訂購品項列表)  
            {
                string 品項 = (string)item[0]; //(sting)轉型 用Conver.To也可 //品項 跟Form1的品項不一樣//區塊
                int 單價 = (int)item[1];
                string 甜度 = (string)item[2];
                string 冰塊= (string)item[3]; 
                string 配料= (string)item[4];
                int 數量 = (int)item[5];
                int 品項總價 = (int)item[6];
                
                string str訂購品項資訊 = $"{品項}\t\t 單價: {單價}\t\t 辣度: {甜度}\t\t 配料: {配料}\t 份數: {數量}\t\t小計: {品項總價}\t ";
                listBox訂購品項列表.Items.Add(str訂購品項資訊);
            }
            計算訂單總價();

            //listBox_CustInfo //客戶資訊                  
            foreach (ArrayList Info in GlobalVar.CustInfo_list) {
                string Name = (string)Info[0];
                int Phone = (int)Info[1];
                string Adress = (string)Info[2];
                string Delivery = (string)Info[3];
                string Straw = (string)Info[4];
                string Bag = (string)Info[5];

                string CustInfo_str = $"姓名: {Name} 電話: {Phone} 配送地址: {Adress} {Delivery} {Straw} {Bag} ";

                //listBox_CustInfo.Items.Add(CustInfo_str);
                lbl_CustInfo.Text = CustInfo_str;
            };

            //SQL
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



        }

        private void btn移除所選品項_Click(object sender, EventArgs e)
        {
            //removeAt 移除items (selIndex)
            if (listBox訂購品項列表.SelectedIndex>=0) 
            {
                int selIdx = listBox訂購品項列表.SelectedIndex;
                GlobalVar.list訂購品項列表.RemoveAt(selIdx);
                listBox訂購品項列表.Items.RemoveAt(selIdx);
                計算訂單總價();
            }
            else {
                MessageBox.Show("請選擇品項");
            }
        }

        private void btn清除所有品項_Click(object sender, EventArgs e)
        {
            //Clear
            GlobalVar.list訂購品項列表.Clear();
            listBox訂購品項列表.Items.Clear();
            
            //計算訂單總價(); //清除會讀不到 無法計算訂單總價
            int 訂購總價 = 0;
            lbl訂購總價幾元.Text = "訂購總價 " + Convert.ToString(訂購總價) + " 元";
            
        }

        private void listBox訂購品項列表_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void 計算訂單總價()
        {
            int 訂購總價 = 0;
            foreach (ArrayList item in GlobalVar.list訂購品項列表)
            {
                //自己寫                               
                訂購總價 += (int)item[6];
                lbl訂購總價幾元.Text = "訂單總金額 "+Convert.ToString(訂購總價)+" 元";             
            }

            TotalPrice = 訂購總價;
        }

        private void lbl訂購品項列表_Click(object sender, EventArgs e)
        {

        }

        private void radioBtn_Delivery_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbl訂購總價幾元_Click(object sender, EventArgs e)
        {

        }

        private void btn_送出訂單_Click(object sender, EventArgs e)
        {
            if ((GlobalVar.CustAccountNow != "") && (TotalPrice != 0) )
            {
                SqlConnection con2 = new SqlConnection(myDBConnectionString);
                con2.Open();
                string strSQL2 = "select * from Customer where CustAccount = @SearchCustAccount;";
                SqlCommand cmd2 = new SqlCommand(strSQL2, con2);
                cmd2.Parameters.AddWithValue("@SearchCustAccount", GlobalVar.CustAccountNow);
                SqlDataReader reader = cmd2.ExecuteReader();


                int CustID = 0;
                string CustName = "";
                int CustPhone = 0;
                string CustAdress = "";
                //int TotalPrice = 0;
                string Delivery = "";
                if (radioBtn_Delivery.Checked==true){
                    Delivery="true";
                }
                else{ 
                    Delivery = "False"; 
                }
                                
                if (reader.Read())
                {
                    CustID = Convert.ToInt32($"{reader["CustID"]}");
                    CustName = $"{reader["CustName"]}";
                    CustPhone = Convert.ToInt32($"{reader["CustPhone"]}");
                    CustAdress = $"{reader["CustAdress"]}";                  
                }
                
                reader.Close();
                con2.Close();
  
                SqlConnection con = new SqlConnection(myDBConnectionString); //1.建立連線物件               
   
                con.Open();
                string strSQL = "insert into Orderr values(@NewCustID, @NewCustName, @NewCustPhone, @NewCustAdress, @NewOrderDate, @NewTotalPrice, @NewDelivery);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewCustID", CustID);
                cmd.Parameters.AddWithValue("@NewCustName", CustName);
                cmd.Parameters.AddWithValue("@NewCustPhone", CustPhone);
                cmd.Parameters.AddWithValue("@NewCustAdress", CustAdress);      
                cmd.Parameters.AddWithValue("@NewOrderDate", System.DateTime.Now);
                cmd.Parameters.AddWithValue("@NewTotalPrice", TotalPrice);
                cmd.Parameters.AddWithValue("@NewDelivery", Delivery);
              
                int rows = cmd.ExecuteNonQuery();
                con.Close(); //關閉連線

                //SQL orderdetails
                SqlConnection con3 = new SqlConnection(myDBConnectionString); //1.建立連線物件   
                con3.Open();
                //
                foreach (ArrayList item in GlobalVar.list訂購品項列表)
                {
                    int OrderID = 1234;
                    string 品項 = (string)item[0]; 
                    int 單價 = (int)item[1];
                    string 甜度 = (string)item[2];
                    string 冰塊 = (string)item[3];
                    string 配料 = (string)item[4];
                    int 數量 = (int)item[5];
                    int 品項總價 = (int)item[6];

                    string strSQL3 = "insert into OrderDetails values(@NewOrderID, @NewProduct, @NewSpicy, @NewTopping, @NewPrice, @NewQuantity, @NewSubtotal);";
                    SqlCommand cmd3 = new SqlCommand(strSQL3, con3);
                    cmd3.Parameters.AddWithValue("@NewOrderID", OrderID);
                    cmd3.Parameters.AddWithValue("@NewProduct", 品項);
                    cmd3.Parameters.AddWithValue("@NewSpicy", 甜度);
                    cmd3.Parameters.AddWithValue("@NewTopping", 配料);
                    cmd3.Parameters.AddWithValue("@NewPrice", 單價);
                    cmd3.Parameters.AddWithValue("@NewQuantity", 數量);
                    cmd3.Parameters.AddWithValue("@NewSubtotal", 品項總價);
                    int rows3 = cmd3.ExecuteNonQuery();
                }
                
                con3.Close(); //關閉連線
                ClearTexbox(); //清空輸入
                MessageBox.Show($"{rows} 筆 訂單成功"); //註冊成功

                //this.Close();
                //textBox_姓名.Focus();
                              
            }
            else
            {
                MessageBox.Show("請輸入完整資訊");
                return;
            }

            




        }
    }
}
