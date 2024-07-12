using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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

            comboBoxDept.DisplayMember = "Department_name";

            comboBoxDept.ValueMember = "Department_id";

            comboBoxDept.DataSource = departments;

            comboBoxDept.SelectedIndex = 0;


        }

        private void butInsert_Click(object sender, EventArgs e)
        {
            Job selectedJob = (Job)comboBoxJob.Items[comboBoxJob.SelectedIndex];

            Department selectedDepartment = (Department)comboBoxDept.Items[comboBoxDept.SelectedIndex];

            Employee employee = new Employee(0, textBoxFirstName.Text, textBoxLastName.Text,
                textBoxEmail.Text, textBoxPhone.Text, dateTimePicker.Value, selectedJob.Job_id,
                int.Parse(textBoxSalary.Text), int.Parse(textBoxManager.Text), selectedDepartment.Department_id);
            try
            {
                dalEmployee.insertEmpleado(employee);
                Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }    

    }
}
