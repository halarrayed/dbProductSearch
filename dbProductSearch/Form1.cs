using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbProductSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDBDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productDBDataSet.Product);

        }

        private void btnProductOver40_Click(object sender, EventArgs e)
        {
            this.productTableAdapter.FillByPriceOver40(this.productDBDataSet.Product);

        }

        private void btnSaerchByDesc_Click(object sender, EventArgs e)
        {
            this.productTableAdapter.SearchByDesc(this.productDBDataSet.Product,textBoxSearch.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.productTableAdapter.Fill(this.productDBDataSet.Product);
        }
    }
}
