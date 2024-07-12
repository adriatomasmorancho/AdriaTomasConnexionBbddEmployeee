using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConnexionBbdd
{
    internal class Department
    {
        private int department_id;
        private string department_name;
        private int location_id;

        public Department(int department_id, string department_name, int location_id)
        {
            this.Department_id = department_id;
            this.Department_name = department_name;
            this.Location_id = location_id;
        }

        public int Department_id { get => department_id; set => department_id = value; }
        public string Department_name { get => department_name; set => department_name = value; }
        public int Location_id { get => location_id; set => location_id = value; }
    }
}
