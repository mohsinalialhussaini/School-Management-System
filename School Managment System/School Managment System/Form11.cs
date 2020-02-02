using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace School_Managment_System
{
    public partial class Liabrary : Form
    {
        public Liabrary()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"server=DESKTOP-7HKRBP9\SQLEXPRESS; Database=School Manangment System; integrated security=true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Liabrary_Books_Issue(book_id,student_id,returning_date)values(" + comboBox1.SelectedValue.ToString() + "," + comboBox2.SelectedValue.ToString() + "," + textBox4.Text + ")", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Book Has Been Issued");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.Show();  
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         }

        private void Liabrary_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"server=DESKTOP-7HKRBP9\SQLEXPRESS; Database=School Manangment System; integrated security=true;");
            con.Open();
            DataTable dt = new DataTable("Liabrary_Books_Issue");
            SqlDataAdapter Datadapter = new SqlDataAdapter("select book_id,book_name from Books", con);
            dt.Columns.Add("book_id", typeof(string));
            dt.Columns.Add("book_name", typeof(string));
            Datadapter.Fill(dt);
            comboBox1.ValueMember = "book_id";
            comboBox1.DisplayMember = "book_name";
            comboBox1.DataSource = dt;

            // 
            DataTable dt1 = new DataTable("Liabrary_Books_Issue");
            SqlDataAdapter Datadapter1 = new SqlDataAdapter("select student_id,student_name from Students", con);
            dt1.Columns.Add("student_id", typeof(string));
            dt1.Columns.Add("student_name", typeof(string));
            Datadapter1.Fill(dt1);
            comboBox2.ValueMember = "student_id";
            comboBox2.DisplayMember = "student_name";
            comboBox2.DataSource = dt1;

            // 
            //DataTable dt2 = new DataTable("Liabrary_Books_Issue");
            //SqlDataAdapter Datadapter2 = new SqlDataAdapter("select student_id,student_name from Students", con);
            //dt2.Columns.Add("student_id", typeof(string));
            //dt2.Columns.Add("student_name", typeof(string));
            //Datadapter2.Fill(dt2);
            //comboBox3.ValueMember = "student_id";
            //comboBox3.DisplayMember = "student_name";
            //comboBox3.DataSource = dt2;
            //con.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
