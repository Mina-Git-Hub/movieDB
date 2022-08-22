using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // <- for database methods

namespace WindowsFormsApp7
{
    public partial class Form3 : Form
    {
        static string connectionString = @"Server=LAPTOP-RPIEA5DI\SQLEXPRESS;DataBase=Movies;Integrated Security = True";
        SqlConnection database = new SqlConnection(connectionString);
        SqlDataAdapter adapter;
        SqlDataReader reader;
        DataTable Dt = new DataTable() ;
        DataSet ds = new DataSet();
        public Form3()
        {
            InitializeComponent();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Application.OpenForms[0].Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                database.Open();
                SqlCommand command = new SqlCommand("Select Title,Year,Previewed From Movie WHERE Year ='"+yeartx.Text+"'", database);
                reader= command.ExecuteReader();
                while (reader.Read())
                {
                    listBox1.Items.Add(reader["Title"]+" : " + reader["Year"]);
                }
             }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }
    }
}
