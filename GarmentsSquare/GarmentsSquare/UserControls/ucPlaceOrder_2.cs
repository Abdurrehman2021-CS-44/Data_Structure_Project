using GarmentsSquare.BL;
using GarmentsSquare.DL;
using GarmentsSquare.UIForms;
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
    public partial class ucPlaceOrder_2 : UserControl
    {
        private Shop shop;
        private List<Product> products = new List<Product>();
        public Shop Shop { get => shop; set => shop = value; }

        double total = 0;

        public ucPlaceOrder_2()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order(RiderDL.ActiveRider.Id, shop, total, products);
            OrderDL.AddOrder(order);
            OrderDL.storeData("Orders.csv");
            this.Visible = false;
            /*List<Product> products = new List<Product>();
            string id, name, brand, color, size;
            float price;
            int quantity;
            for (int i = 0; i < dataGridViewProducts.Rows.Count; i++)
            {
                id = dataGridViewProducts.Rows[i].Cells[1].Value.ToString();
                name = dataGridViewProducts.Rows[i].Cells[2].Value.ToString();
                brand = dataGridViewProducts.Rows[i].Cells[3].Value.ToString();
                color = dataGridViewProducts.Rows[i].Cells[4].Value.ToString();
                size = dataGridViewProducts.Rows[i].Cells[5].Value.ToString();
                price = int.Parse(dataGridViewProducts.Rows[i].Cells[6].Value.ToString());
                quantity = int.Parse(dataGridViewProducts.Rows[i].Cells[8].Value.ToString());
                Product product = new Product(id, name, brand, color, size, price, quantity);
                products.Add(product);
                lblShopName.Text = id;
            }*/
        }

        public void LoadValues(Shop shop)
        {
            this.shop = shop;

            // filling the values of the product to be update in UI
            this.lblShopName.Text = "Shop: " + shop.ShopName;
            this.lblShopKeeper.Text = "Shopkeeper: " + shop.Shopkeeper.Name;
            this.lblContact.Text = "Contact: " + shop.Shopkeeper.Contact;
            this.lblEmail.Text = "Email: " + shop.Shopkeeper.Email;
            this.lblCnic.Text = "CNIC: " + shop.Shopkeeper.Cnic;
            this.lblAddress.Text = "Address: " + shop.Address.ToString();
            total = 0;
            this.lblTotal.Text = "0";
            BindData();
        }

        public void BindData()
        {
            dataGridViewProducts.DataSource = null;
            List<Product> products = ProductDL.convertToList();
            dataGridViewProducts.DataSource = products;

            dataGridViewProducts.Columns["Id"].DisplayIndex = 0;
            dataGridViewProducts.Columns["Name"].DisplayIndex = 1;
            dataGridViewProducts.Columns["Brand"].DisplayIndex = 2;
            dataGridViewProducts.Columns["Color"].DisplayIndex = 3;
            dataGridViewProducts.Columns["Size"].DisplayIndex = 4;
            dataGridViewProducts.Columns["Price"].DisplayIndex = 5;
            dataGridViewProducts.Columns["Quantity"].DisplayIndex = 6;

            dataGridViewProducts.Columns["Quantity"].HeaderText = "Available Quantity";

            dataGridViewProducts.Columns["Next"].Visible = false;
            dataGridViewProducts.Columns["Prev"].Visible = false;
            dataGridViewProducts.Refresh();

           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Product product = (Product)dataGridViewProducts.CurrentRow.DataBoundItem;
            if (dataGridViewProducts.Columns["AddtoCart"].Index == e.ColumnIndex)
            {
                AddToCart form = new AddToCart(products);
                form.LoadValues(product);
                form.ShowDialog();
            }

            total = 0;
            for (int i = 0; i < products.Count; i++)
            {
                total += products[i].Price * products[i].Quantity;
            }
            lblTotal.Text = total.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
