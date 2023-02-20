using GarmentsSquare.BL;
using GarmentsSquare.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarmentsSquare.UserControls
{
    public partial class ucManageEmployees : UserControl
    {
        private ucUpdateEmployee update;

        public ucUpdateEmployee Update1 { get => update; set => update = value; }

        public ucManageEmployees()
        {
            InitializeComponent();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search";
                txtSearch.ForeColor = Color.Silver;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.RowCount > 0)
            {
                Employee employee = (Employee)dataGridViewEmployees.CurrentRow.DataBoundItem;

                update.Visible = true;
                update.LoadValues(employee);
                BindData();
            }
        }

        private void ucManageEmployees_Load(object sender, EventArgs e)
        {
            BindData();
        }

        public void BindData()
        {
            dataGridViewEmployees.DataSource = null; 
            List<Employee> employees = EmployeeDL.convertToList();
            dataGridViewEmployees.DataSource = employees;
            dataGridViewEmployees.Columns["Next"].Visible = false;
            dataGridViewEmployees.Columns["Prev"].Visible = false;
            dataGridViewEmployees.Refresh();
        }

        private void dataGridViewEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.RowCount > 0)
            {
                Employee employee = (Employee)dataGridViewEmployees.CurrentRow.DataBoundItem;
                EmployeeDL.deleteEmployee(employee);
                BindData();
                EmployeeDL.storeData("Employees.csv");
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            List<Employee> employees = EmployeeDL.convertToList();
            string name = cmbSort.Text;
            if (name == "by...")
            {
                string message = "Please select the attribute from the combo box.";
                string caption = "Select Attribute";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
            if (name == "Id")
            {
                employees = employees.OrderBy(o => o.Id).ToList();
            }
            else if (name == "Name")
            {
                employees = employees.OrderBy(o => o.Name).ToList();
            }
            else if (name == "Salary")
            {
                employees = employees.OrderBy(o => o.Salary).ToList();
            }
            else if (name == "CNIC")
            {
                employees = employees.OrderBy(o => o.Cnic).ToList();
            }
            else if (name == "Email")
            {
                employees = employees.OrderBy(o => o.Email).ToList();
            }

            dataGridViewEmployees.DataSource = null;
            dataGridViewEmployees.DataSource = employees;
            dataGridViewEmployees.Columns["Next"].Visible = false;
            dataGridViewEmployees.Columns["Prev"].Visible = false;
            dataGridViewEmployees.Refresh();
        }
    }
}
