using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarmentsSquare.BL
{
    public class Rider : Person 
    {
        private Location position;
        private List<Shop> shops;
        private string area;

        private Rider next;
        private Rider prev;

        private List<Order> assignedOrders;
        public Rider(string id, string name, float salary, string email, string contact, string cnic, Location position, string area) : base(id, name, salary, email, contact, cnic)
        { 
            this.position = position;
            this.area = area;
            this.Next = null;
            this.Prev = null;
            assignedOrders = new List<Order>();
        }

        public Rider(string id, string name, float salary, string email, string contact, string cnic, Location position, string area, List<Order> orders) : base(id, name, salary, email, contact, cnic)
        {
            this.position = position;
            this.area = area;
            this.Next = null;
            this.Prev = null;
            assignedOrders = orders;
        }

        public Rider(string name, float salary, string email, string contact, string cnic, Location position, string area) : base(name, salary, email, contact, cnic)
        {
            this.position = position;
            this.area = area;
            this.Next = null;
            this.Prev = null;
            assignedOrders = new List<Order>();
        }


        public void assignOrder(Order order)
        {
            assignedOrders.Add(order);
        }

        public Order findOrder(string id)
        {
            foreach(Order order in assignedOrders)
            {
                if(order.Id == id)
                {
                    return order;
                }
            }
            return null;
        }

        public string Area { get => area; set => area = value; }
        public Rider Next { get => next; set => next = value; }
        public Rider Prev { get => prev; set => prev = value; }
        internal Location Position { get => position; set => position = value; }
        internal List<Shop> Shops { get => shops; set => shops = value; }
        public List<Order> AssignedOrders { get => assignedOrders; set => assignedOrders = value; }
    }
}
