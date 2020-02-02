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
    public partial class Student_Info : Form
    {
        public Student_Info()
        {
            InitializeComponent();
        }

        private void Student_Info_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"server=DESKTOP-7HKRBP9\SQLEXPRESS; Database=School Manangment System; integrated security=true;");
            con.Open();
           // SqlCommand cmd = new SqlCommand(" ");
            SqlDataAdapter adp = new SqlDataAdapter("select Parents.student_id,student_name,parent_name,relationship_with_student from Parents join Students on Parents.student_id=Students.student_id", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            //cmd.ExecuteNonQuery();
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"server=DESKTOP-7HKRBP9\SQLEXPRESS; Database=School Manangment System; integrated security=true;");
            con.Open();
            // SqlCommand cmd = new SqlCommand(" ");
            SqlDataAdapter adp = new SqlDataAdapter("select * from Students where student_id='"+ textBox1.Text + "'", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            //cmd.ExecuteNonQuery();
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
