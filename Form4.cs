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
    public partial class Form4 : Form
    {
        static string connectionString = @"Server=LAPTOP-RPIEA5DI\SQLEXPRESS;DataBase=Movies;Integrated Security = True";
        public SqlConnection database;
        SqlDataAdapter adapter;
        DataTable Dt = new DataTable();
        DataSet ds = new DataSet();
        public Form4()
        {
            
                InitializeComponent();
            database =new SqlConnection(connectionString);
            database.Open();
                

            
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

            


        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                Image myimage = new Bitmap(@"C:\Users\20122\Desktop\pic\261416-terminator-sci-fi-action-movie-film-161569064");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = myimage;
                myimage = new Bitmap(@"C:\Users\20122\Desktop\pic\sci-fic");
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.Image = myimage;
                myimage = new Bitmap(@"C:\Users\20122\Desktop\pic\fantasy");
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox3.Image = myimage;
                myimage = new Bitmap(@"C:\Users\20122\Desktop\pic\comedy");
                pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox4.Image = myimage; 
                myimage = new Bitmap(@"C:\Users\20122\Desktop\pic\scar");
                pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox5.Image = myimage; 
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void MyForm_Key_close(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Q)
            {
                this.Close();
            }
        }
        private void MyForm_Keyback(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Z)
            {
                Application.OpenForms[0].Show();
                this.Close();
            }
        }
         private void tabPage2_Click(object sender, EventArgs e)
         {
            try
             {
                 dataGridView1.DataSource = null;
                 adapter = new SqlDataAdapter("Select * From Movie WHERE typeid = 0 ", database);
                
                 adapter.Fill(ds,"movietype");
                 dataGridView2.DataSource = ds.Tables["movietype"];
             }
             catch (Exception ex) { MessageBox.Show(ex.Message); }
            
         }
        
         
            
         
         
        private void button1_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                
                adapter = new SqlDataAdapter("Select * From movie WHERE typeid = 3 ", database);
                adapter.Fill(Dt);
                dataGridView2.DataSource = Dt;
                

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                
                adapter = new SqlDataAdapter("Select * From movie WHERE typeid = 2 ", database);
                adapter.Fill(Dt);
                dataGridView2.DataSource = Dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                
                adapter = new SqlDataAdapter("Select * From movie WHERE typeid = 5 ", database);
                adapter.Fill(Dt);
                dataGridView2.DataSource = Dt;
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
               
                adapter = new SqlDataAdapter("Select * From movie WHERE typeid = 1 ", database);
                adapter.Fill(Dt);
                dataGridView2.DataSource = Dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
               
                adapter = new SqlDataAdapter("Select * From movie WHERE typeid = 0 ", database);
                adapter.Fill(Dt);
                dataGridView2.DataSource = Dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }
    }
}
