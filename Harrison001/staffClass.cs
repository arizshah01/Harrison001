using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harrison001
{
    internal class staffClass
    {
        // Initialize Object to access database;
        DBConnect connect = new DBConnect();

        // Create Record for a Staff 
       

        public bool insertStaff( string name, string email, string phone)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO  `staff` (staffName, staffEmail,staffPhone) VALUES(@staffName, @staffEmail, @staffPhone)", connect.getConnection);

            command.Parameters.Add("@staffName", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@staffEmail", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@staffPhone", MySqlDbType.VarChar).Value = phone;
            connect.openConnection();
            bool result = (command.ExecuteNonQuery() > 0) ? true : false;

            connect.closeConnection();
            return result;



        }

        // Update Student Record
        public bool updateStaff(string staffID, string name, string email, string phone)
        {

            MySqlCommand command = new MySqlCommand("UPDATE `staff` set  staffName=@staffName, staffEmail=@staffEmail, staffPhone=@staffPhone WHERE staffID = @staffID ", connect.getConnection);

            command.Parameters.Add("@staffName", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@staffEmail", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@staffPhone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@staffID", MySqlDbType.VarChar).Value = staffID;

            connect.openConnection();
            bool result = (command.ExecuteNonQuery() > 0) ? true : false;

            connect.closeConnection();
            return result;



        }

        // Delete Student Record after providing StudentID

        public bool deleteStaff(string staffID)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `staff`  WHERE staffID = @staffID ", connect.getConnection);
            command.Parameters.Add("@staffID", MySqlDbType.Int64).Value = staffID;
            connect.openConnection();
            bool result = (command.ExecuteNonQuery() > 0) ? true : false;
            connect.closeConnection();
            return result;

        }



        // Reutrn Data for All Students with Enrolement ID and Class;
        public DataTable getStaffList()
        {
            MySqlCommand command = new MySqlCommand("SELECT * from staff order by staffName;", connect.getConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;

        }
    }
}
