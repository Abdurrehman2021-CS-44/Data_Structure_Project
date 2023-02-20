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
using GarmentsSquare.UIForms;

namespace GarmentsSquare.UserControls
{
    public partial class ucAddShop : UserControl
    {
        private BL.Location pointLocation;
        private string area;
        public ucAddShop()
        {
            InitializeComponent();
            pointLocation = new BL.Location();
            area = "";
        }

        private void txtShopkeeperName_Enter(object sender, EventArgs e)
        {
            if (txtShopkeeperName.Text == "Name")
            {
                txtShopkeeperName.Text = "";
                txtShopkeeperName.ForeColor = Color.Black;
            }
        }

        private void txtShopkeeperName_Leave(object sender, EventArgs e)
        {
            if (txtShopkeeperName.Text == "")
            {
                txtShopkeeperName.Text = "Name";
                txtShopkeeperName.ForeColor = Color.Silver;
            }
        }

        private void txtShopkeeperEmail_Enter(object sender, EventArgs e)
        {
            if (txtShopkeeperEmail.Text == "Email")
            {
                txtShopkeeperEmail.Text = "";
                txtShopkeeperEmail.ForeColor = Color.Black;
            }
        }

        private void txtShopkeeperEmail_Leave(object sender, EventArgs e)
        {
            if (txtShopkeeperEmail.Text == "")
            {
                txtShopkeeperEmail.Text = "Email";
                txtShopkeeperEmail.ForeColor = Color.Silver;
            }
        }

        private void txtShopkeeperContact_Enter(object sender, EventArgs e)
        {
            if (txtShopkeeperContact.Text == "Contact")
            {
                txtShopkeeperContact.Text = "";
                txtShopkeeperContact.ForeColor = Color.Black;
            }
        }

        private void txtShopkeeperContact_Leave(object sender, EventArgs e)
        {
            if (txtShopkeeperContact.Text == "")
            {
                txtShopkeeperContact.Text = "Contact";
                txtShopkeeperContact.ForeColor = Color.Silver;
            }
            if (string.IsNullOrEmpty(txtShopkeeperContact.Text) == true || this.txtShopkeeperContact.Text == "Contact")
            {
                /*txtShopkeeperContact.Focus();*/
                errorProvider1.SetError(this.txtShopkeeperContact,"Please fill contact number");
                
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtShopkeeperCNIC_Enter(object sender, EventArgs e)
        {
            if (txtShopkeeperCNIC.Text == "CNIC")
            {
                txtShopkeeperCNIC.Text = "";
                txtShopkeeperCNIC.ForeColor = Color.Black;
            }
        }

        private void txtShopkeeperCNIC_Leave(object sender, EventArgs e)
        {
            if (txtShopkeeperCNIC.Text == "")
            {
                txtShopkeeperCNIC.Text = "CNIC";
                txtShopkeeperCNIC.ForeColor = Color.Silver;
            }
            if (string.IsNullOrEmpty(txtShopkeeperCNIC.Text) == true || txtShopkeeperCNIC.Text == "CNIC")
            {
                /*txtShopkeeperContact.Focus();*/
                errorProvider2.SetError(txtShopkeeperCNIC, "Please");

            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void txtShopName_Enter(object sender, EventArgs e)
        {
            if (txtShopName.Text == "Name")
            {
                txtShopName.Text = "";
                txtShopName.ForeColor = Color.Black;
            }
        }

        private void txtShopName_Leave(object sender, EventArgs e)
        {
            if (txtShopName.Text == "")
            {
                txtShopName.Text = "Name";
                txtShopName.ForeColor = Color.Silver;
            }
        }

        private void txtLandline_Enter(object sender, EventArgs e)
        {
            if (txtLandline.Text == "Landline")
            {
                txtLandline.Text = "";
                txtLandline.ForeColor = Color.Black;
            }
        }

        private void txtLandline_Leave(object sender, EventArgs e)
        {
            if (txtLandline.Text == "")
            {
                txtLandline.Text = "Landline";
                txtLandline.ForeColor = Color.Silver;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            resetFields();
        }

        private void resetFields()
        {
            txtShopkeeperName.Text = "Name";
            txtShopkeeperName.ForeColor = Color.Silver;
            txtShopkeeperEmail.Text = "Email";
            txtShopkeeperEmail.ForeColor = Color.Silver;
            txtShopkeeperContact.Text = "Contact";
            txtShopkeeperContact.ForeColor = Color.Silver;
            txtShopkeeperCNIC.Text = "CNIC";
            txtShopkeeperCNIC.ForeColor = Color.Silver;
            txtShopName.Text = "Name";
            txtShopName.ForeColor = Color.Silver;
            txtLandline.Text = "Landline";
            txtLandline.ForeColor = Color.Silver;
            txtAdress.Text = "Address";
            txtAdress.ForeColor = Color.Silver;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                string name = this.txtShopkeeperName.Text;
                string email = this.txtShopkeeperEmail.Text;
                string contact = this.txtShopkeeperContact.Text;
                string cnic = this.txtShopkeeperCNIC.Text;
                string shopName = this.txtShopName.Text;
                string landline = this.txtLandline.Text;
                string address = this.txtAdress.Text;

                if (name == "Name")
                {
                    throw new Exception("Please enter the name.");
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
                area = address;
                Shopkeeper shopkeeper = new Shopkeeper(name, email, contact, cnic);

                Shop shop = new Shop(shopName, landline, address, shopkeeper);
                shop.Location = pointLocation;
               
                ShopDL.AddShop(shop);
                ShopDL.storeData("Shops.csv");
                resetFields();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            MapFrmAddLocation frm = new MapFrmAddLocation(pointLocation, area);
            frm.ShowDialog();
        }

        private void txtAdress_Enter_1(object sender, EventArgs e)
        {
            if (txtAdress.Text == "Address")
            {
                txtAdress.Text = "";
                txtAdress.ForeColor = Color.Black;
            }
        }

        private void txtAdress_Leave_1(object sender, EventArgs e)
        {
            if (txtAdress.Text == "")
            {
                txtAdress.Text = "Address";
                txtAdress.ForeColor = Color.Silver;
            }
        }
    }
}