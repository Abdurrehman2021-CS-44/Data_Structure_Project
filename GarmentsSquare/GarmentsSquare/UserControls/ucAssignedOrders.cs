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

namespace GarmentsSquare.UserControls
{
    public partial class ucAssignedOrders : UserControl
    {
        private ucManageOrder viewOrder = new ucManageOrder();

        public ucManageOrder ViewOrder { get => viewOrder; set => viewOrder = value; }

        public ucAssignedOrders()
        {
            InitializeComponent();
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

        public void BindData()
        {
            try
            {
                dataGridAssignedOrders.RowCount = 1;
                List<Order> orders = RiderDL.ActiveRider.AssignedOrders;

                foreach (Order order in orders)
                {
                    
                    DataGridViewRow row1 = (DataGridViewRow)dataGridAssignedOrders.Rows[0].Clone();
                    row1.Cells[0].Value = order.Id;
                    row1.Cells[1].Value = order.Shop.ShopName;
                    row1.Cells[2].Value = order.Shop.Shopkeeper.Name;
                    row1.Cells[3].Value = order.Shop.Address;
                    row1.Cells[4].Value = order.Shop.Shopkeeper.Contact;
                    dataGridAssignedOrders.Rows.Add(row1);
                }

                dataGridAssignedOrders.Refresh();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }   


        private void ucAssignedOrders_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void dataGridAssignedOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridAssignedOrders.Columns["Deliver"].Index == e.ColumnIndex)
            {
                string id = (string)dataGridAssignedOrders.CurrentRow.Cells[0].Value;
                Order order = RiderDL.ActiveRider.findOrder(id);

                if (order != null)
                {
                    Utility.EmailSender.sendEmailOrderConfirmation(order);
                    RiderDL.ActiveRider.AssignedOrders.Remove(order);

                    MessageBox.Show("Order is Delivered :)");
                    BindData();
                }
            }
            else if (dataGridAssignedOrders.Columns["View"].Index == e.ColumnIndex)
            {
                string id = (string)dataGridAssignedOrders.CurrentRow.Cells[0].Value;
                Order order = RiderDL.ActiveRider.findOrder(id);

                viewOrder.Visible = true;
                viewOrder.SetOrder(order);
                viewOrder.hidebuttons();
            }
        }
    }
}
