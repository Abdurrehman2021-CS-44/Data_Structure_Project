using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GarmentsSquare.BL;
using System.Net.Mail;
using System.Net;

namespace GarmentsSquare.Utility
{
    internal class EmailSender
    {
        static private string fromMail = "hamzarasheed19961@gmail.com";
        static private string fromPwd = "efgmnucymiafyvgj";


        // this email for when new employee/ rider added
        public static void sendEmailActorAdded(string sendTo, string name, string jobTitle, string id)
        {
            try
            {
                // creating new email message
                MailMessage message = new MailMessage();
                message.From = new MailAddress(fromMail); // from us
                message.To.Add(new MailAddress(sendTo)); // sending to email email

                // subject of email
                message.Subject = "Welcome to GARMENTS SQUARE";

                DateTime now = DateTime.Now.AddDays(2);
                string current = now.ToString("dd-MM-yyyy"); ;
                
                // body of email
                message.Body =
                    "<html><body>"
                + "Dear " + name + ",<br>"
                + "I am very pleased to announce " + name + " will be joining us as a " + jobTitle + ". "
                + "Welcome to Garments Square we are excited to look forward to seeing you on your start date of " + current + "."
                + "<br>Your ID is " + id + ".<br>"
                + "<br>"
                + "Thank you very much,<br><br>"
                + "Best regards,"
                + "<br><br>"
                + "Hamza Rasheed<br>"
                + "Manager<br>"
                + "Garments Square"
                + "</body></html>";

                message.IsBodyHtml = true;

                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(fromMail, fromPwd),
                    EnableSsl = true,
                };

                smtpClient.Send(message);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        public static void sendEmailActorAdded(string sendTo, string name, string jobTitle, string id, string username, string password)
        {
            try
            {
                // creating new email message
                MailMessage message = new MailMessage();
                message.From = new MailAddress(fromMail); // from us
                message.To.Add(new MailAddress(sendTo)); // sending to email email

                // subject of email
                message.Subject = "Welcome to GARMENTS SQUARE";

                DateTime now = DateTime.Now.AddDays(2);
                string current = now.ToString("dd-MM-yyyy"); ;

                // body of email
                message.Body =
                    "<html><body>"
                + "Dear " + name + ",<br>"
                + "I am very pleased to announce " + name + " will be joining us as a " + jobTitle + ". "
                + "Welcome to Garments Square we are excited to look forward to seeing you on your start date of " + current + "."
                + "<br>Your ID is " + id + ".<br>"
                + "<br>Your Username is " + username + ".<br>"
                + "<br>Your Password is " + password + ".<br>"
                + "<br>"
                + "Thank you very much,<br><br>"
                + "Best regards,"
                + "<br><br>"
                + "Hamza Rasheed<br>"
                + "Manager<br>"
                + "Garments Square"
                + "</body></html>";

                message.IsBodyHtml = true;

                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(fromMail, fromPwd),
                    EnableSsl = true,
                };

                smtpClient.Send(message);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }


        // this email for the confirmation of order delivered
        public static void sendEmailOrderConfirmation( Order order)
        {
            try
            {
                // creating new email message
                MailMessage message = new MailMessage();
                message.From = new MailAddress(fromMail); // from us
                message.To.Add(new MailAddress(order.Shop.Shopkeeper.Email)); // sending to email email

                // subject of email
                message.Subject = "Hey " + order.Shop.Shopkeeper.Name + ", your order is delivered! from GARMENTS SQUARE";

                DateTime now = DateTime.Now;
                string current = now.ToString("dd-MM-yyyy"); ;

                string msg = "";
                for (int i =0; i< order.Products.Count; i++)
                {
                    msg += (i+1).ToString() + ". " + order.Products[i].Name + " Q: " + order.Products[i].Quantity + "<br>";
                }

                // body of email
                message.Body =
                    "<html><body>"
                + "Dear " + order.Shop.Shopkeeper.Name + ",<br>"
                + "We’re happy to let you know that your order is delivered on " + current + ".<br>"
                + "We wish more order from your shop: " + order.Shop.ShopName + "."
                + "<br><br>ORDER SUMMARY:<br>"
                + "Order ID: " + order.Id + ".<br>"
                + "Order Total Price: " + order.TotalPrice + ".<br><br>"
                + "Products: <br>"
                + msg
                + "<br>"
                + "Thank you very much for order,<br><br>"
                + "Best regards,"
                + "<br><br>"
                + "Garments Square"
                + "</body></html>";

                message.IsBodyHtml = true;

                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(fromMail, fromPwd),
                    EnableSsl = true,
                };

                smtpClient.Send(message);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
