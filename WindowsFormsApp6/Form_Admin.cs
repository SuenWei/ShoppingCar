using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form_Admin : Form
    {
        //Fields
        private Button currentButon;
        private Random random;
        private int tempIndex;
        private Form activeForm;
   
        public Form_Admin()
        {
            InitializeComponent();
            random = new Random();
            //btn_管理系統.Visible = false;
            //this.Text = string.Empty;
            //this.ControlBox = false;
        }

        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex==index) 
            { 
                index = random.Next(ThemeColor.ColorList.Count); 
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);        
        }

        private void ActivateButton(object btnSender)
        {
            if (currentButon!=(Button)btnSender) 
            {
                DisableButton();
                Color color = SelectThemeColor();
                currentButon = (Button)btnSender;
                currentButon.BackColor = color;
                currentButon.ForeColor = Color.White;
                currentButon.Font= new System.Drawing.Font("微軟正黑體", 13.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
                panel_NavBar.BackColor = color;
                //panel_NavBar.ForeColor = Color.White;
                panel_NavBar.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                btn_管理系統.Visible = true;
                lbl_Title.ForeColor = Color.White;

            }        
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panel_Menu.Controls)
            {
                if (previousBtn.GetType()==typeof(Button)) 
                {
                    previousBtn.BackColor = Color.FromArgb(185, 209, 234);
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font= new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
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

        private void Form6_Load(object sender, EventArgs e)
        {
            
        }     

        private void btn_訂單管理_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Form_Admin訂單管理(), sender);
        }

        private void btn_商品管理_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Form_Admin商品管理(), sender);
        }

        private void btn_會員管理_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Form_會員管理 form會員管理 = new Form_會員管理();
            //form會員管理.ShowDialog();

            ActivateButton(sender);
            OpenChildForm(new Form_Admin會員管理(), sender);
        }

        private void btn_員工管理_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            OpenChildForm(new Form_Admin員工管理(), sender);
        }

        private void btn_登出_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            this.Hide();
            Form_Login form返回登入 = new Form_Login();
            form返回登入.ShowDialog();

        }




        private void panel_Logo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lbl_管理系統_Click(object sender, EventArgs e)
        {

        }

        private void btn_管理系統_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

            private void Reset()
            {
                DisableButton();
                lbl_Title.Text = "管理系統";
                panel_NavBar.BackColor = Color.FromArgb(185, 209, 234);
                panel_Logo.BackColor = Color.FromArgb(153, 180, 209);
                currentButon = null;
                //btn_管理系統.Visible = false;              
            
            }            
                
            
        
    }
}
