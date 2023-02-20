using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarmentsSquare.BL
{
    public class Shopkeeper
    {
        private string name;
        private string email;
        private string contact;
        private string cnic;

        public Shopkeeper(string name, string email, string contact, string cnic)
        {
            this.name = name;
            this.email = email;
            this.contact = contact;
            this.cnic = cnic;
        }

        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Cnic { get => cnic; set => cnic = value; }
    }
}
