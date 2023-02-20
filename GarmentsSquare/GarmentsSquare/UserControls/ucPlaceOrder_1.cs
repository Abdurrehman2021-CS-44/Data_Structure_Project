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
    public partial class ucPlaceOrder_1 : UserControl
    {
        private ucPlaceOrder_2 placeOrder_2;
        public ucPlaceOrder_1()
        {
            InitializeComponent();
        }

        public ucPlaceOrder_2 PlaceOrder_2 { get => placeOrder_2; set => placeOrder_2 = value; }

        public void BindData()
        {
            dataGridViewShopes.DataSource = null;
            List<Shop> shops = ShopDL.convertToList();
            dataGridViewShopes.DataSource = shops;

            dataGridViewShopes.Columns["Id"].DisplayIndex = 0;
            dataGridViewShopes.Columns["ShopName"].DisplayIndex = 1;
            dataGridViewShopes.Columns["Landline"].DisplayIndex = 2;
            dataGridViewShopes.Columns["Address"].DisplayIndex = 3;
            dataGridViewShopes.Columns["Select"].DisplayIndex = 5;

            dataGridViewShopes.Columns["Location"].Visible = false;
            dataGridViewShopes.Columns["Next"].Visible = false;
            dataGridViewShopes.Columns["Prev"].Visible = false;
            dataGridViewShopes.Refresh();
        }

        private void dataGridViewShopes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Shop shop = (Shop)dataGridViewShopes.CurrentRow.DataBoundItem;
            if (dataGridViewShopes.Columns["Select"].Index == e.ColumnIndex)
            {
                placeOrder_2.LoadValues(shop);
                placeOrder_2.Visible = true;
            }
        }
        private void ucPlaceOrder_1_Load(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
