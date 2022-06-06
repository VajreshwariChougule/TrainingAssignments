using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace CaseStudy
{
    class SQLConnection
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static SqlConnection getcon()
        {
            con = new SqlConnection("data source = POOLW42SLPC6858\\SQLEXPRESS; Initial catalog = CaseStudyDB; " + "user id= sa; password = Temp1234");
            con.Open();
            return con;
        }
    }
}