using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GarmentsSquare.BL;
using System.IO;

namespace GarmentsSquare.DL
{
    public class ShopDL
    {
        static Shop head = null;
        static private int lastID = 0;

        static private void generateID(Shop shop)
        {
            if (shop.Id == "")
            {
                lastID += 1;
                shop.Id = "S-" + lastID.ToString();
            }
        }
        static public void AddShop(Shop shop)
        {
            generateID(shop);

            if (head == null)
            {
                shop.Next = head;

                if (head != null)
                {
                    head.Prev = shop;
                }
                head = shop;

                return;
            }
            Shop temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = shop;
            shop.Prev = temp;
        }
        public static int lengthList()
        {
            int count = 0;
            Shop shop = head;
            while (shop != null)
            {
                shop = shop.Next;
                count = count + 1;
            }
            return count;
        }
        public static bool readData(string path)
        {
            string id;
            string shopname, landline, loc, email, contact, address, shopkeeperName, cnic;

            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string line;

                while ((line = file.ReadLine()) != null)
                {
                    string[] splittedRecord = line.Split(',');

                    id = splittedRecord[0];
                    shopname = splittedRecord[1];
                    landline = splittedRecord[2];
                    loc = splittedRecord[3];
                    string[] cord = loc.Split(':');
                    Location location = new Location(double.Parse(cord[0]), double.Parse(cord[1]));

                    address = splittedRecord[4];

                    shopkeeperName = splittedRecord[5];
                    email = splittedRecord[6];
                    contact = splittedRecord[7];
                    cnic = splittedRecord[8];


                    string[] temp = id.Split('-');
                    lastID = int.Parse(temp[1]);

                    Shopkeeper shopkeeper = new Shopkeeper(shopkeeperName, email, contact, cnic);
                    Shop shop = new Shop(id, shopname, landline, address, location, shopkeeper);
                    AddShop(shop);
                }
                file.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        static public List<Shop> convertToList()
        {
            List<Shop> shopList = new List<Shop>();

            Shop temp = head;
            while (temp != null)
            {
                shopList.Add(temp);
                temp = temp.Next;
            }
            return shopList;
        }
        public static void storeData(string path)
        {

            StreamWriter file = new StreamWriter(path);
            int i = 0;
            Shop temp = head;
            while (temp != null)
            {
                i++;
                string loc = temp.Location.Latitude.ToString() + ":" + temp.Location.Longitude.ToString();
                file.Write(temp.Id + "," + temp.ShopName + "," + temp.Landline + "," + loc + "," + temp.Address +  "," + temp.Shopkeeper.Name + "," + temp.Shopkeeper.Email + "," + temp.Shopkeeper.Contact + "," + temp.Shopkeeper.Cnic );
                //file.Write(temp.Id + "," + temp.ShopName + "," + temp.Landline + "," + temp.Address +  "," + temp.Shopkeeper.Name + "," + temp.Shopkeeper.Email + "," + temp.Shopkeeper.Contact + "," + temp.Shopkeeper.Cnic );
                if (i < lengthList())
                {
                    file.WriteLine();
                }
                temp = temp.Next;
            }

            file.Flush();
            file.Close();
        }
        static public bool deleteShop(Shop shop)
        {

            if (head == null || shop == null)
            {
                return false;
            }

            if (head == shop)
            {
                head = shop.Next;
            }

            if (shop.Next != null)
            {
                shop.Next.Prev = shop.Prev;
            }

            if (shop.Prev != null)
            {
                shop.Prev.Next = shop.Next;
            }

            return true;
        }

        static public Shop findByID(string id)
        {
            Shop temp = head;
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

    }
}
