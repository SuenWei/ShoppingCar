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
    public partial class FormNo : Form
    {
        public FormNo()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDBDataSet);

        }

        private void Form_會員管理_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'myDBDataSet5.Customer' 資料表。您可以視需要進行移動或移除。
            this.customerTableAdapter.Fill(this.myDBDataSet5.Customer);
            // TODO: 這行程式碼會將資料載入 'myDBDataSet5.Customer' 資料表。您可以視需要進行移動或移除。
            this.customerTableAdapter2.Fill(this.myDBDataSet5.Customer);
            // TODO: 這行程式碼會將資料載入 'myDBDataSet2.Customer' 資料表。您可以視需要進行移動或移除。
            this.customerTableAdapter1.Fill(this.myDBDataSet2.Customer);
            // TODO: 這行程式碼會將資料載入 'myDBDataSet.Customer' 資料表。您可以視需要進行移動或移除。
            //this.customerTableAdapter.Fill(this.myDBDataSet.Customer);

        }

        private void customerBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void customerBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void customerBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDBDataSet5);

        }
    }
}
