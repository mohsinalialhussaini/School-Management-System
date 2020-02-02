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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"server=DESKTOP-7HKRBP9\SQLEXPRESS; Database=School Manangment System; integrated security=true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Staffs(staff_name,gender,contact_number,email,date_of_birth,religion,designation,salary)values('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "'," + textBox8.Text + ")", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff Added Successfully");
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.Show();
            this.Hide();
        }
    }
}
