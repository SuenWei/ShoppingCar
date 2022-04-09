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
    public partial class Form_Admin訂單管理 : Form
    {
        public Form_Admin訂單管理()
        {
            InitializeComponent();
        }

        private void Form_Admin訂單管理_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'myDBDataSet5.OrderDetails' 資料表。您可以視需要進行移動或移除。
            this.orderDetailsTableAdapter.Fill(this.myDBDataSet5.OrderDetails);
            // TODO: 這行程式碼會將資料載入 'myDBDataSet5.Orderr' 資料表。您可以視需要進行移動或移除。
            this.orderrTableAdapter.Fill(this.myDBDataSet5.Orderr);
            // TODO: 這行程式碼會將資料載入 'myDBDataSet5.OrderDetails' 資料表。您可以視需要進行移動或移除。
            this.orderDetailsTableAdapter.Fill(this.myDBDataSet5.OrderDetails);
            // TODO: 這行程式碼會將資料載入 'myDBDataSet4.Orderr' 資料表。您可以視需要進行移動或移除。
            this.orderrTableAdapter.Fill(this.myDBDataSet4.Orderr);

        }

        private void orderrBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderrBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDBDataSet5);

        }
    }
}
