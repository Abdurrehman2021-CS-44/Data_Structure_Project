using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarmentsSquare.BL
{
    public class User
    {
        private string username;
        private string password;
        private string id;
        private string role;

        public string ID { get => id; set => id = value; }

        public User()
        {
            this.username = "";
            this.password = "";
            this.id = "";
            this.role = "";
        }

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
            role = "nill";
        }

        public User(string username, string password, string id, string role)
        {
            this.username = username;
            this.password = password;
            this.id = id;
            this.role = role;
        }

        public string getUsername()
        {
            return username;
        }
        public string getPassword()
        {
            return password;
        }
        public string getRole()
        {
            return role;
        }

        public void setUsername(string username)
        {
            this.username = username;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public void setRole(string role)
        {
            this.role = role;
        }

       
    }
}
