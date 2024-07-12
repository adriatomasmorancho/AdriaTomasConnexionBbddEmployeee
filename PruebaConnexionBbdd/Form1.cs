using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaConnexionBbdd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
     
            InitializeComponent();
            butDesconnectar.Enabled = false;
        }

        private void butConnectar_Click(object sender, EventArgs e)
        {/*
                string connectionString = "Data Source=200.234.224.123,54321;" +
                    "Initial Catalog=AdriaTomasEmployees;" +
                    "User ID =sa;" +
                    "Password=Sql#123456789;";
            try {

                connection = new SqlConnection(connectionString);
                connection.Open();
               // MessageBox.Show(connection.State.ToString());
                butConnectar.Enabled = false;
                butDesconnectar.Enabled = true;
                labelPrincipal.Text = "Conexión Abierta";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void butDesconnectar_Click(object sender, EventArgs e)
        {/*
            try
            {
                connection.Close();
                butDesconnectar.Enabled = false;
                butConnectar.Enabled = true;
                labelPrincipal.Text = "Conexión Cerrada";
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
        }

        private void butInsertar_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();

            

    
        }

        private void butSelect_Click(object sender, EventArgs e)
        {
            
        }
    }
}
