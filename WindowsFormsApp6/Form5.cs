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
    public partial class Form5 : Form
    {

        //
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";

        public Form5()
        {
            InitializeComponent();
        }

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

        

        private void Form5_Load(object sender, EventArgs e)
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
        }

        private void btn_新增員工_Click(object sender, EventArgs e)
        {
            if ((textBox_姓名.Text != "") && (textBox_電話.Text != "") && (textBox_地址.Text != "") && (textBox_帳號.Text != "") && (textBox_密碼.Text != "") && (textBox_Email.Text != ""))
            {
                //LoginId不能為重複                
                SqlConnection con = new SqlConnection(myDBConnectionString); //1.建立連線物件               
                string sqlSelect = "select EmpAccount from Employee where EmpAccount='" + textBox_帳號.Text.Trim() + "'";  //組合sql查詢語句
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
                //
                byte[] result = Encoding.Default.GetBytes(this.textBox_密碼.Text.Trim());  //輸入密碼的文字框
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] output = md5.ComputeHash(result);//加密後的登入明文密碼
                string password = BitConverter.ToString(output).Replace("-", ""); //為輸出加密文字的文字框

                string strSQL = "insert into Employee values(@NewName, @NewPhone, @NewAddress, @NewBirth, @NewAccount, @NewPassword, @NewEmail, @NewPoints);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", textBox_姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", textBox_電話.Text);
                cmd.Parameters.AddWithValue("@NewAddress", textBox_地址.Text);
                cmd.Parameters.AddWithValue("@NewBirth", DTP_生日.Value);      
                cmd.Parameters.AddWithValue("@NewAccount", textBox_帳號.Text);
                cmd.Parameters.AddWithValue("@NewPassword", password);
                cmd.Parameters.AddWithValue("@NewEmail", textBox_Email.Text);
                int int點數 = 0;
                Int32.TryParse(textBox_點數.Text, out int點數);
                cmd.Parameters.AddWithValue("@NewPoints", int點數);

                int rows = cmd.ExecuteNonQuery();
                con.Close(); //關閉連線
                ClearTexbox(); //清空輸入
                MessageBox.Show($" 新增 {rows}筆 員工成功"); //註冊成功
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
            this.Hide(); 
            Form_Login form返回登入 = new Form_Login();            
            form返回登入.ShowDialog(); 
        }
    }
}
