using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConnexionBbdd
{
    internal class DALJob
    {
        private DbConnection connection;

        public DALJob()
        {
            this.connection = new DbConnection();
        }

        public List<Job> SelectAll()
        {
            connection.Open();

            List<Job> jobs = new List<Job>();
            
            string query = "SELECT * FROM JOBS";
            SqlCommand command = new SqlCommand(query, connection.GetConnection());
            
            SqlDataReader records = command.ExecuteReader();

            while (records.Read())
            {
                int jobId = records.GetInt32(records.GetOrdinal("job_id"));
                string jobName = records.GetString(records.GetOrdinal("job_title"));
                decimal? minSalary = records.IsDBNull(records.GetOrdinal("min_salary"))
                ? (decimal?)null
                : records.GetDecimal(records.GetOrdinal("min_salary"));
                decimal? maxSalary = records.IsDBNull(records.GetOrdinal("max_salary"))
                ? (decimal?)null
                : records.GetDecimal(records.GetOrdinal("max_salary"));


                Job job = new Job(jobId, jobName, minSalary, maxSalary);
                jobs.Add(job);
            }
              
            records.Close();
            connection.Close();
            return jobs;

        }

    }
}
