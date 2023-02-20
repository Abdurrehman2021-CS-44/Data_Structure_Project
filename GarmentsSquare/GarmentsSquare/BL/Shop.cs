using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarmentsSquare.BL
{
    public class Shop
    {
        private string id;
        private string shopName;
        private string landline;
        private string address;
        private Location location;
        private Shopkeeper shopkeeper;

        private Shop next;
        private Shop prev;

        public Shop(string shopName, string landline, string address, Location location, Shopkeeper shopkeeper)
        {
            ShopName = shopName;
            Landline = landline;
            Address = address;
            Location = location;
            Shopkeeper = shopkeeper;
        }

        public Shop(string shopName, string landline, string address, Shopkeeper shopkeeper)
        {
            id = "";
            ShopName = shopName;
            Landline = landline;
            Address = address;
            Shopkeeper = shopkeeper;
            this.location = new Location();
        }

        public Shop(string id, string shopName, string landline, string address, Location location, Shopkeeper shopkeeper)
        {
            this.id = id;
            this.shopName = shopName;
            this.landline = landline;
            this.address = address;
            this.location = location;
            this.shopkeeper = shopkeeper;
        }

        public string Id { get => id; set => id = value; }
        public string ShopName { get => shopName; set => shopName = value; }
        public string Landline { get => landline; set => landline = value; }
        public string Address { get => address; set => address = value; }
        public Location Location { get => location; set => location = value; }
        public Shop Prev { get => prev; set => prev = value; }
        public Shop Next { get => next; set => next = value; }
        internal Shopkeeper Shopkeeper { get => shopkeeper; set => shopkeeper = value; }
    }
}
