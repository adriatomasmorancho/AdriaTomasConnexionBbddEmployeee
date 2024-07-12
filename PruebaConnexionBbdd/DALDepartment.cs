using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConnexionBbdd
{
    internal class DALDepartment
    {
        private DbConnection connection;

        public DALDepartment()
        {
            this.connection = new DbConnection();
        }

        public List<Department> SelectAll()
        {
            connection.Open();

            List<Department> departments = new List<Department>();

            string query = "SELECT * FROM DEPARTMENTS";
            SqlCommand command = new SqlCommand(query, connection.GetConnection());

            SqlDataReader records = command.ExecuteReader();

            while (records.Read())
            {
                int departmentId = records.GetInt32(records.GetOrdinal("department_id"));
                string departmentName = records.GetString(records.GetOrdinal("department_name"));
                int locationId = records.GetInt32(records.GetOrdinal("location_id"));

                Department department = new Department(departmentId, departmentName, locationId);
                departments.Add(department);
            }

            records.Close();
            connection.Close();
            return departments;

        }
    }
}
