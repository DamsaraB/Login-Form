using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace Hasitha
{
    internal class Class1
    {
        //connecation string
        const string cs = @"server=localhost;userid=root;password=;database=db_company";


        //establish the connection
        public static MySqlConnection con = new MySqlConnection(cs);


        //to open the connection 
        public static void open_connection()
        {
            if (con.State == ConnectionState.Closed) ;
            {
                con.Open();
            }
        }

        public static void close_connection()
        {
            if (con.State == ConnectionState.Open) ;
            {
                con.Close();
            }
        }
    }
}
