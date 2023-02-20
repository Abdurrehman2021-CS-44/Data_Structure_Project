using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarmentsSquare.BL
{
    public class Person
    {
        private string id;
        private string name;
        private float salary;
        private string contact;
        private string cnic;
        private string email;


        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public float Salary { get => salary; set => salary = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Cnic { get => cnic; set => cnic = value; }
        public string Email { get => email; set => email = value; }

        public Person(string id, string name, float salary, string email, string contact, string cnic)
        {
            this.Id = id;
            this.name = name;
            this.salary = salary;
            this.Email = email;
            this.contact = contact;
            this.cnic = cnic;
        }
        public Person(string name, float salary, string email, string contact, string cnic)
        {
            this.Id = "";
            this.name = name;
            this.salary = salary;
            this.Email = email;
            this.contact = contact;
            this.cnic = cnic;
        }
    }
}
