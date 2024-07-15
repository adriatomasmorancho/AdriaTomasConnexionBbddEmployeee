using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaConnexionBbdd
{
    internal class DALEmployee
    {
        private DbConnection connection;

        public DALEmployee()
        {
            connection = new DbConnection(); 
        }

        public void insertEmpleado(Employee employee)
        {
            connection.Open();

            string sql = @"
                INSERT INTO employees (first_name, last_name, email, phone_number, hire_date, job_id, salary, manager_id, department_id) 
                VALUES (@first_name, @last_name, @email, @phone_number, @hire_date, @job_id, @salary, @manager_id, @department_id)";

            SqlCommand cmd = new SqlCommand(sql, connection.GetConnection());

            cmd.Parameters.AddWithValue("@first_name", employee.First_name);
            cmd.Parameters.AddWithValue("@last_name", employee.Last_name);
            cmd.Parameters.AddWithValue("@email", employee.Email);
            cmd.Parameters.AddWithValue("@phone_number", (object)employee.Phone_number ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@hire_date", employee.Hire_date);
            cmd.Parameters.AddWithValue("@job_id", employee.Job_id);
            cmd.Parameters.AddWithValue("@salary", employee.Salary);
            cmd.Parameters.AddWithValue("@manager_id", (object)employee.Manager_id ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@department_id", (object)employee.Department_id ?? DBNull.Value);

            cmd.ExecuteNonQuery();

            connection.Close();
        }


        public List<Employee> SelectAll()
        {
            connection.Open();

            List<Employee> employees = new List<Employee>();

            string query = "SELECT * FROM EMPLOYEES";
            SqlCommand command = new SqlCommand(query, connection.GetConnection());

            SqlDataReader records = command.ExecuteReader();

            while (records.Read())
            {
                int employeeId = records.GetInt32(records.GetOrdinal("employee_id"));
                string firstName = records.GetString(records.GetOrdinal("first_name"));
                string lastName = records.GetString(records.GetOrdinal("last_name"));
                string email = records.GetString(records.GetOrdinal("email")); 
                string phoneNumber = records.IsDBNull(records.GetOrdinal("phone_number")) ? null : records.GetString(records.GetOrdinal("phone_number"));
                DateTime hireDate = records.GetDateTime(records.GetOrdinal("hire_date"));
                int jobId = records.GetInt32(records.GetOrdinal("job_id"));
                decimal salary = records.GetDecimal(records.GetOrdinal("salary"));
                int? managerId = records.IsDBNull(records.GetOrdinal("manager_id"))
                ? (int?)null
                : records.GetInt32(records.GetOrdinal("manager_id"));
                int? departmentId = records.IsDBNull(records.GetOrdinal("department_id"))
                ? (int?)null
                : records.GetInt32(records.GetOrdinal("department_id"));

                Employee employee = new Employee(employeeId, firstName, lastName,
                    email, phoneNumber, hireDate, jobId, salary,managerId, departmentId);
                employees.Add(employee);
            }

            records.Close();
            connection.Close();
            return employees;

        }

    }


}
