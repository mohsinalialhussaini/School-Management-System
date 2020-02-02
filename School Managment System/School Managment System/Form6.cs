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
    public partial class Ssalary : Form
    {
        public Ssalary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"server=DESKTOP-7HKRBP9\SQLEXPRESS; Database=School Manangment System; integrated security=true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Staff_Salaries(staff_id,staff_name,staff_salary)values(" + textBox1.Text + ",'" + textBox2.Text + "'," + textBox3.Text + ")", con);
            cmd.ExecuteNonQuery();
           
            MessageBox.Show("Salary Has Been Issued");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.Show();
            this.Hide();
        }
    }
}
