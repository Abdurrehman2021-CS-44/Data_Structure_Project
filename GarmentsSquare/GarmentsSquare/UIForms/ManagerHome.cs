using GarmentsSquare.UserControls;
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
    public partial class ManagerHome : Form
    {
        

        public ManagerHome()
        {
            InitializeComponent();

            enableButtons();
        }

        private void ManagerHome_Load(object sender, EventArgs e)
        {
            enableButtons();
        }

        private void btnManageEmployee_Click(object sender, EventArgs e)
        {
            enableButtons();

            ucManageEmployees2.BindData();
            ucManageEmployees2.Update1 = ucUpdateEmployee2;
            ucManageEmployees2.Visible = true;
            btnManageEmployee.Enabled = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SignInFrm frm = new SignInFrm();
            frm.Show();
            this.Hide();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            enableButtons();

            btnGenerateReport.Enabled = false;
            ucGenerateReport1.Visible = true;
        }

        private void btnManageRider_Click(object sender, EventArgs e)
        {
            enableButtons();

            ucManageRider1.BindData();
            //ucManageRider1.Update1 = ucUpdateEmployee2;
            ucManageRider1.Visible = true;
            btnManageRider.Enabled = false;
        }

        private void enableButtons()
        {
            // making invisible all user controls
            ucAddEmployee1.Visible = false;
            ucManageEmployees2.Visible = false;
            ucUpdateEmployee2.Visible = false;
            ucGenerateReport1.Visible = false;
            ucViewOrders1.Visible = false;
            ucManageOrder1.Visible = false;
            ucUpdateEmployee1.Visible = false;
            ucAddRider1.Visible = false;
            ucManageRider1.Visible = false;

            // enabling all buttons
            btnAddEmployee.Enabled = true;
            btnManageEmployee.Enabled = true;
            btnAddRider.Enabled = true;
            btnManageRider.Enabled = true;
            btnViewOrders.Enabled = true;
            btnGenerateReport.Enabled = true;
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            enableButtons();
            
            ucViewOrders1.Visible = true;
            btnViewOrders.Enabled = false;
            ucViewOrders1.ManageUI = ucManageOrder1;
            ucViewOrders1.setActor("Manager");
            ucViewOrders1.BindData();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            enableButtons();

            btnAddEmployee.Enabled = false;
            ucAddEmployee1.Visible = true;
        }

        private void btnAddRider_Click(object sender, EventArgs e)
        {
            enableButtons();

            btnAddRider.Enabled = false;
            ucAddRider1.Visible = true;
        }
    }
}
