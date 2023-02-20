using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GarmentsSquare.BL;
using GarmentsSquare.DL;
using GarmentsSquare.UserControls;

namespace GarmentsSquare.UIForms
{
    public partial class ucManageShop : UserControl
    {
        private ucUpdateShop update;

        public ucUpdateShop Update1 { get => update; set => update = value; }

        public ucManageShop()
        {
            InitializeComponent();
            BindData();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search";
                txtSearch.ForeColor = Color.Silver;
            }
        }

        private void ucManageShop_Load(object sender, EventArgs e)
        {
            BindData();
        }

        public void BindData()
        {
            dataGridViewShops.DataSource = null;
            List<Shop> shopList = ShopDL.convertToList();
            dataGridViewShops.DataSource = shopList;
            dataGridViewShops.Columns["Next"].Visible = false;
            dataGridViewShops.Columns["Prev"].Visible = false;
            dataGridViewShops.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewShops.RowCount > 0)
            {
                Shop shop = (Shop)dataGridViewShops.CurrentRow.DataBoundItem;
                ShopDL.deleteShop(shop);
                BindData();
                ShopDL.storeData("Shops.csv");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewShops.RowCount > 0)
            {
                Shop shop = (Shop)dataGridViewShops.CurrentRow.DataBoundItem;

                Update1.Visible = true;
                Update1.LoadValues(shop);
                BindData();
            }
        }
    }
}
