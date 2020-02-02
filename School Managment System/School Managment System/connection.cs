using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace School_Managment_System
{
    class connection
    {
        static SqlConnection connect = new SqlConnection("server=DESKTOP-7HKRBP9\\SQLEXPRESS; Database=School Manangment System; Integrated Security=true;");

        public static SqlConnection Connect
        {
            get
            {
                return connect;
            }
        }
        public DataTable display(string query)
        {
            SqlDataAdapter adp = new SqlDataAdapter(query, connect);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
    }
}
