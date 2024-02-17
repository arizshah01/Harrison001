using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Harrison001
{
    partial class DBConnect
    {

   
        MySqlConnection connect = new MySqlConnection("datasource=harrissons-ltd-db1.criy66wskci8.us-east-1.rds.amazonaws.com;port=3306;username=Harris2024;password=Sons2024;database=Harris_and_Sons");

        public MySqlConnection getConnection
        {
            get
            {
                return connect;
            }
        }
        public void openConnection()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
                connect.Open();
        }
        public void closeConnection()
        {
            if (connect.State == System.Data.ConnectionState.Open)
                connect.Close();
        }


    }
}
