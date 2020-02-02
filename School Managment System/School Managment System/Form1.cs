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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"server=DESKTOP-7HKRBP9\SQLEXPRESS; Database=School Manangment System; integrated security=true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Students(student_name,father_name,gender,date_of_birth,religion,nationality,student_address,student_cell_number)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "'," + textBox4.Text + ",'"+textBox5.Text+"','"+textBox6.Text+"','"+textBox7.Text+"',"+textBox8.Text+")", con);
            cmd.ExecuteNonQuery();
            Parents pr = new Parents();
            pr.Show();
            this.Hide();
        }

        private void Students_Load(object sender, EventArgs e)
        {

        }
    }
}
