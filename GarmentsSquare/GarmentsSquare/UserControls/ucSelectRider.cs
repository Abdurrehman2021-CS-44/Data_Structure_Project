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
    public partial class ucSelectRider : UserControl
    {
        private Order order;
        public ucSelectRider()
        {
            InitializeComponent();

            BindData();
        }

        public Order Order { get => order; set => order = value; }

        public void BindData()
        {
            dgvRiders.DataSource = null;
            List<Rider> riders = RiderDL.convertToList();
            dgvRiders.DataSource = riders;
            dgvRiders.Columns["Next"].Visible = false;
            dgvRiders.Columns["Prev"].Visible = false;
            dgvRiders.Refresh();
        }

        private void dgvRiders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRiders.RowCount > 0)
            {
                Rider rider = (Rider)dgvRiders.CurrentRow.DataBoundItem;
                rider.assignOrder(order);

                RiderDL.storeData("Riders.csv");

                this.Visible = false;
            }
        }
    }
}
