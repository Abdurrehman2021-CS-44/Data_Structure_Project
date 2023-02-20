using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GarmentsSquare.DL;
using GarmentsSquare.BL;

namespace GarmentsSquare.UserControls
{
    public partial class ucInventory : UserControl
    {
        private ucUpdateProduct updateUserControl;

        public ucUpdateProduct UpdateUserControl { get => updateUserControl; set => updateUserControl = value; }

        public ucInventory()
        {
            InitializeComponent();
        }


        public void BindData()
        {
            dataGridViewInventory.DataSource = null;
            List<Product> products = ProductDL.convertToList();
            dataGridViewInventory.DataSource = products;
            dataGridViewInventory.Columns["Next"].Visible = false;
            dataGridViewInventory.Columns["Prev"].Visible = false;
            dataGridViewInventory.Refresh();
        }

        private void ucInventory_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewInventory.RowCount > 0)
            {
                Product product = (Product)dataGridViewInventory.CurrentRow.DataBoundItem;
                ProductDL.deleteProduct(product);
                BindData();
                ProductDL.storeData("Products.csv");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewInventory.RowCount > 0)
            {
                Product product = (Product)dataGridViewInventory.CurrentRow.DataBoundItem;

                UpdateUserControl.Visible = true;
                UpdateUserControl.LoadValues(product);
                BindData();
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            List<Product> products = ProductDL.convertToList();
            string name = cbSort.Text;
            if(name == "Name")
            {
                products = products.OrderBy(o => o.Price).ToList();
            }
            else if (name == "Color")
            {
                products = products.OrderBy(o => o.Color).ToList();
            }
            else if (name == "Brand")
            {
                products = products.OrderBy(o => o.Brand).ToList();
            }
            else if (name == "Price")
            {
                products = products.OrderBy(o => o.Price).ToList();
            }
            else if (name == "Size")
            {
                products = products.OrderBy(o => o.Size).ToList();
            }
            else if (name == "Quantity")
            {
                products = products.OrderBy(o => o.Quantity).ToList();
            }

            dataGridViewInventory.DataSource = null;
            dataGridViewInventory.DataSource = products;
            dataGridViewInventory.Columns["Next"].Visible = false;
            dataGridViewInventory.Columns["Prev"].Visible = false;
            dataGridViewInventory.Refresh();
        }
    }
}
