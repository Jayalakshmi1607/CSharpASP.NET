using EIS.Models;
using EIS.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EIS.MainApp
{
    public partial class Form1 : Form
    {
        EmployeeRepo empRepo = new EmployeeRepo();
        Employee emp = new Employee();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            emp.ID = textBoxID.Text;
            emp.Name = textBoxName.Text;
            emp.Position = textBoxPosition.Text;
            empRepo.AddEmployee(emp);
            loadEmployees();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadEmployees();
        }
        private void loadEmployees()
        {
            dataGridViewEmployee.DataSource = null;
            dataGridViewEmployee.DataSource = empRepo.GetAllEmployee();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            emp.ID = textBoxID.Text;
            emp.Name = textBoxName.Text;
            emp.Position = textBoxPosition.Text;
            empRepo.UpdateEmployee(emp);
            loadEmployees();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            emp.ID = textBoxID.Text;
            emp.Name = textBoxName.Text;
            emp.Position = textBoxPosition.Text;
            empRepo.DeleteEmployee(emp);
            loadEmployees();
        }

    }
}
