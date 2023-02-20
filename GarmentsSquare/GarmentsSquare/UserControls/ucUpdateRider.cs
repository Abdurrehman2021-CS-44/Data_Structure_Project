using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarmentsSquare.UserControls
{
    public partial class ucUpdateRider : UserControl
    {
        public ucUpdateRider()
        {
            InitializeComponent();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Name")
            {
                txtName.Text = "";
                txtName.ForeColor = Color.Black;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Name";
                txtName.ForeColor = Color.Silver;
            }
        }

        private void txtContactNo_Enter(object sender, EventArgs e)
        {
            if (txtContactNo.Text == "Contact No")
            {
                txtContactNo.Text = "";
                txtContactNo.ForeColor = Color.Black;
            }
        }

        private void txtContactNo_Leave(object sender, EventArgs e)
        {
            if (txtContactNo.Text == "")
            {
                txtContactNo.Text = "Contact No";
                txtContactNo.ForeColor = Color.Silver;
            }
        }

        private void txtCnic_Enter(object sender, EventArgs e)
        {
            if (txtCnic.Text == "CNIC (Without Dashes)")
            {
                txtCnic.Text = "";
                txtCnic.ForeColor = Color.Black;
            }
        }

        private void txtCnic_Leave(object sender, EventArgs e)
        {
            if (txtCnic.Text == "")
            {
                txtCnic.Text = "CNIC (Without Dashes)";
                txtCnic.ForeColor = Color.Silver;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.Silver;
            }
        }

        private void txtSalary_Enter(object sender, EventArgs e)
        {
            if (txtSalary.Text == "Salary")
            {
                txtSalary.Text = "";
                txtSalary.ForeColor = Color.Black;
            }
        }

        private void txtSalary_Leave(object sender, EventArgs e)
        {
            if (txtSalary.Text == "")
            {
                txtSalary.Text = "Salary";
                txtSalary.ForeColor = Color.Silver;
            }
        }
        private void resetFields()
        {
            txtName.Text = "Name";
            txtName.ForeColor = Color.Silver;
            txtContactNo.Text = "Contact No";
            txtContactNo.ForeColor = Color.Silver;
            txtEmail.Text = "Email";
            txtEmail.ForeColor = Color.Silver;
            txtCnic.Text = "CNIC (Without Dashes)";
            txtCnic.ForeColor = Color.Silver;
            txtSalary.Text = "Salary";
            txtSalary.ForeColor = Color.Silver;
            txtArea.Text = "Area";
            txtArea.ForeColor = Color.Silver;
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            resetFields();
        }
    }
}
