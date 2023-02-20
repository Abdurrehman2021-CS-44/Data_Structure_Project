using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GarmentsSquare.UserControls;

namespace GarmentsSquare.UIForms
{
    public partial class EmployeeHome : Form
    {
        private UserControl current = new UserControl();
        public EmployeeHome()
        {
            InitializeComponent();
            enableButtons();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            enableButtons();
            current.Visible = false;
            btnAddProduct.Enabled = false;
            current = ucAddProduct1 as UserControl;
            current.Visible = true;

        }

        private void EmployeeHome_Load(object sender, EventArgs e)
        {

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            enableButtons();
            current.Visible = false;
            btnInventory.Enabled = false;
            ucInventory1.BindData();
            ucInventory1.UpdateUserControl = ucUpdateProduct1;
            current = ucInventory1;
            current.Visible = true;
        }

        private void enableButtons()
        {
            //current.Visible = false;
            ucUpdateProduct1.Visible = false;
            ucManageOrder1.Visible = false;
            ucSelectRider1.Visible = false;
            ucAddProduct1.Visible = false;
            ucInventory1.Visible = false;
            ucUpdateProduct1.Visible = false;
            ucViewOrders1.Visible = false;
            ucManageOrder1.Visible = false;
            ucManageRider1.Visible = false;
            ucAddRider1.Visible = false;

            btnAddProduct.Enabled = true;
            btnInventory.Enabled=true;
            btnAddRider.Enabled = true;
            btnManageOrders.Enabled = true;
            btnManageRider.Enabled = true;
        }

        private void btnManageOrders_Click(object sender, EventArgs e)
        {
            enableButtons();

            btnManageOrders.Enabled = false;
            current.Visible = false;
            current = ucViewOrders1;
            ucViewOrders1.setAttributes(ucManageOrder1, ucSelectRider1) ;
            ucViewOrders1.BindData();
            current.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignInFrm frm = new SignInFrm();
            frm.Show();
        }

        private void btnAddRider_Click(object sender, EventArgs e)
        {
            enableButtons();
            current.Visible = false;
            btnAddRider.Enabled = false;
            current = ucAddRider1 as UserControl;
            current.Visible = true;
        }

        private void btnManageRider_Click(object sender, EventArgs e)
        {
            enableButtons();
            current.Visible = false;
            btnManageRider.Enabled = false;
            current = ucManageRider1;
            ucManageRider1.BindData();
            current.Visible = true;
        }
    }
}
