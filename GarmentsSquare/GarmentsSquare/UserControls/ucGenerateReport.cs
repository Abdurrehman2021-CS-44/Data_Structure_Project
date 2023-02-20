using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GarmentsSquare.BL;
using GarmentsSquare.DL;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;


namespace GarmentsSquare.UserControls
{
    public partial class ucGenerateReport : UserControl
    {
        public ucGenerateReport()
        {
            InitializeComponent();
        }

        private void dataGridViewEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Employee employee = (Employee)dataGridViewEmployees.CurrentRow.DataBoundItem;
            if (dataGridViewEmployees.Columns["Generate"].Index == e.ColumnIndex)
            {
                String path = employee.Name + " Report.pdf";
                PdfWriter writer = new PdfWriter(path);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);
                Paragraph header = new Paragraph("Garments Square")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(20)
                    .SetBold();
                document.Add(header);
                LineSeparator l1 = new LineSeparator(new SolidLine());
                document.Add(l1);

                Paragraph subheader = new Paragraph("***Performance Report of Employee***")
                   .SetTextAlignment(TextAlignment.CENTER)
                   .SetFontSize(15);
                document.Add(subheader);

                LineSeparator l2 = new LineSeparator(new SolidLine());
                document.Add(l2);

                Paragraph section_1 = new Paragraph("Personal Information")
                   .SetFontSize(12)
                   .SetBold();
                document.Add(section_1);

                string eId = "Id: " + employee.Id;
                Paragraph id = new Paragraph(eId);
                document.Add(id);

                string eName = "Name: " + employee.Name;
                Paragraph name = new Paragraph(eName);
                document.Add(name);

                string eContact = "Contact: " + employee.Contact;
                Paragraph contact = new Paragraph(eContact);
                document.Add(contact);

                string eEmail = "Email: " + employee.Email;
                Paragraph email = new Paragraph(eEmail);
                document.Add(email);

                LineSeparator l3 = new LineSeparator(new SolidLine());
                document.Add(l3);

                Paragraph section_2 = new Paragraph("Performance")
                   .SetFontSize(12)
                   .SetBold();
                document.Add(section_2);

                string eOrders = "Orders Manage: 50";
                Paragraph orders = new Paragraph(eOrders);
                document.Add(orders);

                string ePrice = "Price: 100000" + "\n\n";
                Paragraph price = new Paragraph(ePrice);
                document.Add(price);

                string eSalary = "Basic Salary: " + employee.Salary;
                Paragraph salary = new Paragraph(eSalary);
                document.Add(salary);

                string eBonus = "Bonus: 5000";
                Paragraph bonus = new Paragraph(eBonus);
                document.Add(bonus);

                string eTotal = "Total: " + (employee.Salary+5000);
                Paragraph total = new Paragraph(eTotal);
                document.Add(total);

                LineSeparator l4 = new LineSeparator(new SolidLine());
                document.Add(l4);

                document.Close();
                MessageBox.Show("Report of Employee is Generated");
                employeeBindData();
            }
        }

        private void dataGridViewRiders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Rider rider = (Rider)dataGridViewRiders.CurrentRow.DataBoundItem;
            if (dataGridViewRiders.Columns["Gen"].Index == e.ColumnIndex)
            {
                String path = rider.Name + " Report.pdf";
                PdfWriter writer = new PdfWriter(path);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);
                Paragraph header = new Paragraph("Garments Square")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(20)
                    .SetBold();
                document.Add(header);
                LineSeparator l1 = new LineSeparator(new SolidLine());
                document.Add(l1);

                Paragraph subheader = new Paragraph("***Performance Report of Rider***")
                   .SetTextAlignment(TextAlignment.CENTER)
                   .SetFontSize(15);
                document.Add(subheader);

                LineSeparator l2 = new LineSeparator(new SolidLine());
                document.Add(l2);

                Paragraph section_1 = new Paragraph("Personal Information")
                   .SetFontSize(12)
                   .SetBold();
                document.Add(section_1);

                string eId = "Id: " + rider.Id;
                Paragraph id = new Paragraph(eId);
                document.Add(id);

                string eName = "Name: " + rider.Name;
                Paragraph name = new Paragraph(eName);
                document.Add(name);

                string eContact = "Contact: " + rider.Contact;
                Paragraph contact = new Paragraph(eContact);
                document.Add(contact);

                string eEmail = "Email: " + rider.Email;
                Paragraph email = new Paragraph(eEmail);
                document.Add(email);

                string eArea = "Area: " + rider.Area.ToString();
                Paragraph area = new Paragraph(eArea);
                document.Add(area);

                LineSeparator l3 = new LineSeparator(new SolidLine());
                document.Add(l3);

                Paragraph section_2 = new Paragraph("Performance")
                   .SetFontSize(12)
                   .SetBold();
                document.Add(section_2);

                string eOrders = "Orders Placed: 20";
                Paragraph orders = new Paragraph(eOrders);
                document.Add(orders);

                string ePrice = "Total Price: 100000" + "\n\n";
                Paragraph price = new Paragraph(ePrice);
                document.Add(price);

                string eOrderDel = "Order Delivered: 15" + "\n\n";
                Paragraph order_delivered = new Paragraph(eOrderDel);
                document.Add(order_delivered);

                string eSalary = "Basic Salary: " + rider.Salary;
                Paragraph salary = new Paragraph(eSalary);
                document.Add(salary);

                string eBonus = "Bonus: 15000";
                Paragraph bonus = new Paragraph(eBonus);
                document.Add(bonus);

                string eTotal = "Total: " + (rider.Salary + 15000);
                Paragraph total = new Paragraph(eTotal);
                document.Add(total);

                LineSeparator l4 = new LineSeparator(new SolidLine());
                document.Add(l4);

                document.Close();
                MessageBox.Show("Report of Rider");
                riderBindData();
            }
        }

        private void ucGenerateReport_Load(object sender, EventArgs e)
        {
            employeeBindData();
            riderBindData();
        }

        public void employeeBindData()
        {
            dataGridViewEmployees.DataSource = null;
            List<Employee> employees = EmployeeDL.convertToList();
            dataGridViewEmployees.DataSource = employees;

            dataGridViewEmployees.Columns["Id"].DisplayIndex = 0;
            dataGridViewEmployees.Columns["Name"].DisplayIndex = 1;
            dataGridViewEmployees.Columns["Salary"].DisplayIndex = 2;
            dataGridViewEmployees.Columns["Email"].DisplayIndex = 3;
            dataGridViewEmployees.Columns["Generate"].DisplayIndex = 4;

            dataGridViewEmployees.Columns["Contact"].Visible = false;
            dataGridViewEmployees.Columns["Cnic"].Visible = false;
            dataGridViewEmployees.Columns["Next"].Visible = false;
            dataGridViewEmployees.Columns["Prev"].Visible = false;
            
            dataGridViewEmployees.Refresh();
        }

        public void riderBindData()
        {
            dataGridViewRiders.DataSource = null;
            List<Rider> rider = RiderDL.convertToList();
            dataGridViewRiders.DataSource = rider;

            dataGridViewRiders.Columns["Id"].DisplayIndex = 0;
            dataGridViewRiders.Columns["Name"].DisplayIndex = 1;
            dataGridViewRiders.Columns["Salary"].DisplayIndex = 2;
            dataGridViewRiders.Columns["Email"].DisplayIndex = 3;
            dataGridViewRiders.Columns["Area"].DisplayIndex = 4;
            dataGridViewRiders.Columns["Gen"].DisplayIndex = 5;

            dataGridViewRiders.Columns["Contact"].Visible = false;
            dataGridViewRiders.Columns["Cnic"].Visible = false;
            dataGridViewRiders.Columns["Next"].Visible = false;
            dataGridViewRiders.Columns["Prev"].Visible = false;

            dataGridViewRiders.Refresh();
        }
    }
}
