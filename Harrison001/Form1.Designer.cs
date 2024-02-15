namespace Harrison001
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabStudents = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.studentID = new System.Windows.Forms.TextBox();
            this.btnStudentDelete = new System.Windows.Forms.Button();
            this.btnStudentUpdate = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.studentDataGrid = new System.Windows.Forms.DataGridView();
            this.btnStudentAdd = new System.Windows.Forms.Button();
            this.studentPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.studentEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabStaff = new System.Windows.Forms.TabPage();
            this.dataGridStaff = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.staffID = new System.Windows.Forms.TextBox();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.btnUpdateStaff = new System.Windows.Forms.Button();
            this.addStaff = new System.Windows.Forms.Button();
            this.staffPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.staffEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.staffName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabClasses = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.classID = new System.Windows.Forms.TextBox();
            this.btnDeleteClass = new System.Windows.Forms.Button();
            this.btnUpdateClass = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.className = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridClasses = new System.Windows.Forms.DataGridView();
            this.tabMaterials = new System.Windows.Forms.TabPage();
            this.tabEnrolements = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGrid)).BeginInit();
            this.tabStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStaff)).BeginInit();
            this.tabClasses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabStudents);
            this.tabControl1.Controls.Add(this.tabStaff);
            this.tabControl1.Controls.Add(this.tabClasses);
            this.tabControl1.Controls.Add(this.tabMaterials);
            this.tabControl1.Controls.Add(this.tabEnrolements);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(883, 614);
            this.tabControl1.TabIndex = 0;
            // 
            // tabStudents
            // 
            this.tabStudents.Controls.Add(this.label6);
            this.tabStudents.Controls.Add(this.label5);
            this.tabStudents.Controls.Add(this.studentID);
            this.tabStudents.Controls.Add(this.btnStudentDelete);
            this.tabStudents.Controls.Add(this.btnStudentUpdate);
            this.tabStudents.Controls.Add(this.comboBox1);
            this.tabStudents.Controls.Add(this.label4);
            this.tabStudents.Controls.Add(this.studentDataGrid);
            this.tabStudents.Controls.Add(this.btnStudentAdd);
            this.tabStudents.Controls.Add(this.studentPhone);
            this.tabStudents.Controls.Add(this.label3);
            this.tabStudents.Controls.Add(this.studentEmail);
            this.tabStudents.Controls.Add(this.label2);
            this.tabStudents.Controls.Add(this.studentName);
            this.tabStudents.Controls.Add(this.label1);
            this.tabStudents.Location = new System.Drawing.Point(4, 22);
            this.tabStudents.Name = "tabStudents";
            this.tabStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudents.Size = new System.Drawing.Size(875, 588);
            this.tabStudents.TabIndex = 0;
            this.tabStudents.Text = "Students";
            this.tabStudents.UseVisualStyleBackColor = true;
            this.tabStudents.Click += new System.EventHandler(this.tabStudents_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Students";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Student ID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // studentID
            // 
            this.studentID.Location = new System.Drawing.Point(327, 48);
            this.studentID.Name = "studentID";
            this.studentID.Size = new System.Drawing.Size(299, 20);
            this.studentID.TabIndex = 12;
            // 
            // btnStudentDelete
            // 
            this.btnStudentDelete.Location = new System.Drawing.Point(551, 152);
            this.btnStudentDelete.Name = "btnStudentDelete";
            this.btnStudentDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnStudentDelete.Size = new System.Drawing.Size(75, 23);
            this.btnStudentDelete.TabIndex = 11;
            this.btnStudentDelete.Text = "Delete";
            this.btnStudentDelete.UseVisualStyleBackColor = true;
            this.btnStudentDelete.Click += new System.EventHandler(this.btnStudentDelete_Click);
            // 
            // btnStudentUpdate
            // 
            this.btnStudentUpdate.Location = new System.Drawing.Point(470, 152);
            this.btnStudentUpdate.Name = "btnStudentUpdate";
            this.btnStudentUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnStudentUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnStudentUpdate.TabIndex = 10;
            this.btnStudentUpdate.Text = "Update";
            this.btnStudentUpdate.UseVisualStyleBackColor = true;
            this.btnStudentUpdate.Click += new System.EventHandler(this.btnStudentUpdate_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(327, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(299, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Class";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // studentDataGrid
            // 
            this.studentDataGrid.AllowUserToAddRows = false;
            this.studentDataGrid.AllowUserToDeleteRows = false;
            this.studentDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.studentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGrid.Location = new System.Drawing.Point(3, 206);
            this.studentDataGrid.MultiSelect = false;
            this.studentDataGrid.Name = "studentDataGrid";
            this.studentDataGrid.Size = new System.Drawing.Size(869, 382);
            this.studentDataGrid.TabIndex = 7;
            this.studentDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentDataGrid_CellContentClick);
            // 
            // btnStudentAdd
            // 
            this.btnStudentAdd.Location = new System.Drawing.Point(389, 152);
            this.btnStudentAdd.Name = "btnStudentAdd";
            this.btnStudentAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnStudentAdd.Size = new System.Drawing.Size(75, 23);
            this.btnStudentAdd.TabIndex = 6;
            this.btnStudentAdd.Text = "Add Record";
            this.btnStudentAdd.UseVisualStyleBackColor = true;
            this.btnStudentAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // studentPhone
            // 
            this.studentPhone.Location = new System.Drawing.Point(327, 126);
            this.studentPhone.Name = "studentPhone";
            this.studentPhone.Size = new System.Drawing.Size(299, 20);
            this.studentPhone.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Student Phone";
            // 
            // studentEmail
            // 
            this.studentEmail.Location = new System.Drawing.Point(327, 100);
            this.studentEmail.Name = "studentEmail";
            this.studentEmail.Size = new System.Drawing.Size(299, 20);
            this.studentEmail.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Email";
            // 
            // studentName
            // 
            this.studentName.Location = new System.Drawing.Point(327, 74);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(299, 20);
            this.studentName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name";
            // 
            // tabStaff
            // 
            this.tabStaff.Controls.Add(this.dataGridStaff);
            this.tabStaff.Controls.Add(this.label11);
            this.tabStaff.Controls.Add(this.label7);
            this.tabStaff.Controls.Add(this.staffID);
            this.tabStaff.Controls.Add(this.btnDeleteStaff);
            this.tabStaff.Controls.Add(this.btnUpdateStaff);
            this.tabStaff.Controls.Add(this.addStaff);
            this.tabStaff.Controls.Add(this.staffPhone);
            this.tabStaff.Controls.Add(this.label8);
            this.tabStaff.Controls.Add(this.staffEmail);
            this.tabStaff.Controls.Add(this.label9);
            this.tabStaff.Controls.Add(this.staffName);
            this.tabStaff.Controls.Add(this.label10);
            this.tabStaff.Location = new System.Drawing.Point(4, 22);
            this.tabStaff.Name = "tabStaff";
            this.tabStaff.Padding = new System.Windows.Forms.Padding(3);
            this.tabStaff.Size = new System.Drawing.Size(875, 588);
            this.tabStaff.TabIndex = 1;
            this.tabStaff.Text = "Staff";
            this.tabStaff.UseVisualStyleBackColor = true;
            // 
            // dataGridStaff
            // 
            this.dataGridStaff.AllowUserToAddRows = false;
            this.dataGridStaff.AllowUserToDeleteRows = false;
            this.dataGridStaff.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStaff.Location = new System.Drawing.Point(21, 187);
            this.dataGridStaff.MultiSelect = false;
            this.dataGridStaff.Name = "dataGridStaff";
            this.dataGridStaff.Size = new System.Drawing.Size(848, 395);
            this.dataGridStaff.TabIndex = 26;
            this.dataGridStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 29);
            this.label11.TabIndex = 25;
            this.label11.Text = "Staff Records";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(256, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Staff ID";
            // 
            // staffID
            // 
            this.staffID.Location = new System.Drawing.Point(365, 20);
            this.staffID.Name = "staffID";
            this.staffID.Size = new System.Drawing.Size(299, 20);
            this.staffID.TabIndex = 23;
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.Location = new System.Drawing.Point(589, 124);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDeleteStaff.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteStaff.TabIndex = 22;
            this.btnDeleteStaff.Text = "Delete";
            this.btnDeleteStaff.UseVisualStyleBackColor = true;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.Location = new System.Drawing.Point(508, 124);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUpdateStaff.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateStaff.TabIndex = 21;
            this.btnUpdateStaff.Text = "Update";
            this.btnUpdateStaff.UseVisualStyleBackColor = true;
            this.btnUpdateStaff.Click += new System.EventHandler(this.btnUpdateStaff_Click);
            // 
            // addStaff
            // 
            this.addStaff.Location = new System.Drawing.Point(427, 124);
            this.addStaff.Name = "addStaff";
            this.addStaff.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addStaff.Size = new System.Drawing.Size(75, 23);
            this.addStaff.TabIndex = 20;
            this.addStaff.Text = "Add Record";
            this.addStaff.UseVisualStyleBackColor = true;
            this.addStaff.Click += new System.EventHandler(this.addStaff_Click);
            // 
            // staffPhone
            // 
            this.staffPhone.Location = new System.Drawing.Point(365, 98);
            this.staffPhone.Name = "staffPhone";
            this.staffPhone.Size = new System.Drawing.Size(299, 20);
            this.staffPhone.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Staff Phone";
            // 
            // staffEmail
            // 
            this.staffEmail.Location = new System.Drawing.Point(365, 72);
            this.staffEmail.Name = "staffEmail";
            this.staffEmail.Size = new System.Drawing.Size(299, 20);
            this.staffEmail.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Staff Email";
            // 
            // staffName
            // 
            this.staffName.Location = new System.Drawing.Point(365, 46);
            this.staffName.Name = "staffName";
            this.staffName.Size = new System.Drawing.Size(299, 20);
            this.staffName.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(255, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Staff Name";
            // 
            // tabClasses
            // 
            this.tabClasses.Controls.Add(this.label12);
            this.tabClasses.Controls.Add(this.label13);
            this.tabClasses.Controls.Add(this.classID);
            this.tabClasses.Controls.Add(this.btnDeleteClass);
            this.tabClasses.Controls.Add(this.btnUpdateClass);
            this.tabClasses.Controls.Add(this.btnAddClass);
            this.tabClasses.Controls.Add(this.className);
            this.tabClasses.Controls.Add(this.label16);
            this.tabClasses.Controls.Add(this.dataGridClasses);
            this.tabClasses.Location = new System.Drawing.Point(4, 22);
            this.tabClasses.Name = "tabClasses";
            this.tabClasses.Size = new System.Drawing.Size(875, 588);
            this.tabClasses.TabIndex = 2;
            this.tabClasses.Text = "Classes";
            this.tabClasses.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(211, 29);
            this.label12.TabIndex = 39;
            this.label12.Text = "Classes Records";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(253, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "Class ID";
            // 
            // classID
            // 
            this.classID.Location = new System.Drawing.Point(362, 21);
            this.classID.Name = "classID";
            this.classID.Size = new System.Drawing.Size(299, 20);
            this.classID.TabIndex = 37;
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.Location = new System.Drawing.Point(586, 87);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDeleteClass.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteClass.TabIndex = 36;
            this.btnDeleteClass.Text = "Delete";
            this.btnDeleteClass.UseVisualStyleBackColor = true;
            this.btnDeleteClass.Click += new System.EventHandler(this.btnDeleteClass_Click);
            // 
            // btnUpdateClass
            // 
            this.btnUpdateClass.Location = new System.Drawing.Point(505, 87);
            this.btnUpdateClass.Name = "btnUpdateClass";
            this.btnUpdateClass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUpdateClass.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateClass.TabIndex = 35;
            this.btnUpdateClass.Text = "Update";
            this.btnUpdateClass.UseVisualStyleBackColor = true;
            this.btnUpdateClass.Click += new System.EventHandler(this.btnUpdateClass_Click);
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(424, 87);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddClass.Size = new System.Drawing.Size(75, 23);
            this.btnAddClass.TabIndex = 34;
            this.btnAddClass.Text = "Add Record";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.addNewClass);
            // 
            // className
            // 
            this.className.Location = new System.Drawing.Point(362, 47);
            this.className.Name = "className";
            this.className.Size = new System.Drawing.Size(299, 20);
            this.className.TabIndex = 29;
            this.className.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(252, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Class Name";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // dataGridClasses
            // 
            this.dataGridClasses.AllowUserToAddRows = false;
            this.dataGridClasses.AllowUserToDeleteRows = false;
            this.dataGridClasses.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClasses.Location = new System.Drawing.Point(3, 181);
            this.dataGridClasses.MultiSelect = false;
            this.dataGridClasses.Name = "dataGridClasses";
            this.dataGridClasses.Size = new System.Drawing.Size(848, 395);
            this.dataGridClasses.TabIndex = 27;
            this.dataGridClasses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClasses_CellContentClick);
            // 
            // tabMaterials
            // 
            this.tabMaterials.Location = new System.Drawing.Point(4, 22);
            this.tabMaterials.Name = "tabMaterials";
            this.tabMaterials.Size = new System.Drawing.Size(875, 588);
            this.tabMaterials.TabIndex = 3;
            this.tabMaterials.Text = "Materials";
            this.tabMaterials.UseVisualStyleBackColor = true;
            // 
            // tabEnrolements
            // 
            this.tabEnrolements.Location = new System.Drawing.Point(4, 22);
            this.tabEnrolements.Name = "tabEnrolements";
            this.tabEnrolements.Size = new System.Drawing.Size(875, 588);
            this.tabEnrolements.TabIndex = 4;
            this.tabEnrolements.Text = "Enrolments";
            this.tabEnrolements.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 638);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabStudents.ResumeLayout(false);
            this.tabStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGrid)).EndInit();
            this.tabStaff.ResumeLayout(false);
            this.tabStaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStaff)).EndInit();
            this.tabClasses.ResumeLayout(false);
            this.tabClasses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClasses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabStudents;
        private System.Windows.Forms.TabPage tabStaff;
        private System.Windows.Forms.TextBox studentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox studentEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabClasses;
        private System.Windows.Forms.TabPage tabMaterials;
        private System.Windows.Forms.TabPage tabEnrolements;
        private System.Windows.Forms.Button btnStudentAdd;
        private System.Windows.Forms.DataGridView studentDataGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnStudentDelete;
        private System.Windows.Forms.Button btnStudentUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox studentID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox staffID;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnUpdateStaff;
        private System.Windows.Forms.Button addStaff;
        private System.Windows.Forms.TextBox staffPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox staffEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox staffName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridStaff;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox classID;
        private System.Windows.Forms.Button btnDeleteClass;
        private System.Windows.Forms.Button btnUpdateClass;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.TextBox className;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dataGridClasses;
    }
}

