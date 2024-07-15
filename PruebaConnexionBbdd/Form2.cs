using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PruebaConnexionBbdd
{
    public partial class Form2 : Form
    {
        private DALEmployee dalEmployee;
        private DALJob dalJob;
        private DALDepartment dalDepartment;
        public Form2()
        {
            InitializeComponent();
            dalEmployee = new DALEmployee();
            dalJob = new DALJob();
            dalDepartment = new DALDepartment();


            List<Job> jobs = dalJob.SelectAll();

            comboBoxJob.DisplayMember = "Job_title";

            comboBoxJob.ValueMember = "Job_id";

            comboBoxJob.DataSource = jobs;

            comboBoxJob.SelectedIndex = 0;

            List<Department> departments = dalDepartment.SelectAll();

            Department emptyDepartment = new Department(-1, string.Empty, 1);

            departments.Insert(0, emptyDepartment);

            comboBoxDept.DisplayMember = "Department_name";

            comboBoxDept.ValueMember = "Department_id";

            comboBoxDept.DataSource = departments;

            comboBoxDept.SelectedIndex = 0;

            List<Employee> employees = dalEmployee.SelectAll();

            Employee emptyEmployees = new Employee(-1, string.Empty, string.Empty, string.Empty, string.Empty, dateTimePicker.Value, 1,
               1, 1, 1);

            employees.Insert(0, emptyEmployees);

            comboBoxManager.DisplayMember = "First_name";

            comboBoxManager.ValueMember = "Employee_id";

            comboBoxManager.DataSource = employees;

            comboBoxManager.SelectedIndex = 0;


        }

        private void butInsert_Click(object sender, EventArgs e)
        {
            Job selectedJob = (Job)comboBoxJob.Items[comboBoxJob.SelectedIndex];

            Department selectedDepartment = (Department)comboBoxDept.Items[comboBoxDept.SelectedIndex];

            Employee em = (Employee)comboBoxManager.Items[comboBoxManager.SelectedIndex];

            int? departmentId = null;

            if (selectedDepartment.Department_id != -1)
            {
                departmentId = selectedDepartment.Department_id;
            }

            int? employeeId = null;

            if (em.Employee_id != -1)
            {
                employeeId = em.Employee_id;
            }

            Employee employee = new Employee(0, textBoxFirstName.Text, textBoxLastName.Text,
                textBoxEmail.Text, ConvertEmptyToNull(textBoxPhone.Text), dateTimePicker.Value, selectedJob.Job_id,
                int.Parse(textBoxSalary.Text), employeeId, departmentId);
            try
            {
                dalEmployee.insertEmpleado(employee);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public string ConvertEmptyToNull(string input)
        {
            return string.IsNullOrEmpty(input) ? null : input;
        }

    }
}
