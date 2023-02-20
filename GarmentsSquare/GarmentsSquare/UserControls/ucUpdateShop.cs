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
    public partial class ucUpdateShop : UserControl
    {
        private Shop sh;

        public Shop Sh { get => sh; set => sh = value; }

        public ucUpdateShop()
        {
            InitializeComponent();
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

        private void txtAdress_Enter(object sender, EventArgs e)
        {
            if (txtAdress.Text == "Address")
            {
                txtAdress.Text = "";
                txtAdress.ForeColor = Color.Black;
            }
        }

        private void txtAdress_Leave(object sender, EventArgs e)
        {
            if (txtAdress.Text == "")
            {
                txtAdress.Text = "Address";
                txtAdress.ForeColor = Color.Silver;
            }
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            resetFields();
        }

        private void btnAdd_Click(object sender, EventArgs e)
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


                Sh.Shopkeeper.Name = name;
                Sh.Shopkeeper.Email = email;
                Sh.Shopkeeper.Cnic = cnic;
                Sh.Shopkeeper.Contact = contact;
                Sh.ShopName = shopName;
                Sh.Landline = landline;
                Sh.Address = address;



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
                ShopDL.storeData("Shops.csv");
                this.Visible = false;
                resetFields();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public void LoadValues(Shop sh)
        {
            this.txtShopkeeperName.ForeColor = Color.Black;
            this.txtShopkeeperEmail.ForeColor = Color.Black;
            this.txtShopkeeperContact.ForeColor = Color.Black;
            this.txtShopkeeperCNIC.ForeColor = Color.Black;
            this.txtShopName.ForeColor = Color.Black;
            this.txtLandline.ForeColor = Color.Black;
            this.txtAdress.ForeColor = Color.Black;

            this.Sh = sh;

            // filling the values of the Shop to be update in UI
            this.txtShopkeeperName.Text = sh.Shopkeeper.Name;
            this.txtShopkeeperEmail.Text = sh.Shopkeeper.Email;
            this.txtShopkeeperContact.Text = sh.Shopkeeper.Contact;
            this.txtShopkeeperCNIC.Text = sh.Shopkeeper.Cnic;
            this.txtShopName.Text = sh.ShopName;
            this.txtLandline.Text = sh.Landline;
            this.txtAdress.Text = sh.Address;
        }
    }
}
