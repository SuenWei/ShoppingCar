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
using System.Data.SqlClient; //ADO.net元件
using System.Security.Cryptography; //MD5



namespace WindowsFormsApp6
{
    public partial class Form_User會員系統 : Form
    {
        //
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";

        //
        List<int> searchIDs = new List<int>(); //進階搜尋結果;

        public Form_User會員系統()
        {
            InitializeComponent();

            textBox_密碼.PasswordChar = '●'; //*遮罩            
            textBox_確認密碼.PasswordChar = '●'; //*遮罩            
            textBox_密碼.MaxLength = 14; //最多14個 characters
            textBox_確認密碼.MaxLength = 14; //最多14個 characters
        }


        //Methods
        //清空輸入
        public void ClearTexbox()
        {
            textBox_姓名.Text = "";
            textBox_電話.Text = "";
            textBox_地址.Text = "";
            textBox_帳號.Text = "";
            textBox_密碼.Text = "";
            textBox_確認密碼.Text = "";
            textBox_Email.Text = "";
            textBox_點數.Text = "";
        }


        //
        private void Form4_Load(object sender, EventArgs e)
        {       
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

            //
            if (GlobalVar.CustAccountNow != "")
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "select * from Customer where CustAccount = @SearchCustAccount;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchCustAccount", GlobalVar.CustAccountNow);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    textBox_會員編號.Text = $"{reader["CustID"]}";
                    textBox_姓名.Text = $"{reader["CustName"]}";
                    textBox_電話.Text = $"{reader["CustPhone"]}";
                    textBox_地址.Text = $"{reader["CustAdress"]}";
                    DTP_生日.Value = Convert.ToDateTime(reader["CustBirth"]);
                    textBox_帳號.Text = $"{reader["CustAccount"]}";
                    //textBox_密碼.Text = $"{reader["CustPassword"]}";
                    //textBox_確認密碼.Text = $"{reader["CustPassword"]}";
                    textBox_Email.Text = $"{reader["CustEmail"]}";
                    textBox_點數.Text = $"{reader["CustPoint"]}";                    
                    
                }
                else
                {
                    //MessageBox.Show("查無此人");
                    //lblID.Text = "";
                    //txt姓名.Text = "";
                    //txt電話.Text = "";
                    //txt地址.Text = "";
                    //txtEmail.Text = "";
                    //dtp生日.Value = DateTime.Now;
                    //chk婚姻狀態.Checked = false;
                    //txt點數.Text = "";
                }
                reader.Close();
                con.Close();
            }
            else
            {
                //MessageBox.Show("輸入姓名關鍵字搜尋");
            }




        }

        private void btn_註冊會員_Click(object sender, EventArgs e)
        {
            if ((textBox_姓名.Text != "") && (textBox_電話.Text != "")  && (textBox_地址.Text != "") && (textBox_帳號.Text != "") && (textBox_密碼.Text != "") && (textBox_Email.Text != "") )
            {                
                //LoginId不能為重複                
                SqlConnection con = new SqlConnection(myDBConnectionString); //1.建立連線物件               
                string sqlSelect = "select CustAccount from Customer where CustAccount='" + textBox_帳號.Text.Trim() + "'";  //組合sql查詢語句
                SqlCommand cmdsearch = new SqlCommand(sqlSelect, con);                             
                con.Open(); //2.開啟連線 
                object result1 = cmdsearch.ExecuteScalar();   //3.執行查詢
                //判斷賬號是否重複
                if (result1 != null)
                {
                    MessageBox.Show("此帳號已被使用");
                    con.Close();
                    return;
                }                
                con.Close(); //4.關閉連線
               //
                con.Open();
                string strSQL = "insert into Customer values(@NewName, @NewPhone, @NewAddress, @NewBirth, @NewAccount, @NewPassword, @NewEmail, @NewPoints);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", textBox_姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", textBox_電話.Text);
                cmd.Parameters.AddWithValue("@NewAddress", textBox_地址.Text);
                cmd.Parameters.AddWithValue("@NewBirth", DTP_生日.Value);
                //
                byte[] result = Encoding.Default.GetBytes(this.textBox_密碼.Text.Trim());  //輸入密碼的文字框
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] output = md5.ComputeHash(result);//加密後的登入明文密碼
                string password = BitConverter.ToString(output).Replace("-", ""); //為輸出加密文字的文字框

                cmd.Parameters.AddWithValue("@NewAccount", textBox_帳號.Text);
                cmd.Parameters.AddWithValue("@NewPassword", password);
                cmd.Parameters.AddWithValue("@NewEmail", textBox_Email.Text);
                int int點數 = 0;
                Int32.TryParse(textBox_點數.Text, out int點數);
                cmd.Parameters.AddWithValue("@NewPoints", int點數);

                int rows = cmd.ExecuteNonQuery();
                con.Close(); //關閉連線
                ClearTexbox(); //清空輸入
                MessageBox.Show($"{rows} 筆 會員註冊成功"); //註冊成功
                //this.Close();
                textBox_姓名.Focus();
            }
            else
            {                
                MessageBox.Show("請輸入完整資訊");
                return;
            }
        }

        private void btn_返回登入_Click(object sender, EventArgs e)
        {

            this.Hide(); //原先表單隱藏
            Form_Login form返回登入 = new Form_Login();
            form返回登入.ShowDialog(); //強化型Form表單開啟 開啟後原表單不可執行動作 在關閉時可以設定回傳訊息
        }

        private void textBox_帳號_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_修改資料_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(textBox_會員編號.Text, out intID);

            if ((textBox_姓名.Text != "") && (textBox_電話.Text != "") && (textBox_地址.Text != "") && (textBox_帳號.Text != "") && (textBox_密碼.Text != "") && (textBox_Email.Text != ""))
            {
                //LoginId不能為重複                
                SqlConnection con = new SqlConnection(myDBConnectionString); //1.建立連線物件               
                //string sqlSelect = "select CustAccount from Customer where CustAccount='" + textBox_帳號.Text.Trim() + "'";  //組合sql查詢語句
                //SqlCommand cmdsearch = new SqlCommand(sqlSelect, con);
                //con.Open(); //2.開啟連線 
                //object result1 = cmdsearch.ExecuteScalar();   //3.執行查詢
                ////判斷賬號是否重複
                //if (result1 != null)
                //{
                //    MessageBox.Show("此帳號已被使用");
                //    con.Close();
                //    return;
                //}
                //con.Close(); //4.關閉連線
                //
                con.Open();
                string strSQL = "update Customer set CustName=@NewName, CustPhone=@NewPhone, CustAdress=@NewAddress, CustBirth=@NewBirth, CustEmail=@NewEmail, CustAccount=@NewAccount, CustPassword=@NewPassword, CustPoint=@NewPoints where CustID=@SearchId;"; ;
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId", intID); ;
                cmd.Parameters.AddWithValue("@NewName", textBox_姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", textBox_電話.Text);
                cmd.Parameters.AddWithValue("@NewAddress", textBox_地址.Text);
                cmd.Parameters.AddWithValue("@NewBirth", DTP_生日.Value);
                //
                byte[] result = Encoding.Default.GetBytes(this.textBox_密碼.Text.Trim());  //輸入密碼的文字框
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] output = md5.ComputeHash(result);//加密後的登入明文密碼
                string password = BitConverter.ToString(output).Replace("-", ""); //為輸出加密文字的文字框

                cmd.Parameters.AddWithValue("@NewAccount", textBox_帳號.Text);
                cmd.Parameters.AddWithValue("@NewPassword", password);
                cmd.Parameters.AddWithValue("@NewEmail", textBox_Email.Text);
                int int點數 = 0;
                Int32.TryParse(textBox_點數.Text, out int點數);
                cmd.Parameters.AddWithValue("@NewPoints", int點數);

                int rows = cmd.ExecuteNonQuery();
                con.Close(); //關閉連線
                //ClearTexbox(); //清空輸入
                MessageBox.Show($"{rows} 筆 會員資料更新成功"); //註冊成功
                //this.Close();
                textBox_姓名.Focus();
            }
            else
            {
                MessageBox.Show("請輸入完整資訊");
                return;
            }
        }

        private void btn_刪除資料_Click(object sender, EventArgs e)
        {

        }
    }
}
