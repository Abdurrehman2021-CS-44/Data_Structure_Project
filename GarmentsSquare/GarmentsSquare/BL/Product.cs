using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarmentsSquare.BL
{
    public class Product
    {
        private string id;
        private string name;
        private string brand;
        private string color;
        private string size;
        private float price;
        private int quantity;

        private Product next;
        private Product prev;

        // constructors
        public Product(string id, string name, string brand, string color, string size, float price, int quantity)
        {
            this.id = id;
            this.name = name;
            this.brand = brand;
            this.color = color;
            this.size = size;
            this.price = price;
            this.quantity = quantity;
            this.next = null;
            this.prev = null;
        }

        public Product( string name, string brand, string color, string size, float price, int quantity)
        {
            this.id = "";
            this.name = name;
            this.brand = brand;
            this.color = color;
            this.size = size;
            this.price = price;
            this.quantity = quantity;
            this.next = null;
            this.prev = null;
        }

        public Product(Product p)
        {
            this.id = p.Id;
            this.name = p.Name;
            this.color = p.Color;
            this.size = p.Size;
            this.price = p.Price;
            this.quantity = p.Quantity;
            this.next = null;
            this.prev = null;
        }

        // getter setters
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Color { get => color; set => color = value; }
        public string Size { get => size; set => size = value; }
        public float Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public Product Next { get => next; set => next = value; }
        public Product Prev { get => prev; set => prev = value; }
    }
}
