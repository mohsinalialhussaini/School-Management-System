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
    public partial class Parents : Form
    {
        public Parents()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"server=DESKTOP-7HKRBP9\SQLEXPRESS; Database=School Manangment System; integrated security=true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into parents(parent_name,gender,contact_number,email,date_of_birth,religion,relationship_with_student,student_id)values('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "'," + textBox5.Text + ",'" + textBox6.Text + "','" + textBox7.Text + "',"+ label9.Text+ " )", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Student Added");
        }

        private void Parents_Load(object sender, EventArgs e)
        {
            DataSet ds = MyDataSet("select Top 1 student_id from Students order by student_id Desc", "Students");
            label9.Text = ds.Tables[0].Rows[0][0].ToString();
            label9.Visible = false;
        }
        public DataSet MyDataSet(string SqlStr, string Table_Name)
        {
            SqlConnection con = new SqlConnection(@"server=DESKTOP-7HKRBP9\SQLEXPRESS; Database=School Manangment System; integrated security=true;");
            con.Open();
            SqlCommand Cmd = new SqlCommand(SqlStr, con);
            DataSet ds = new DataSet();
            SqlDataAdapter Da = new SqlDataAdapter();
            Cmd.CommandTimeout = 0;
            Da.SelectCommand = Cmd;
            Da.Fill(ds, Table_Name);

            return ds;
        }
    }
}
