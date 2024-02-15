using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Harrison001
{
    internal class classesClass
    {
        DBConnect connect = new DBConnect();

        // Get List for All Classes
       public DataTable getClassesList()
        {
            MySqlCommand command = new MySqlCommand("SELECT * from classes order by className", connect.getConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;

        }
        // Create Record for a Class 


        public bool insertClass(string name)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO  `classes` (className) VALUES(@name)", connect.getConnection);

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
         
            connect.openConnection();
            bool result = (command.ExecuteNonQuery() > 0) ? true : false;

            connect.closeConnection();
            return result;



        }

        // Update Class Record
        public bool updateClass(string classID, string name)
        {

            MySqlCommand command = new MySqlCommand("UPDATE `classes` set  className=@className WHERE classID = @classID ", connect.getConnection);
            command.Parameters.Add("@className", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@classID", MySqlDbType.VarChar).Value = classID;
            connect.openConnection();
            bool result = (command.ExecuteNonQuery() > 0) ? true : false;
            connect.closeConnection();
            return result;



        }

        // Delete Class Record
        public bool deleteClass(string classID)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `classes`  WHERE classID = @classID ", connect.getConnection);
            command.Parameters.Add("@classID", MySqlDbType.Int64).Value = classID;
            connect.openConnection();
            bool result = (command.ExecuteNonQuery() > 0) ? true : false;
            connect.closeConnection();
            return result;

        }

    }
}
