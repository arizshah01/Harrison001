using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace Harrison001
{
    
    internal class studentClass
    {
        // Initialize Object to access database;
        DBConnect connect = new DBConnect();


        // Create Record for a student and add record for Enrolement with Class ID
        // Calling Stored Procedure
        
        public bool insertStudent(string classID, string name, string email, string phone)
        {
            MySqlCommand command = new MySqlCommand("CALL `studentEnrolement`(@classID, @studentName, @studentEmail, @studentPhone)", connect.getConnection);

            command.Parameters.Add("@classID", MySqlDbType.VarChar).Value = classID;
            command.Parameters.Add("@studentName", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@studentEmail", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@studentPhone", MySqlDbType.VarChar).Value = phone;
            connect.openConnection();
            bool result = (command.ExecuteNonQuery()>0)?true:false;

                connect.closeConnection();
                return result;
         


        }

        // Update Student Record
        public bool updateStudent(string studentID, string name, string email, string phone)
        {
         
            MySqlCommand command = new MySqlCommand("UPDATE `students` set  studentName=@studentName, studentEmail=@studentEmail, studentPhone=@studentPhone WHERE studentID = @studentID ", connect.getConnection);

            command.Parameters.Add("@studentName", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@studentEmail", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@studentPhone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@studentID", MySqlDbType.VarChar).Value = studentID;

            connect.openConnection();
            bool result = (command.ExecuteNonQuery() > 0) ? true : false;

            connect.closeConnection();
            return result;



        }

        // Delete Student Record after providing StudentID

        public bool deleteStudent(string studentID)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `students`  WHERE studentID = @studentID ", connect.getConnection);
            command.Parameters.Add("@studentID", MySqlDbType.Int64).Value = studentID;
            connect.openConnection();
            bool result = (command.ExecuteNonQuery() > 0) ? true : false;
            connect.closeConnection();
            return result;

        }



        // Reutrn Data for All Students with Enrolement ID and Class;
        public DataTable getStudentList()
        {
            MySqlCommand command = new MySqlCommand("SELECT enrolementID as `Enrol. No.`, className as Class, students.studentID as StudentID, studentName as Name, enrolementDate as `Enrol. Date`, studentEmail as Email, studentPhone as Phone FROM enrolement INNER JOIN `classes` ON `classes`.classID = `enrolement`.classID INNER JOIN `students` ON `students`.studentID = `enrolement`.studentID;", connect.getConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;

        }


    }
}
