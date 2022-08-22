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
    public partial class Form2 : Form
    {
        string type;int type_id;int pre;
        public SqlConnection database;
        static string connectionString = @"Server=LAPTOP-RPIEA5DI\SQLEXPRESS;DataBase=Movies;Integrated Security = True";
        SqlDataAdapter adapter;
        SqlCommand command;
        SqlDataReader reader;
        CurrencyManager currencyManager;
        DataTable Dt = new DataTable();
        SqlCommandBuilder cmdb;
        public Form2()
        {
            InitializeComponent();
            database = new SqlConnection(connectionString);
            command = new SqlCommand("Select Type From movietype",database);
            database.Open();
            reader = command.ExecuteReader();
            while(reader.Read())
            {
                typeCB.Items.Add(reader["Type"].ToString());
            }
            reader.Close();
         //  adapter = new SqlDataAdapter();
         //  adapter.Fill(Dt);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form = new Form3();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form = new Form4();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {   
            if(rb1.Checked)pre = 1;
            else pre = 0;
            type_id = typeCB.SelectedIndex;

            command=new SqlCommand("Insert into movie (Title,Year,Previewed,rate,typeid) values('"+titletx.Text+"','"+yeartx.Text+"',"+pre+",'"+ratetx.Text+"',"+type_id+")",database);
            command.ExecuteNonQuery();
            MessageBox.Show("success", "add", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            titletx.Clear();
            yeartx.Clear();
            titletx.Focus();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
