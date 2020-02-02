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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Students s = new Students();
            s.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teachers t = new Teachers();
            t.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Staff s1 = new Staff();
            s1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Books b = new Books();
            b.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Classes c = new Classes();
            c.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Courses c1 = new Courses();
            c1.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Exams e1 = new Exams();
            e1.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Tsalary t = new Tsalary();
            t.Show();
            this.Hide(); 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Ssalary ss = new Ssalary();
            ss.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Expense ep = new Expense();
            ep.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Liabrary lb = new Liabrary();
            lb.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Student_Info si = new Student_Info();
            si.Show();
            this.Hide();
        }
    }
}
