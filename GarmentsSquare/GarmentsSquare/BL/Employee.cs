using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarmentsSquare.BL
{
    public class Employee : Person
    {

        private Employee next;
        private Employee prev;

        public Employee(string id, string name, float salary, string email, string contact, string cnic) :base(id,  name, salary, email, contact, cnic)
        {

            this.next = null;
            this.prev = null;
        }

        public Employee(string name, float salary, string email, string contact, string cnic) : base("", name, salary, email, contact, cnic)
        {
            this.next = null;
            this.prev = null;
        }

        public Employee Next { get => next; set => next = value; }
        public Employee Prev { get => prev; set => prev = value; }
    }
}
