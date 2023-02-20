using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using GarmentsSquare.BL;

namespace GarmentsSquare.DL
{
    internal class UserDL
    {
        public static List<User> UsersList = new List<User>();
        private static Random random = new Random();

        public static bool readData(string path)
        {

            string name, password, id, role;

            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string line;


                while ((line = file.ReadLine()) != null)
                {
                    string[] splittedRecord = line.Split(',');

                    name = splittedRecord[0];
                    id = splittedRecord[1];
                    password = splittedRecord[2];
                    role = splittedRecord[3];

                    User user = new User(name, password, id, role);
                    AddUserIntoList(user);
                }
                file.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void storeSingleObject(string path, User user)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(user.getUsername() + "," + user.ID + "," + user.getPassword() + "," + user.getRole());
            
            file.Flush();
            file.Close();
        }

        public static void storeData(string path)
        {

            StreamWriter file = new StreamWriter(path);
            int i = 0;
            foreach (User user in UsersList)
            {
                i++;
                file.Write(user.getUsername() + "," + user.ID + "," + user.getPassword() + "," + user.getRole());
                if (i < UsersList.Count)
                {
                    file.WriteLine();
                }
            }

            file.Flush();
            file.Close();
        }

        public static void AddUserIntoList(User User)
        {
            UsersList.Add(User);
        }

        public static bool isExist(User u)
        {
            foreach (User user in UsersList)
            {
                if (user.getUsername() == u.getUsername() )
                {
                    return true;
                }
            }
            return false;
        }

        public static User findUser(User user)
        {
            foreach (User u in UserDL.UsersList)
            {
                if (user.getUsername() == u.getUsername() && user.getPassword() == u.getPassword())
                {
                    return u;
                }
            }
            return null;
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
    }
}
