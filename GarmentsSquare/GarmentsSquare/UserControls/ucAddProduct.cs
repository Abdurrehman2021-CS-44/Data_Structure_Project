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
    public partial class ucAddProduct : UserControl
    {
        public ucAddProduct()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = this.txtName.Text;
                string brand = this.txtBrand.Text;
                string color = this.txtColor.Text;
                float price = float.Parse(this.txtPrice.Text);
                string size = this.cbSize.Text;
                decimal q = this.nQuantity.Value;
                int quantity = Convert.ToInt32(q);

                if(name == "Name")
                {
                    throw new Exception("Please enter the name.");
                }
                if (brand == "Brand")
                {
                    throw new Exception("Please enter the Brand name.");
                }
                if (color == "Color")
                {
                    throw new Exception("Please enter the color.");
                }
                if (size == "Size")
                {
                    throw new Exception("Please select the size.");
                }
                if (price <=0 )
                {
                    throw new Exception("Please enter the correct price.");
                }
                if (quantity <= 0)
                {
                    throw new Exception("Quantity must be greater than zero.");
                }

                Product p = new Product(name, brand, color, size, price, quantity);
                ProductDL.AddProduct(p);
                ProductDL.storeData("Products.csv");
                ResetAttributes();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void ResetAttributes()
        {
            this.txtName.Text = "Name";
            txtName.ForeColor = Color.Silver;
            this.txtBrand.Text = "Brand";
            txtBrand.ForeColor = Color.Silver;
            this.txtColor.Text = "Color";
            txtColor.ForeColor = Color.Silver;
            this.txtPrice.Text = "0000";
            txtPrice.ForeColor = Color.Silver;
            this.cbSize.Text = "Size";
            this.nQuantity.Value = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetAttributes();
        }

        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        //----------------------------------
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

        private void txtColor_Enter(object sender, EventArgs e)
        {
            if (txtColor.Text == "Color")
            {
                txtColor.Text = "";
                txtColor.ForeColor = Color.Black;
            }
        }

        private void txtColor_Leave(object sender, EventArgs e)
        {
            if (txtColor.Text == "")
            {
                txtColor.Text = "Color";
                txtColor.ForeColor = Color.Silver;
            }
        }

        private void txtBrand_Enter(object sender, EventArgs e)
        {
            if (txtBrand.Text == "Brand")
            {
                txtBrand.Text = "";
                txtBrand.ForeColor = Color.Black;
            }
        }

        private void txtBrand_Leave(object sender, EventArgs e)
        {
            if (txtBrand.Text == "")
            {
                txtBrand.Text = "Brand";
                txtBrand.ForeColor = Color.Silver;
            }
        }

        private void cbSize_Enter(object sender, EventArgs e)
        {
            if (cbSize.Text == "Size")
            {
                cbSize.Text = "";
                cbSize.ForeColor = Color.Black;
            }
        }

        private void cbSize_Leave(object sender, EventArgs e)
        {
            if (cbSize.Text == "")
            {
                cbSize.Text = "Size";
            }
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            if (txtPrice.Text == "0000")
            {
                txtPrice.Text = "";
                txtPrice.ForeColor = Color.Black;
            }
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            if (txtPrice.Text == "")
            {
                txtPrice.Text = "0000";
                txtPrice.ForeColor = Color.Silver;
            }
        }

        private void nQuantity_Enter(object sender, EventArgs e)
        {
            if (nQuantity.Text == "0000")
            {
                nQuantity.Text = "";
                txtPrice.ForeColor = Color.Black;
            }
        }

        private void nQuantity_Leave(object sender, EventArgs e)
        {
            if (nQuantity.Text == "")
            {
                nQuantity.Text = "0";
            }
        }
    }
}
