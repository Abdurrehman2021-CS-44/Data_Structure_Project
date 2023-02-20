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
    public partial class ucViewOrders : UserControl
    {
        private ucManageOrder manageUI;
        private string actor;
        public ucViewOrders()
        {
            InitializeComponent();

            BindData();
        }

        public void setActor(string value)
        {
            this.actor = value;
        }

        public void BindData()
        {
            try
            {
                dataGridViewOrders.RowCount = 1;
                List<Order> orders = OrderDL.convertToList();

                foreach (Order order in orders)
                {
                    DataGridViewRow row1 = (DataGridViewRow)dataGridViewOrders.Rows[0].Clone();
                    row1.Cells[0].Value = order.Id;
                    row1.Cells[1].Value = order.Shop.ShopName;
                    row1.Cells[2].Value = order.Shop.Shopkeeper.Name;
                    row1.Cells[3].Value = order.Shop.Address;
                    row1.Cells[4].Value = order.Shop.Shopkeeper.Contact;
                    dataGridViewOrders.Rows.Add(row1);
                }

                dataGridViewOrders.Refresh();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        public void BindDataForRider(string id)
        {
            try
            {
                dataGridViewOrders.RowCount = 1;
                List<Order> orders = OrderDL.convertToList();

                foreach (Order order in orders)
                {
                    if (order.RiderId == id)
                    {
                        DataGridViewRow row1 = (DataGridViewRow)dataGridViewOrders.Rows[0].Clone();
                        row1.Cells[0].Value = order.Id;
                        row1.Cells[1].Value = order.Shop.ShopName;
                        row1.Cells[2].Value = order.Shop.Shopkeeper.Name;
                        row1.Cells[3].Value = order.Shop.Address;
                        row1.Cells[4].Value = order.Shop.Shopkeeper.Contact;
                        dataGridViewOrders.Rows.Add(row1);
                    }
                }

                dataGridViewOrders.Refresh();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        public ucManageOrder ManageUI { get => manageUI; set => manageUI = value; }

        public void setAttributes(ucManageOrder m, ucSelectRider s)
        {
            manageUI = m;
            m.SelectRiderUI = s;
        }

        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            manageUI.Visible = true;

            if (dataGridViewOrders.RowCount > 0)
            {
                string id = (string)dataGridViewOrders.CurrentRow.Cells[0].Value;

                Order order = OrderDL.findByID(id);

                if(order != null)
                {
                    manageUI.Visible = true;
                    manageUI.SetOrder(order);
                    if (actor == "Manager" || actor == "Rider")
                        manageUI.hidebuttons();
                    this.Hide();
                    BindData();
                }
            }
        }
    }
}
