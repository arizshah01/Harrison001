using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harrison001
{
    internal class teachingMaterial
    {
        DBConnect connect = new DBConnect();


        public bool insertTeachingMaterial(string title, string materialTypeID, string staffID)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO  `teachingmaterials` (title, materialTypeID,staffID) VALUES(@title, @materialTypeID, @staffID)", connect.getConnection);

            command.Parameters.Add("@title", MySqlDbType.VarChar).Value = title;
            command.Parameters.Add("@materialTypeID", MySqlDbType.VarChar).Value = materialTypeID;
            command.Parameters.Add("@staffID", MySqlDbType.VarChar).Value = staffID;
            connect.openConnection();
            bool result = (command.ExecuteNonQuery() > 0) ? true : false;

            connect.closeConnection();
            return result;



        }

        // Update Teaching Material Record
        public bool updateTeachingMaterial(string materialID, string title, string materialTypeID, string staffID)
        {

            MySqlCommand command = new MySqlCommand("UPDATE `teachingmaterials` set  title=@title, materialTypeID=@materialTypeID, staffID=@staffID WHERE materialID = @materialID ", connect.getConnection);

            command.Parameters.Add("@title", MySqlDbType.VarChar).Value = title;
            command.Parameters.Add("@materialTypeID", MySqlDbType.VarChar).Value = materialTypeID;
            command.Parameters.Add("@staffID", MySqlDbType.VarChar).Value = staffID;
            command.Parameters.Add("@materialID", MySqlDbType.VarChar).Value = materialID;

            connect.openConnection();
            bool result = (command.ExecuteNonQuery() > 0) ? true : false;

            connect.closeConnection();
            return result;



        }

        // Delete Teaching Material Record after providing StudentID

        public bool deleteTeachingMaterial(string materialID)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `teachingmaterials`  WHERE materialID = @materialID ", connect.getConnection);
            command.Parameters.Add("@materialID", MySqlDbType.Int64).Value = materialID;
            connect.openConnection();
            bool result = (command.ExecuteNonQuery() > 0) ? true : false;
            connect.closeConnection();
            return result;

        }



        // Reutrn Data for All Teaching Material with Join Tables;
        public DataTable getTeachingMaterialList()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `teachingmaterials`\r\nINNER JOIN `staff` ON `staff`.`staffID`=`teachingmaterials`.`staffID`\r\nINNER JOIN `materialtype` ON `materialtype`.`materialTypeID`=`teachingmaterials`.`materialTypeID`;", connect.getConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;

        }

        public DataTable getMaterialType()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `materialtype` ORDER BY `materialTypeName` ASC ;", connect.getConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;


        }
    }
}
