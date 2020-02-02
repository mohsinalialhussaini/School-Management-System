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
    public partial class Sform : Form
    {
        public Sform()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"server=DESKTOP-7HKRBP9\SQLEXPRESS; Database=School Manangment System; integrated security=true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Signups(name,email,password,type)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + "User" + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thanks For Signingup You Are Register Now..........");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}
