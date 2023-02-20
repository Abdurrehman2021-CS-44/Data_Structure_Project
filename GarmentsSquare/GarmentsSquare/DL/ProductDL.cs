using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using GarmentsSquare.BL;

namespace GarmentsSquare.DL
{
    internal class ProductDL
    {

        static Product head = null;
        static private int lastID = 0;

        static private void generateID(Product p)
        {
            if(p.Id == "")
            {
                lastID += 1;
                p.Id = "P-" + lastID.ToString();
            }
        }

        static public void AddProduct(Product n)
        {
            generateID(n);

            if (head == null)
            {
                n.Next = head;

                if (head != null)
                {
                    head.Prev = n;
                }
                head = n;

                return;
            }
            Product temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = n;
            n.Prev = temp;
        }


        public static int lengthList()
        {
            int count = 0;
            Product P = head;
            while (P != null)
            {
                P = P.Next;
                count = count + 1;
            }
            return count;
        }

        public static bool readData(string path)
        {
            string id, name, brand, color, size, price, quantity;
 
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string line;

                while ((line = file.ReadLine()) != null)
                {
                    string[] splittedRecord = line.Split(',');

                    id = splittedRecord[0];
                    name = splittedRecord[1];
                    brand = splittedRecord[2];
                    color = splittedRecord[3];
                    size = splittedRecord[4];
                    price = splittedRecord[5];
                    quantity = splittedRecord[6];

                    string[] temp = id.Split('-');
                    lastID = int.Parse(temp[1]);

                    Product product = new Product(id, name, brand, color, size, float.Parse(price), int.Parse(quantity));
                    AddProduct(product);
                }
                file.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        static public List<Product>  convertToList()
        {
            List<Product> products = new List<Product>();

            Product temp = head;
            while (temp != null)
            {
                products.Add(temp);
                temp = temp.Next;
            }
            return products;
        }

        static public Product findByID(string id)
        {
            Product temp = head;
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

        public static void storeData(string path)
        {

            StreamWriter file = new StreamWriter(path);
            int i = 0;
            Product temp = head;
            while (temp != null)
            {
                i++;
                file.Write(temp.Id + "," + temp.Name + "," + temp.Brand + "," + temp.Color + "," + temp.Size + "," + temp.Price + "," + temp.Quantity);
                if (i < lengthList())
                {
                    file.WriteLine();
                }
                temp = temp.Next;
            }

            file.Flush();
            file.Close();
        }

        // Function to delete a node in a Doubly Linked List.
        static public bool deleteProduct(Product product)
        {

            if (head == null || product == null)
            {
                return false;
            }

            if (head == product)
            {
                head = product.Next;
            }

            if (product.Next != null)
            {
                product.Next.Prev = product.Prev;
            }

            if (product.Prev != null)
            {
                product.Prev.Next = product.Next;
            }

            return true;
        }

    }
}
