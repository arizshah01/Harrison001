using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harrison001
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
            loadTabs();
          

            // showDataTable();
        }

        private void tabStudents_Click(object sender, EventArgs e)
        {
         
        }

        private void loadTabs()
        {
            showDataTable();
            loadClassesComboBox();
            loadStaffComboBox();
            loadMaterialTypeComboBox();
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            string name = studentName.Text;
            string email = studentEmail.Text;
            string phone = studentPhone.Text;
            string classID = comboBox1.SelectedValue.ToString();
            studentClass student = new studentClass();


            if (!verify())
            {
                MessageBox.Show("Please Enter all fields");

            }
            else if(student.insertStudent(classID, name, email, phone))
            {
                 studentName.Text = "";
                studentEmail.Text = "";
                studentPhone.Text = "";
                showDataTable();
                MessageBox.Show("Student has been added successfully");
            }
          
           
        }
       

        // validate Form Fields
        bool verify()
        {

            if ((studentName.Text == "") || (studentEmail.Text == "") || (studentPhone.Text == ""))
                return false;
            else
            {
                return true;
            }
           

        }

        public void showDataTable()
        {
            studentClass student = new studentClass();
            studentDataGrid.DataSource = student.getStudentList();

            staffClass staff = new staffClass();
            dataGridStaff.DataSource = staff.getStaffList();


            classesClass cls = new classesClass();
            dataGridClasses.DataSource = cls.getClassesList();


            teachingMaterial tm = new teachingMaterial();
            dataGridTeachingMaterial.DataSource = tm.getTeachingMaterialList();





        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void loadClassesComboBox()
        {
            classesClass cls = new classesClass();
            comboBox1.DataSource = cls.getClassesList();
            comboBox1.DisplayMember = "className";
            comboBox1.ValueMember = "classID";
        }
        private void loadStaffComboBox()
        {
            staffClass staff = new staffClass();
            comboBoxStaffID.DataSource = staff.getStaffList();
            comboBoxStaffID.DisplayMember = "staffName";
            comboBoxStaffID.ValueMember = "staffID"; 
           
        }
        private void loadMaterialTypeComboBox()
        {
            teachingMaterial mt = new teachingMaterial();
            comboBoxMaterialType.DataSource = mt.getMaterialType();
            comboBoxMaterialType.DisplayMember = "materialTypeName";
            comboBoxMaterialType.ValueMember = "materialTypeID";

            


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void studentDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>-1)
            {
               
                DataGridViewRow row = this.studentDataGrid.Rows[e.RowIndex];
                studentID.Text = row.Cells["StudentID"].Value.ToString();
                studentName.Text = row.Cells["Name"].Value.ToString();
                studentEmail.Text = row.Cells["Email"].Value.ToString();
                studentPhone.Text = row.Cells["Phone"].Value.ToString();
            }
        }

        private void btnStudentUpdate_Click(object sender, EventArgs e)
        {
            string name = studentName.Text;
            string email = studentEmail.Text;
            string phone = studentPhone.Text;
            string studentId = studentID.Text;
            studentClass student = new studentClass();


            if (!verify())
            {
                MessageBox.Show("Please Enter all fields");

            }
            else if (student.updateStudent(studentId, name, email, phone))
            {
                studentName.Text = "";
                studentEmail.Text = "";
                studentPhone.Text = "";
                studentID.Text = "";
                showDataTable();
                MessageBox.Show("Student has been Updated successfully");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnStudentDelete_Click(object sender, EventArgs e)
        {

          
            string studentId = studentID.Text;
            studentClass student = new studentClass();


            if (!verify())
            {
                MessageBox.Show("Please Select any record");

            }
            else if (student.deleteStudent(studentId))
            {
                studentName.Text = "";
                studentEmail.Text = "";
                studentPhone.Text = "";
                studentID.Text = "";
                showDataTable();
                MessageBox.Show("Student has been deleted");
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                

                DataGridViewRow row = this.dataGridStaff.Rows[e.RowIndex];
                staffID.Text = row.Cells["staffID"].Value.ToString();
                staffName.Text = row.Cells["staffName"].Value.ToString();
                staffEmail.Text = row.Cells["staffEmail"].Value.ToString();
                staffPhone.Text = row.Cells["staffPhone"].Value.ToString();
            }
        }


        bool verifyStaff()
        {

            if ((staffName.Text == "") || (staffEmail.Text == "") || (staffPhone.Text == ""))
                return false;
            else
            {
                return true;
            }


        }
        bool verifyClass()
        {

            if ((className.Text == ""))
                return false;
            else
            {
                return true;
            }


        }

        bool verifyTeachingMaterials()
        {

            if ((textBoxTitle.Text == ""))
                return false;
            else
            {
                return true;
            }


        }

        private void addStaff_Click(object sender, EventArgs e)
        {
            string name = staffName.Text;
            string email = staffEmail.Text;
            string phone = staffPhone.Text;

            staffClass staff = new staffClass();


            if (!verifyStaff())
            {
                MessageBox.Show("Please Enter all fields");

            }
            else if (staff.insertStaff(name, email, phone))
            {
                staffName.Text = "";
                staffEmail.Text = "";
                staffPhone.Text = "";
                showDataTable();
                MessageBox.Show("Staff has been added successfully");
            }
        }

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            string name = staffName.Text;
            string email = staffEmail.Text;
            string phone = staffPhone.Text;
            string sid = staffID.Text;
            staffClass staff = new staffClass();


            if (!verifyStaff())
            {
                MessageBox.Show("Please Enter all fields");

            }
            else if (staff.updateStaff(sid, name, email, phone))
            {
                staffName.Text = "";
                staffEmail.Text = "";
                staffPhone.Text = "";
                staffID.Text = "";
                showDataTable();
                MessageBox.Show("Staff has been Updated successfully");
            }

        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            string staffId = staffID.Text;
            staffClass staff = new staffClass();


            if (!verifyStaff())
            {
                MessageBox.Show("Please Select any record");

            }
            else if (staff.deleteStaff(staffId))
            {
                staffName.Text = "";
                staffEmail.Text = "";
                staffPhone.Text = "";
                staffID.Text = "";
                showDataTable();
                MessageBox.Show("Staff has been deleted");
            }
        }

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridClasses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {


                DataGridViewRow row = this.dataGridClasses.Rows[e.RowIndex];
                classID.Text = row.Cells["classID"].Value.ToString();
                className.Text = row.Cells["className"].Value.ToString();

            }
        }
        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            string classId = classID.Text;
            classesClass  cls = new classesClass();

            
            if (!verifyClass())
            {
                MessageBox.Show("Please Select any record");

            }
            else if (cls.deleteClass(classId))
            {
                className.Text = "";
                classID.Text = "";
                showDataTable();
                MessageBox.Show("Class has been deleted");
            }
        }

        private void btnUpdateClass_Click(object sender, EventArgs e)
        {
            string name = className.Text;
            string ID = classID.Text;
        
            
            classesClass cls = new classesClass();


            if (!verifyClass())
            {
                MessageBox.Show("Please a row from the grid");

            }
            else if (cls.updateClass(ID, name))
            {
                className.Text = "";
                classID.Text = "";
                showDataTable();
                MessageBox.Show("Class has been Updated successfully");
            }
        }

        private void addNewClass(object sender, EventArgs e)
        {
            string name = className.Text;
         
            classesClass cls = new classesClass();


            if (!verifyClass())
            {
                MessageBox.Show("Please Enter Class Name fields");

            }
            else if (cls.insertClass( name))
            {
                className.Text = "";
                classID.Text = "";
               
                showDataTable();
                MessageBox.Show("a New Class has been added successfully");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void dataGridTeachingMaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {

                DataGridViewRow row = this.dataGridTeachingMaterial.Rows[e.RowIndex];
                textboxMaterialID.Text = row.Cells["materialID"].Value.ToString();
                textBoxTitle.Text = row.Cells["title"].Value.ToString();
                comboBoxMaterialType.SelectedValue = row.Cells["materialTypeID"].Value.ToString();
                comboBoxStaffID.SelectedValue = row.Cells["StaffID"].Value.ToString();

                // staffEmail.Text = row.Cells["staffEmail"].Value.ToString();
                // staffPhone.Text = row.Cells["staffPhone"].Value.ToString();
            }
        }

        private void deleteTeachingMaterial(object sender, EventArgs e)
        {
            string materialID = textboxMaterialID.Text;
            teachingMaterial tmObj = new teachingMaterial();


            if (!verifyTeachingMaterials())
            {
                MessageBox.Show("Please Select any record");

            }
            else if (tmObj.deleteTeachingMaterial(materialID))
            {
                textboxMaterialID.Text = "";
                textBoxTitle.Text = "";
               // comboBoxMaterialType.SelectedValue = "";
               // comboBoxStaffID.SelectedValue = "";
                showDataTable();
                MessageBox.Show("Teaching Material has been deleted");
            }
        }

        private void addTeachingMaterial_btn_Click(object sender, EventArgs e)
        {

            string title = textBoxTitle.Text.ToString();
            string materialTypeID = comboBoxMaterialType.SelectedValue.ToString();
            string staffID = comboBoxStaffID.SelectedValue.ToString();

            teachingMaterial tmObj = new teachingMaterial();


            if (!verifyTeachingMaterials())
            {
                MessageBox.Show("Please Enter all fields");

            }
            else if (tmObj.insertTeachingMaterial(title, materialTypeID, staffID))
            {
                textboxMaterialID.Text = "";
                textBoxTitle.Text = "";
                showDataTable();
                MessageBox.Show("Teaching Material has been added successfully");
            }
        }
    }
}
