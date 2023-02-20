using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GarmentsSquare.BL;

namespace GarmentsSquare.DL
{
    internal class EmployeeDL
    {
        static private Employee activeEmployee;
        static private Employee head = null;
        static private int lastID = 0;

        public static Employee ActiveEmployee { get => activeEmployee; set => activeEmployee = value; }
        
        static public void generateID(Employee e)
        {
            if (e.Id == "")
            {
                lastID += 1;
                e.Id = "E-" + lastID.ToString();
            }
        }

        static public Employee findByID(string id)
        {
            Employee temp = head;
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

        static public void AddEmployee(Employee n)
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
            Employee temp = head;
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
            Employee P = head;
            while (P != null)
            {
                P = P.Next;
                count = count + 1;
            }
            return count;
        }

        public static bool readData(string path)
        {
            string id, name, salary, email, contact, cnic;

            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string line;

                while ((line = file.ReadLine()) != null)
                {
                    string[] splittedRecord = line.Split(',');

                    id = splittedRecord[0];
                    name = splittedRecord[1];
                    salary = splittedRecord[2];
                    email = splittedRecord[3];
                    contact = splittedRecord[4];
                    cnic = splittedRecord[5];

                    string[] temp = id.Split('-');
                    lastID = int.Parse(temp[1]);

                    Employee employee = new Employee(id, name, float.Parse(salary), email, contact, cnic);
                    AddEmployee(employee);
                }
                file.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        static public List<Employee> convertToList()
        {
            List<Employee> employees = new List<Employee>();

            Employee temp = head;
            while (temp != null)
            {
                employees.Add(temp);
                temp = temp.Next;
            }
            return employees;
        }

        public static void storeData(string path)
        {

            StreamWriter file = new StreamWriter(path);
            int i = 0;
            Employee temp = head;
            while (temp != null)
            {
                i++;
                file.Write(temp.Id + "," + temp.Name + "," + temp.Salary + "," + temp.Email + "," + temp.Contact  + "," + temp.Cnic);
                if (i < lengthList())
                {
                    file.WriteLine();
                }
                temp = temp.Next;
            }

            file.Flush();
            file.Close();
        }

        static public bool deleteEmployee(Employee employee)
        {

            if (head == null || employee == null)
            {
                return false;
            }

            if (head == employee)
            {
                head = employee.Next;
            }

            if (employee.Next != null)
            {
                employee.Next.Prev = employee.Prev;
            }

            if (employee.Prev != null)
            {
                employee.Prev.Next = employee.Next;
            }

            return true;
        }

    }
}
