using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GarmentsSquare.BL;
using System.IO;

namespace GarmentsSquare.DL
{
    public class OrderDL
    {
        static Order head = null;
        static private int lastID = 0;

       
        static public Order findByID(string id)
        {
            Order temp = head;
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

        static private void generateID(Order order)
        {
            if (order.Id == "")
            {
                lastID += 1;
                order.Id = "O-" + lastID.ToString();
            }
        }
        static public void AddOrder(Order order)
        {
            generateID(order);

            if (head == null)
            {
                order.Next = head;

                if (head != null)
                {
                    head.Prev = order;
                }
                head = order;

                return;
            }
            Order temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = order;
            order.Prev = temp;
        }
        public static int lengthList()
        {
            int count = 0;
            Order order = head;
            while (order != null)
            {
                order = order.Next;
                count = count + 1;
            }
            return count;
        }
        public static bool readData(string path)
        {
            string id;
            string riderID, shopID;
            string data;
            double totalPrice;

            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string line;

                while ((line = file.ReadLine()) != null)
                {
                    string[] splittedRecord = line.Split(',');

                    id = splittedRecord[0];
                    riderID = splittedRecord[1];
                    shopID = splittedRecord[2];
                    data = splittedRecord[3];
                    totalPrice = double.Parse(splittedRecord[4]);

                    Shop shop = ShopDL.findByID(shopID);

                    string[] products = data.Split(';');
                    List<Product> productsList = new List<Product>();
                    productsList.Clear();
                    foreach( string product in products )
                    {
                        string[] pq = product.Split(':');
                        Product ab = ProductDL.findByID(pq[0]);
                        if (ab != null)
                        {
                            Product p = new Product(ab);
                            
                            productsList.Add(p);
                            p.Quantity = int.Parse(pq[1]);
                        }
                    }
                    products = null;

                    string[] temp = id.Split('-');
                    lastID = int.Parse(temp[1]);

                    Order order = new Order(id, riderID, shop, totalPrice, productsList); ;
                    AddOrder(order);
                }
                file.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        static public List<Order> convertToList()
        {
            List<Order> orderList = new List<Order>();

            Order temp = head;
            while (temp != null)
            {
                orderList.Add(temp);
                temp = temp.Next;
            }
            return orderList;
        }

        private static string productsDetails(Order order)
        {
            string res = "";
            
            for(int i =0; i<order.Products.Count; i++)
            {
                res += order.Products[i].Id + ":" + order.Products[i].Quantity.ToString();
                if( i < order.Products.Count - 1 )
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
            Order temp = head;
            while (temp != null)
            {
                i++;
                string a = productsDetails(temp);
                file.Write(temp.Id + "," + temp.RiderId + "," + temp.Shop.Id + "," + productsDetails(temp) + "," + temp.TotalPrice.ToString() );
                if (i < lengthList())
                {
                    file.WriteLine();
                }
                temp = temp.Next;
            }

            file.Flush();
            file.Close();
        }
        static public bool deleteOrder(Order order)
        {

            if (head == null || order == null)
            {
                return false;
            }

            if (head == order)
            {
                head = order.Next;
            }

            if (order.Next != null)
            {
                order.Next.Prev = order.Prev;
            }

            if (order.Prev != null)
            {
                order.Prev.Next = order.Next;
            }

            return true;
        }
    }
}