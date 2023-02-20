using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GarmentsSquare.BL;
using System.IO;

namespace GarmentsSquare.DL
{
    public class RiderDL
    {
        static private Rider activeRider ;
        static Rider head = null;
        static private int lastID = 0;

        public static Rider ActiveRider { get => activeRider; set => activeRider = value; }

        static private void generateID(Rider r)
        {
            if (r.Id == "")
            {
                lastID += 1;
                r.Id = "R-" + lastID.ToString();
            }
        }
        static public void AddRider(Rider r)
        {
            generateID(r);

            if (head == null)
            {
                r.Next = head;

                if (head != null)
                {
                    head.Prev = r;
                }
                head = r;

                return;
            }
            Rider temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = r;
            r.Prev = temp;
        }
        public static int lengthList()
        {
            int count = 0;
            Rider r = head;
            while (r != null)
            {
                r = r.Next;
                count = count + 1;
            }
            return count;
        }

        static public Rider findByID(string id)
        {
            Rider temp = head;
            while (temp != null)
            {
                if (temp.Id == id)
                {
                    return temp;
                }
                temp = temp.Next;
            }
            return null;
        }

        public static bool readData(string path)
        {
            string area;
            int longitude;
            int latitude;
            string id;
            string name, email, contact, cnic, data;
            float salary;

            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string line;

                while ((line = file.ReadLine()) != null)
                {
                    string[] splittedRecord = line.Split(',');

                    id = splittedRecord[0];
                    name = splittedRecord[1];
                    salary = float.Parse(splittedRecord[2]);
                    email = splittedRecord[3];
                    contact = splittedRecord[4];
                    cnic = splittedRecord[5];

                    area = splittedRecord[6];
                    longitude = int.Parse(splittedRecord[7]);
                    latitude = int.Parse(splittedRecord[8]);

                    data = splittedRecord[9];

                    string[] temp = id.Split('-');
                    lastID = int.Parse(temp[1]);

                    string[] orders = data.Split(';');
                    List<Order> ordersList = new List<Order>();
                    foreach (string order in orders)
                    {
                        Order ab = OrderDL.findByID(order);
                        if (ab != null)
                        {
                            Order o = new Order(ab);

                            ordersList.Add(o);
                        }
                    }

                    Location position = new Location(latitude, longitude);
                    Rider rider = new Rider(id, name, salary, email, contact, cnic, position, area, ordersList);
                    AddRider(rider);
                }
                file.Close();
                return true;
            }
            else
            {
                return false;
            }

        }
        static public List<Rider> convertToList()
        {
            List<Rider> riderList = new List<Rider>();

            Rider temp = head;
            while (temp != null)
            {
                riderList.Add(temp);
                temp = temp.Next;
            }
            return riderList;
        }
        private static string assignOrdersDetails(Rider rider)
        {
            string res = "";

            for (int i = 0; i < rider.AssignedOrders.Count; i++)
            {
                res += rider.AssignedOrders[i].Id;
                if (i < rider.AssignedOrders.Count - 1)
                {
                    res += ";";
                }
            }
            return res;
        }

        public static void storeData(string path)
        {

            StreamWriter file = new StreamWriter(path);
            int i = 0;
            Rider temp = head;
            while (temp != null)
            {
                i++;
                file.Write(temp.Id + "," + temp.Name + "," + temp.Salary + "," + temp.Email + "," + temp.Contact + "," +  temp.Cnic + "," + temp.Area + "," + temp.Position.Latitude + "," + temp.Position.Longitude + "," + assignOrdersDetails(temp));
                if (i < lengthList())
                {
                    file.WriteLine();
                }
                temp = temp.Next;
            }

            file.Flush();
            file.Close();
        }
        static public bool deleteRider(Rider rider)
        {

            if (head == null || rider == null)
            {
                return false;
            }

            if (head == rider)
            {
                head = rider.Next;
            }

            if (rider.Next != null)
            {
                rider.Next.Prev = rider.Prev;
            }

            if (rider.Prev != null)
            {
                rider.Prev.Next = rider.Next;
            }

            return true;
        }
    }
}
