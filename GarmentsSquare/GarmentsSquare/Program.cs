using GarmentsSquare.UIForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GarmentsSquare.DL;

namespace GarmentsSquare
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ProductDL.readData("Products.csv");
            EmployeeDL.readData("Employees.csv");
            UserDL.readData("Users.csv");
            ShopDL.readData("Shops.csv");
            OrderDL.readData("Orders.csv");
            RiderDL.readData("Riders.csv");

           // Utility.EmailSender.sendEmailOrderConfirmation( OrderDL.convertToList()[1]);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignInFrm());

        }
    }
}
