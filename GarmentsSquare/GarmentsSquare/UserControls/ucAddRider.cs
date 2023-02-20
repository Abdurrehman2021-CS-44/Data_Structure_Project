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
    public partial class ucAddRider : UserControl
    {
        private static Random random = new Random();

        public ucAddRider()
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


        private void btnClearFields_Click(object sender, EventArgs e)
        {
            resetFields();
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

        private void btnAddRider_Click(object sender, EventArgs e)
        {
            try
            {
                string name = this.txtName.Text;
                string email = this.txtEmail.Text;
                string contact = this.txtContactNo.Text;
                string cnic = this.txtCnic.Text;
                string area = this.txtArea.Text;
                float salary = float.Parse(this.txtSalary.Text);
                

                if (name == "Name")
                {
                    throw new Exception("Please enter the name.");
                }
                if (salary <= 0)
                {
                    throw new Exception("Please enter the Salray in Correct Formate.");
                }
                if (email == "Email")
                {
                    throw new Exception("Please enter the email.");
                }
                if (email.Contains("@gmail.com") == false)
                {
                    throw new Exception("Please enter the email correctly.");
                }
                if (contact == "Contact")
                {
                    throw new Exception("Please enter the contact.");
                }
                if (contact.Length != 11)
                {
                    throw new Exception("Please enter the contact no. correctly.");
                }
                if (contact[0] != '0' && contact[1] != '3')
                {
                    throw new Exception("Please enter the contact no. correctly.");
                }
                for (int i = 0; i < contact.Length; i++)
                {
                    if (Char.IsDigit(contact, i) == false)
                    {
                        throw new Exception("Please enter the contact no. correctly.");
                    }
                }
                if (cnic == "CNIC")
                {
                    throw new Exception("Please enter the cnic.");
                }
                if (area == "Area")
                {
                    throw new Exception("Please enter the Area.");
                }
                if (cnic.Length != 13)
                {
                    throw new Exception("Please enter the cnic correctly.");
                }
                for (int i = 0; i < cnic.Length; i++)
                {
                    if (Char.IsDigit(cnic, i) == false)
                    {
                        throw new Exception("Please enter the cnic correctly.");
                    }
                }

                Location location = new Location();

                Rider rider = new Rider(name, salary, email, contact, cnic, location, area);
                RiderDL.AddRider(rider);

                string username = UserDL.RandomString(8);
                string password = UserDL.CreatePassword(8);
                // adding new user credentials
                User user = new User(username, password, rider.Id, "Rider");
                UserDL.AddUserIntoList(user);
                UserDL.storeSingleObject("Users.csv", user);


                // sending email to newly added Rider
                Utility.EmailSender.sendEmailActorAdded(rider.Email, rider.Name, "Rider", rider.Id);

                RiderDL.storeData("Riders.csv");
                resetFields();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
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
        

        private void txtCnic_Enter_1(object sender, EventArgs e)
        {
            if (txtCnic.Text == "CNIC (Without Dashes)")
            {
                txtCnic.Text = "";
                txtCnic.ForeColor = Color.Black;
            }
        }

        private void txtCnic_Leave_1(object sender, EventArgs e)
        {
            if (txtCnic.Text == "")
            {
                txtCnic.Text = "CNIC (Without Dashes)";
                txtCnic.ForeColor = Color.Silver;
            }
        }

        private void txtEmail_Enter_1(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave_1(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.Silver;
            }
        }

        private void txtArea_Enter_1(object sender, EventArgs e)
        {
            if (txtArea.Text == "Area")
            {
                txtArea.Text = "";
                txtArea.ForeColor = Color.Black;
            }
        }

        private void txtArea_Leave_1(object sender, EventArgs e)
        {
            if (txtArea.Text == "")
            {
                txtArea.Text = "Area";
                txtArea.ForeColor = Color.Silver;
            }
        }
    }
}
