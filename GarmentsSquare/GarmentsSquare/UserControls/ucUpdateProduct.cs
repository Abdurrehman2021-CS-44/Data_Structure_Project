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
    public partial class ucUpdateProduct : UserControl
    {
        private Product product;
        public ucUpdateProduct( )
        {
            InitializeComponent();
            
            
        }

        public void LoadValues(Product product)
        {
            this.product = product;

            // filling the values of the product to be update in UI
            this.txtName.Text = product.Name;
            this.txtBrand.Text = product.Brand;
            this.txtColor.Text = product.Color;
            this.txtPrice.Text = product.Price.ToString();
            this.cbSize.Text = product.Size;
            this.nQuantity.Value = product.Quantity;
        }


        private void btnUpdate_Click_1(object sender, EventArgs e)
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

                if (name == "Name")
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
                if (price <= 0)
                {
                    throw new Exception("Please enter the correct price.");
                }
                if (quantity <= 0)
                {
                    throw new Exception("Quantity must be greater than zero.");
                }

                product.Name = name;
                product.Brand = brand;
                product.Color = color;
                product.Price = price;
                product.Size = size;
                product.Quantity = quantity;

                ProductDL.storeData("Products.csv");
                this.Visible = false;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
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

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Name";
                txtName.ForeColor = Color.Silver;
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

        private void txtBrand_Leave(object sender, EventArgs e)
        {
            if (txtBrand.Text == "")
            {
                txtBrand.Text = "Brand";
                txtBrand.ForeColor = Color.Silver;
            }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Name")
            {
                txtName.Text = "";
                txtName.ForeColor = Color.Black;
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

        private void txtBrand_Enter(object sender, EventArgs e)
        {
            if (txtBrand.Text == "Brand")
            {
                txtBrand.Text = "";
                txtBrand.ForeColor = Color.Black;
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
    }
}
