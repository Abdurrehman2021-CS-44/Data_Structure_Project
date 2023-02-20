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
using GarmentsSquare.UIForms;

namespace GarmentsSquare.UserControls
{
    public partial class ucManageOrder : UserControl
    {
        private Order order;
        private ucSelectRider selectRiderUI;

        public ucSelectRider SelectRiderUI { get => selectRiderUI; set => selectRiderUI = value; }

        public ucManageOrder()
        {
            InitializeComponent();
            order = null;
        }

        public void SetOrder(Order order)
        {
            this.order = order;

            this.txtShopName.Text = order.Shop.ShopName;
            this.txtLandline.Text = order.Shop.Landline;
            this.txtAddress.Text = order.Shop.Address;
            this.txtShopkeeper.Text = order.Shop.Shopkeeper.Name;
            this.txtContact.Text = order.Shop.Shopkeeper.Contact;
            this.txtEmail.Text = order.Shop.Shopkeeper.Email;
            this.txtCnic.Text = order.Shop.Shopkeeper.Cnic;

            this.dgvProducts.DataSource = null;
            this.dgvProducts.DataSource = order.Products;
            this.dgvProducts.Columns["Next"].Visible = false;
            this.dgvProducts.Columns["Prev"].Visible = false;
            this.dgvProducts.Refresh();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public void hidebuttons( )
        {
            this.btnAccept.Enabled = false;
            this.btnDecline.Enabled = false;

            this.btnAccept.Visible = false;
            this.btnDecline.Visible = false;
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            OrderDL.deleteOrder(order);
            OrderDL.storeData("Orders.csv");
            this.Visible = false;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            SelectRiderUI.Visible = true;
            SelectRiderUI.Order = order;
            this.Visible = false;
        }

        private void btnViewMap_Click(object sender, EventArgs e)
        {
            MapShopRoute frm = new MapShopRoute(order.Shop.Location, order.Shop.Address);
            frm.ShowDialog();
        }
    }
}
