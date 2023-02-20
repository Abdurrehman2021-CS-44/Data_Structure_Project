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

namespace GarmentsSquare.UIForms
{
    public partial class AddToCart : Form
    {
        private Product product;
        private List<Product> products;
        public AddToCart(List<Product> products)
        {
            InitializeComponent();
            this.products = products;
        }

        public void LoadValues(Product product)
        {
            this.product = product;

            // filling the values of the product to be update in UI
            this.lblName.Text += product.Name;
            this.lblBrand.Text += product.Brand;
            this.lblColor.Text += product.Color;
            this.lblSize.Text += product.Size;
            this.lblPrice.Text += product.Price;
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (product.Quantity < npdQuantity.Value)
            {
                string message = "Please select the quantity under the available stock.";
                string caption = "Quantity Overflow";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons); ;
            }
            else
            {
                decimal q = this.npdQuantity.Value;
                int quantity = Convert.ToInt32(q);
                Product p = new Product(product.Id, product.Name, product.Brand, product.Color, product.Size, product.Price, quantity);
                if (products.Count == 0)
                {
                    products.Add(p);
                }
                for (int i = 0; i < products.Count; i++)
                {
                    if (p.Name == products[i].Name)
                    {
                        products[i].Quantity = p.Quantity;
                    }
                    else
                    {
                        products.Add(p);
                    }
                }
                this.Close();
            }
        }
    }
}
