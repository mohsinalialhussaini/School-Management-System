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
    public partial class Classes : Form
    {
        public Classes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"server=DESKTOP-7HKRBP9\SQLEXPRESS; Database=School Manangment System; integrated security=true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Classes(class_id,course_id,teacher_id)values(" + textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + ")", con);
            cmd.ExecuteNonQuery();
            
            MessageBox.Show("Class Has Been Added");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.Show();
            this.Hide();
        }
    }
}
