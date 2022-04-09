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
    public partial class Form_Login : Form
    {        
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";

        public Form_Login()
        {
            InitializeComponent();

            //密碼設定
            //textBox_密碼.Text = ""; //預設""           
            textBox_密碼.PasswordChar = '●'; //*遮罩            
            textBox_密碼.MaxLength = 14; //最多14個 characters

            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //SQL設定
            scsb = new SqlConnectionStringBuilder(); //初始化 SqlConnectionStringBuilder 類別的新執行個體
            scsb.DataSource = @".";  //資料來源 地端 @"." 
            scsb.InitialCatalog = "myDB"; //資料庫名稱 
            scsb.IntegratedSecurity = true; // Windows帳戶認證true 
            myDBConnectionString = scsb.ToString();

            

        }

        private void btn_註冊帳號_Click(object sender, EventArgs e)
        {
            GlobalVar.CustAccountNow = "";
            //客戶註冊會員 Form4
            if (radioBtn_User.Checked)
            {
                //開啟Form4 註冊帳號表單
                this.Hide(); //原先表單隱藏
                Form_User會員系統 form客戶註冊帳號 = new Form_User會員系統();
                form客戶註冊帳號.ShowDialog(); //強化型Form表單開啟 開啟後原表單不可執行動作 在關閉時可以設定回傳訊息
                //form訂購單列表.show();  //單純開啟另一個 Form表單 還是可以對原表單做動作
            }
            //管理者新增員工 Form5
            else {
                if (textBox_帳號.Text == "" || textBox_密碼.Text == "")
                {
                    MessageBox.Show("請輸入管理者帳號密碼");
                    return;
                }
                
                else if(textBox_帳號.Text == "Boss" || textBox_密碼.Text == "Boss")
                {
                    this.Hide(); //原先表單隱藏
                    Form5 form員工註冊帳號 = new Form5();
                    form員工註冊帳號.ShowDialog();
                }
                else 
                {
                    MessageBox.Show("管理者帳號密碼錯誤");
                    return;
                }     
            }
        }

        private void btn_登入_Click(object sender, EventArgs e)
        {
            

            //客戶登入
            if (radioBtn_User.Checked)
            {                
                // 1.建立連線物件
                SqlConnection con = null;
                try
                {
                    con = new SqlConnection(myDBConnectionString);
                }
                catch (Exception e1)
                {
                    e1.ToString();
                    MessageBox.Show("建立連線物件出錯");
                }

                //md5 32位加密
                byte[] result = Encoding.Default.GetBytes(this.textBox_密碼.Text.Trim()); //輸入密碼的文字框
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] output = md5.ComputeHash(result); //加密後的登入明文密碼
                string password = BitConverter.ToString(output).Replace("-", ""); //為輸出加密文字的文字框

                //驗證帳密SQL語法
                string Sqlstr_CustLogin = "select * from Customer where CustAccount='"
                    + textBox_帳號.Text.Trim() + "'and CustPassword='" + password + "' "; //客戶登入

                try
                {
                    con.Open(); //2.開啟連線
                }
                catch (Exception e2)
                {
                    e2.ToString();
                    MessageBox.Show("資料庫連接出錯");
                }

                if (textBox_帳號.Text.Equals("") || textBox_密碼.Text.Equals(""))//賬號 密碼為空
                {
                    MessageBox.Show("請輸入賬號密碼");
                }
                else
                {
                    //資料庫tra-sql語句
                    //3.執行查詢
                    SqlCommand cmd = new SqlCommand(Sqlstr_CustLogin, con);
                    //從資料庫讀一行
                    SqlDataReader Reader = cmd.ExecuteReader();
                    int count = 0;
                    while (Reader.Read())
                    {
                        count++;
                    }
                    //4.關閉連線
                    con.Close();
                    if (count > 0)
                    {
                        GlobalVar.CustAccountNow = textBox_帳號.Text;
                        MessageBox.Show("登入成功"); //登陸成功則跳轉至新的窗體
                                                 //開啟Form1 訂購頁面
                        this.Hide(); //原先表單隱藏
                        //Form3.Close();
                        Form_User form鹹酥雞訂購 = new Form_User();
                        form鹹酥雞訂購.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("登入失敗");
                    }
                }
            }
            else 
            {
                SqlConnection con = null;
                try
                {
                    con = new SqlConnection(myDBConnectionString);
                }
                catch (Exception e1)
                {
                    e1.ToString();
                    MessageBox.Show("建立連線物件出錯");
                }

                byte[] result = Encoding.Default.GetBytes(this.textBox_密碼.Text.Trim()); //輸入密碼的文字框
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] output = md5.ComputeHash(result); //加密後的登入明文密碼
                string password = BitConverter.ToString(output).Replace("-", ""); //為輸出加密文字的文字框

                string Sqlstr_EmpLogin = "select * from Employee where EmpAccount='"
                    + textBox_帳號.Text.Trim() + "'and EmpPassword='" + password + "' "; //員工登入

                con.Open();

                //員工登入
                if (textBox_帳號.Text.Equals("") || textBox_密碼.Text.Equals(""))
                {
                    MessageBox.Show("請輸入賬號密碼");
                }
                else  
                {                    
                    //3.執行查詢
                    SqlCommand cmd = new SqlCommand(Sqlstr_EmpLogin, con);                    
                    SqlDataReader Reader = cmd.ExecuteReader();
                    int count = 0;
                    while (Reader.Read())
                    {
                        count++;
                    }           
                    
                    con.Close();

                    if (count > 0)
                    {
                        //GlobalVar.CustAccountNow = textBox_帳號.Text;
                        MessageBox.Show("登入成功"); 
                        //開啟Form6 員工頁面
                        this.Hide(); 
                        Form_Admin form員工登入 = new Form_Admin();
                        form員工登入.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("登入失敗");
                    }
                }                  
            }
        }

        private void textBox_密碼_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
