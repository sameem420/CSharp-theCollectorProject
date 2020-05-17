using Microsoft.Build.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theCollector
{
    public class ConnectionManager
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=ROOT-PC\SQLEXPRESS;Initial Catalog=moviedb;Integrated Security=True;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }
        public static bool isServerConnected()
        {
            string connectionString = @"Data Source=ROOT-PC\SQLEXPRESS;Initial Catalog=moviedb;Integrated Security=True;";
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false; // any error is considered as db connection error for now
            }
        }
    }
}
