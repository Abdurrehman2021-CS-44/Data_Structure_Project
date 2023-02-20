using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarmentsSquare.BL
{
    public class Order
    {
        private string id;
        private string riderId;
        private Shop shop;
        private double totalPrice;
        private List<Product> products;
        private Order next;
        private Order prev;

        public string Id { get => id; set => id = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
        internal Shop Shop { get => shop; set => shop = value; }
        internal Order Next { get => next; set => next = value; }
        internal Order Prev { get => prev; set => prev = value; }
        public List<Product> Products { get => products; set => products = value; }
        public string RiderId { get => riderId; set => riderId = value; }

        public Order(string riderId, Shop shop, double totalPrice, List<Product> products)
        {
            Id = "";
            RiderId = riderId;
            Shop = shop;
            TotalPrice = totalPrice;
            this.Products = products;
            next = null;
            prev = null;
        }
        public Order(string id ,string riderId, Shop shop, double totalPrice, List<Product> products)
        {
            Id = id;
            RiderId = riderId;
            Shop = shop;
            TotalPrice = totalPrice;
            this.Products = products;
            next = null;
            prev = null;
        }

        public Order(Order order)
        {
            this.id = order.Id;
            this.riderId = order.riderId;
            this.shop = order.shop;
            this.totalPrice = order.totalPrice;
            this.products = order.products;

            next = null;
            prev = null;
        }
    }
}
