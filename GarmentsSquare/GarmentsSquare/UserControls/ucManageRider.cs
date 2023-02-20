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
    public partial class ucManageRider : UserControl
    {
        private ucUpdateEmployee update;
        public ucManageRider()
        {
            InitializeComponent();
        }

        private void ucManageRider_Load(object sender, EventArgs e)
        {
            BindData();
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
            dataGridViewRiders.DataSource = null;
            List<Rider> riderList = RiderDL.convertToList();
            dataGridViewRiders.DataSource = riderList;
            dataGridViewRiders.Columns["Next"].Visible = false;
            dataGridViewRiders.Columns["Prev"].Visible = false;
            dataGridViewRiders.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewRiders.RowCount > 0)
            {
                Rider rider = (Rider)dataGridViewRiders.CurrentRow.DataBoundItem;
                RiderDL.deleteRider(rider);
                BindData();
                RiderDL.storeData("Riders.csv");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
