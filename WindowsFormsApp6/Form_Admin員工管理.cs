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
    public partial class Form_Admin員工管理 : Form
    {
        public Form_Admin員工管理()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDBDataSet5);

        }

        private void Form_Admin員工管理_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'myDBDataSet5.Employee' 資料表。您可以視需要進行移動或移除。
            this.employeeTableAdapter.Fill(this.myDBDataSet5.Employee);

        }

        private void 員工表單_Click(object sender, EventArgs e)
        {

        }
    }
}
