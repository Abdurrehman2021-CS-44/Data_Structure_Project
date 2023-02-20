using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarmentsSquare.UIForms
{
    public partial class RiderHome : Form
    {
        public RiderHome()
        {
            InitializeComponent();
            enableButtons();
        }

        private void enableButtons()
        {
            // making invisible all user controls
            ucAddShop1.Visible = false;
            ucPlaceOrder_1.Visible = false;
            ucViewOrders1.Visible = false;
            ucManageOrder1.Visible = false;
            ucPlaceOrder_2.Visible = false;
            ucAssignedOrders1.Visible = false;
            ucManageShop1.Visible = false;
            ucUpdateShop1.Visible = false;

            // enabling all buttons
            btnPlaceOrder.Enabled = true;
            btnViewOrder.Enabled = true;
            btnAddShop.Enabled = true;
            btnManageShops.Enabled = true;
            btnAssignedOrder.Enabled = true;
        }

        private void ucAddShop1_Load(object sender, EventArgs e)
        {
            enableButtons();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            enableButtons();

            ucPlaceOrder_1.Visible = true;
            ucPlaceOrder_1.BindData();
            ucPlaceOrder_1.PlaceOrder_2 = ucPlaceOrder_2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignInFrm frm = new SignInFrm();
            frm.Show();
            this.Hide();
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            enableButtons();

            ucViewOrders1.Visible = true;
            btnViewOrder.Enabled = false;
            ucViewOrders1.ManageUI = ucManageOrder1;
            ucViewOrders1.setActor("Rider");
            ucViewOrders1.BindDataForRider("R-1"); // active rider id
        }

        private void btnAssignedOrder_Click(object sender, EventArgs e)
        {
            enableButtons();

            btnAssignedOrder.Enabled = false;
            ucAssignedOrders1.Visible = true;
            ucAssignedOrders1.ViewOrder = ucManageOrder1;
        }

        private void btnAddShop_Click(object sender, EventArgs e)
        {
            enableButtons();
            ucAddShop1.Visible = true;
            btnAddShop.Enabled = false;
        }

        private void btnManageShops_Click(object sender, EventArgs e)
        {
            enableButtons();

            ucManageShop1.Visible = true;
            ucManageShop1.BindData();
            ucManageShop1.Update1 = ucUpdateShop1;
        }
    }
}
