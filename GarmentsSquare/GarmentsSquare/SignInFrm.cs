using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GarmentsSquare.UIForms;
using GarmentsSquare.BL;
using GarmentsSquare.DL;

namespace GarmentsSquare
{
    public partial class SignInFrm : Form
    {
        public SignInFrm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string password = this.txtPassword.Text;
            string username = this.txtUsername.Text;
            string role;
            User user = new User();

            if (username != "" && password != "")
            {
                User u = new User(username, password);

                user = UserDL.findUser(u);
                if (user != null)
                {
                    role = user.getRole();
                }
                else
                {
                    role = "nill";
                }
            }
            else
            {
                role = "nill";
            }

            if (role == "Manager")
            {
                //..
                // Manager form code
                //..

                string id = user.ID;

                this.Hide();
                ManagerHome mangerfrm = new ManagerHome();
                mangerfrm.Show();

            }
            else if (role == "Employee")
            {
                //..
                // Employee form code
                //..

                string id = user.ID;
                Employee employee = EmployeeDL.findByID(id);

                if (employee != null)
                {
                    EmployeeDL.ActiveEmployee = employee;
                    this.Hide();
                    EmployeeHome employeefrm = new EmployeeHome();
                    employeefrm.Show();
                }

            }
            else if (role == "Rider")
            {
                //..
                // Rider form code
                //..

                string id = user.ID;
                Rider rider = RiderDL.findByID(id);

                if (rider != null)
                {
                    RiderDL.ActiveRider = rider;
                    this.Hide();
                    RiderHome riderfrm = new RiderHome();
                    riderfrm.Show();
                }

            }
            else
            {
                MessageBox.Show("    Invalid Input !  ");
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if(txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Silver;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                /*txtPassword.UseSystemPasswordChar = false;*/
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Silver;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }
    }
}
