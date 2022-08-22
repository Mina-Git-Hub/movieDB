using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient; // <- for database methods

namespace WindowsFormsApp7
{

    public partial class Form1 : Form
    {
        string type; int type_id; int pre;
        SqlConnection database;
        static string connectionString = @"Server=LAPTOP-RPIEA5DI\SQLEXPRESS;DataBase=Movies;Integrated Security = True";
        SqlDataAdapter adapter;
        SqlCommand command;
        SqlDataReader reader;
        CurrencyManager currencyManager;
        DataTable Dt = new DataTable();
        SqlCommandBuilder cmdb;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

            database = new SqlConnection(connectionString);
            command = new SqlCommand("Select * From Movie ORDER BY rate DESC ", database);
            database.Open();
            reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read()&&i<10)
            {
                listBox1.Items.Add(reader["Title"] + " : " + reader["rate"].ToString());
                i++;
            }
            reader.Close();
        
        }
    }

    
}
