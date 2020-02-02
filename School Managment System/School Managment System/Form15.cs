using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Managment_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sform sign = new Sform();
            sign.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection con = new connection();
            DataTable dt = con.display("select * from Signups where name='" + textBox1.Text + "' and password='" + textBox2.Text + "'");

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["type"].ToString() == "Admin")
                {
                    Admin a = new Admin();
                    a.Show();

                    // a.Hide();
                }

                /*  else if (dt.Rows[0]["Type"].ToString() == "User")
                  {
                      User_Form ufr = new User_Form();
                      ufr.Show();
                      this.Hide();
                  }
                  */
            }
            else
            {
                MessageBox.Show("Sorry You Are Not Register You Have To Signup First......");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
