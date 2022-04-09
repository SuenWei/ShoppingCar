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
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApp6
{
    public partial class Form_Admin商品管理 : Form
    {
        string myDBConnectionString = "";
        List<string> listName = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listId = new List<int>();
        //
        public int pid = 1;
        //string myDBConnectionString = "";
        string image_dir = @"images\";
        string image_name = "";
        bool is已修改圖檔 = false;

        public Form_Admin商品管理()
        {
            InitializeComponent();
        }

        private void Form_Admin商品管理_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "myDB";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();

            讀取資料庫();
            listView產生商品展示_圖片模式();

            if (pid <= 0)
            { //新增模式
                groupBox_修改商品.Visible = true;
                groupBox_新增商品.Visible = true;
                顯示商品細項資訊();
            }
            else
            { //細項模式
                groupBox_修改商品.Visible = true;
                groupBox_新增商品.Visible = true;
                顯示商品細項資訊();
            }
        }

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
            imageList1.ImageSize = new Size(80, 80);
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
                txt序號.Text = reader["ProductID"].ToString();
                txt商品名稱.Text = reader["ProductName"].ToString();
                txt商品價格.Text = reader["ProductPrice"].ToString();
                image_name = reader["ProductPhoto"].ToString();
                pictureBox1.Image = Image.FromFile(image_dir + image_name);
                i += 1;
            }
            reader.Close();
            con.Close();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_選取圖片_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "圖檔類型 (*.jpg, *.jpeg, *.png)|*.jpeg;*.jpg;*.png";

            DialogResult R = f.ShowDialog();

            if (R == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(f.FileName);

                string fileExt = Path.GetExtension(f.SafeFileName);
                Random myRand = new Random();
                image_name = DateTime.Now.ToString("yyyyMMddHHmmss") + myRand.Next(1000, 10000).ToString() + fileExt;
                is已修改圖檔 = true;
                Console.WriteLine(image_name);
            }
        }

        private void btn_儲存修改_Click(object sender, EventArgs e)
        {
            if ((txt商品價格.Text != "") && (txt商品名稱.Text != "") && (pictureBox1.Image != null))
            {
                if (is已修改圖檔 == true)
                {
                    pictureBox1.Image.Save(image_dir + image_name);
                    is已修改圖檔 = false;
                }

                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "update FriedChicken set ProductName = @NewPname, ProductPrice= @NewPrice, ProductPhoto = @NewPimage where ProductID = @SearchId";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId", pid);
                cmd.Parameters.AddWithValue("@NewPname", txt商品名稱.Text);
                int intPrice = 0;
                Int32.TryParse(txt商品價格.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                cmd.Parameters.AddWithValue("@NewPimage", image_name);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show($"資料修改成功, 影響 {rows} 筆資料");
                //System.IO 
                //File.Exists(fullpath) //boolean
                //File.Delete(fullpath)
            }
            else
            {
                MessageBox.Show("所有欄位必填");
            }
        }

        private void btn_新增商品_Click(object sender, EventArgs e)
        {
            txt序號.Text = "";
            txt商品名稱.Text = "";
            txt商品價格.Text = "";
            pictureBox1.Image = null;

            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "圖檔類型 (*.jpg, *.jpeg, *.png)|*.jpeg;*.jpg;*.png";

            DialogResult R = f.ShowDialog();

            if (R == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(f.FileName);

                string fileExt = Path.GetExtension(f.SafeFileName);
                Random myRand = new Random();
                image_name = DateTime.Now.ToString("yyyyMMddHHmmss") + myRand.Next(1000, 10000).ToString() + fileExt;
                is已修改圖檔 = true;
                Console.WriteLine(image_name);
            }
        }

        private void btn_選取商品2_Click(object sender, EventArgs e)
        {
  
        }

        private void btn_儲存資料_Click(object sender, EventArgs e)
        {
            if ((txt商品價格.Text != "") && (txt商品名稱.Text != "") && (pictureBox1.Image != null))
            {
                if (is已修改圖檔 == true)
                {
                    pictureBox1.Image.Save(image_dir + image_name);
                    is已修改圖檔 = false;
                }

                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "insert into FriedChicken values(@NewPname, @NewPrice, @NewPimage);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewPname", txt商品名稱.Text);
                int intPrice = 0;
                Int32.TryParse(txt商品價格.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                cmd.Parameters.AddWithValue("@NewPimage", image_name);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show($"資料新增成功, 影響 {rows} 筆資料");
            }
            else
            {
                MessageBox.Show("所有欄位必填");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_PhotoMode_Click(object sender, EventArgs e)
        {
            listView產生商品展示_圖片模式();
        }

        private void btn_ListMode_Click(object sender, EventArgs e)
        {
            listView產生商品展示_列表模式();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            listId.Clear();
            listName.Clear();
            listPrice.Clear();
            imageList1.Images.Clear();
            讀取資料庫();

            if (listView1.View == View.Details)
            {

                listView產生商品展示_列表模式();
            }
            else
            {
                listView產生商品展示_圖片模式();
            }
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            int selID = (int)listView1.SelectedItems[0].Tag;
            //Form_Admin商品管理 myFormDetail = new Form_Admin商品管理();
            pid = selID;
            //myFormDetail.ShowDialog();
            顯示商品細項資訊();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
