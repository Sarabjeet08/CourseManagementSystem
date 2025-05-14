namespace CourseManagementSystem.UI
{
    partial class AdminForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dataGridViewAdminCourse = new System.Windows.Forms.DataGridView();
            this.buttonCourseDelete = new System.Windows.Forms.Button();
            this.buttonCourseEdit = new System.Windows.Forms.Button();
            this.buttonCourseAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxSemester = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCredits = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCourseID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewAdminTeacher = new System.Windows.Forms.DataGridView();
            this.buttonUpdateTeacher = new System.Windows.Forms.Button();
            this.buttonDeleteTeacher = new System.Windows.Forms.Button();
            this.buttonEditTeacher = new System.Windows.Forms.Button();
            this.buttonAddTeacher = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.textBoxLname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxFname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxTeacherID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonUnassign = new System.Windows.Forms.Button();
            this.buttonAssign = new System.Windows.Forms.Button();
            this.dataGridViewAssinged = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelTeacherInfo = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBoxSelectTeacher = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelCourseInfo = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxSelectCourse = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminCourse)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminTeacher)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssinged)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(764, 288);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(11, 10);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 30);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1224, 458);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonUpdate);
            this.tabPage1.Controls.Add(this.dataGridViewAdminCourse);
            this.tabPage1.Controls.Add(this.buttonCourseDelete);
            this.tabPage1.Controls.Add(this.buttonCourseEdit);
            this.tabPage1.Controls.Add(this.buttonCourseAdd);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1216, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Course";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(170, 390);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 31);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // dataGridViewAdminCourse
            // 
            this.dataGridViewAdminCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAdminCourse.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewAdminCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdminCourse.Location = new System.Drawing.Point(348, 18);
            this.dataGridViewAdminCourse.Name = "dataGridViewAdminCourse";
            this.dataGridViewAdminCourse.Size = new System.Drawing.Size(861, 403);
            this.dataGridViewAdminCourse.TabIndex = 5;
            // 
            // buttonCourseDelete
            // 
            this.buttonCourseDelete.Location = new System.Drawing.Point(251, 391);
            this.buttonCourseDelete.Name = "buttonCourseDelete";
            this.buttonCourseDelete.Size = new System.Drawing.Size(75, 31);
            this.buttonCourseDelete.TabIndex = 4;
            this.buttonCourseDelete.Text = "Delete";
            this.buttonCourseDelete.UseVisualStyleBackColor = true;
            this.buttonCourseDelete.Click += new System.EventHandler(this.buttonCourseDelete_Click);
            // 
            // buttonCourseEdit
            // 
            this.buttonCourseEdit.Location = new System.Drawing.Point(89, 390);
            this.buttonCourseEdit.Name = "buttonCourseEdit";
            this.buttonCourseEdit.Size = new System.Drawing.Size(75, 31);
            this.buttonCourseEdit.TabIndex = 3;
            this.buttonCourseEdit.Text = "Edit";
            this.buttonCourseEdit.UseVisualStyleBackColor = true;
            this.buttonCourseEdit.Click += new System.EventHandler(this.buttonCourseEdit_Click);
            // 
            // buttonCourseAdd
            // 
            this.buttonCourseAdd.Location = new System.Drawing.Point(8, 390);
            this.buttonCourseAdd.Name = "buttonCourseAdd";
            this.buttonCourseAdd.Size = new System.Drawing.Size(75, 31);
            this.buttonCourseAdd.TabIndex = 2;
            this.buttonCourseAdd.Text = "Add";
            this.buttonCourseAdd.UseVisualStyleBackColor = true;
            this.buttonCourseAdd.Click += new System.EventHandler(this.buttonCourseAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxSemester);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxCredits);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxDescription);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxCourseName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxCourseID);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(8, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 376);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Course Details";
            // 
            // textBoxSemester
            // 
            this.textBoxSemester.Location = new System.Drawing.Point(145, 212);
            this.textBoxSemester.Name = "textBoxSemester";
            this.textBoxSemester.Size = new System.Drawing.Size(180, 23);
            this.textBoxSemester.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Semester :";
            // 
            // textBoxCredits
            // 
            this.textBoxCredits.Location = new System.Drawing.Point(147, 151);
            this.textBoxCredits.Name = "textBoxCredits";
            this.textBoxCredits.Size = new System.Drawing.Size(180, 23);
            this.textBoxCredits.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Credits :";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(147, 277);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(180, 86);
            this.textBoxDescription.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Description :";
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Location = new System.Drawing.Point(147, 89);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(180, 23);
            this.textBoxCourseName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Course Name :";
            // 
            // textBoxCourseID
            // 
            this.textBoxCourseID.Location = new System.Drawing.Point(147, 36);
            this.textBoxCourseID.Name = "textBoxCourseID";
            this.textBoxCourseID.Size = new System.Drawing.Size(180, 23);
            this.textBoxCourseID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Course ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewAdminTeacher);
            this.tabPage2.Controls.Add(this.buttonUpdateTeacher);
            this.tabPage2.Controls.Add(this.buttonDeleteTeacher);
            this.tabPage2.Controls.Add(this.buttonEditTeacher);
            this.tabPage2.Controls.Add(this.buttonAddTeacher);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1216, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Teacher";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAdminTeacher
            // 
            this.dataGridViewAdminTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAdminTeacher.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewAdminTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdminTeacher.Location = new System.Drawing.Point(346, 7);
            this.dataGridViewAdminTeacher.Name = "dataGridViewAdminTeacher";
            this.dataGridViewAdminTeacher.Size = new System.Drawing.Size(863, 415);
            this.dataGridViewAdminTeacher.TabIndex = 11;
            // 
            // buttonUpdateTeacher
            // 
            this.buttonUpdateTeacher.Location = new System.Drawing.Point(174, 391);
            this.buttonUpdateTeacher.Name = "buttonUpdateTeacher";
            this.buttonUpdateTeacher.Size = new System.Drawing.Size(75, 31);
            this.buttonUpdateTeacher.TabIndex = 10;
            this.buttonUpdateTeacher.Text = "Update";
            this.buttonUpdateTeacher.UseVisualStyleBackColor = true;
            this.buttonUpdateTeacher.Click += new System.EventHandler(this.buttonUpdateTeacher_Click);
            // 
            // buttonDeleteTeacher
            // 
            this.buttonDeleteTeacher.Location = new System.Drawing.Point(255, 391);
            this.buttonDeleteTeacher.Name = "buttonDeleteTeacher";
            this.buttonDeleteTeacher.Size = new System.Drawing.Size(75, 31);
            this.buttonDeleteTeacher.TabIndex = 9;
            this.buttonDeleteTeacher.Text = "Delete";
            this.buttonDeleteTeacher.UseVisualStyleBackColor = true;
            this.buttonDeleteTeacher.Click += new System.EventHandler(this.buttonDeleteTeacher_Click);
            // 
            // buttonEditTeacher
            // 
            this.buttonEditTeacher.Location = new System.Drawing.Point(84, 391);
            this.buttonEditTeacher.Name = "buttonEditTeacher";
            this.buttonEditTeacher.Size = new System.Drawing.Size(75, 31);
            this.buttonEditTeacher.TabIndex = 8;
            this.buttonEditTeacher.Text = "Edit";
            this.buttonEditTeacher.UseVisualStyleBackColor = true;
            this.buttonEditTeacher.Click += new System.EventHandler(this.buttonEditTeacher_Click);
            // 
            // buttonAddTeacher
            // 
            this.buttonAddTeacher.Location = new System.Drawing.Point(3, 391);
            this.buttonAddTeacher.Name = "buttonAddTeacher";
            this.buttonAddTeacher.Size = new System.Drawing.Size(75, 31);
            this.buttonAddTeacher.TabIndex = 7;
            this.buttonAddTeacher.Text = "Add";
            this.buttonAddTeacher.UseVisualStyleBackColor = true;
            this.buttonAddTeacher.Click += new System.EventHandler(this.buttonAddTeacher_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxDepartment);
            this.groupBox3.Controls.Add(this.textBoxLname);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBoxEmail);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBoxFname);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBoxTeacherID);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(7, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 378);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Teacher Details";
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(147, 335);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(176, 24);
            this.comboBoxDepartment.TabIndex = 20;
            // 
            // textBoxLname
            // 
            this.textBoxLname.Location = new System.Drawing.Point(147, 185);
            this.textBoxLname.Name = "textBoxLname";
            this.textBoxLname.Size = new System.Drawing.Size(180, 23);
            this.textBoxLname.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "Last Name :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Department :";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(147, 264);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(180, 23);
            this.textBoxEmail.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Email :";
            // 
            // textBoxFname
            // 
            this.textBoxFname.Location = new System.Drawing.Point(147, 109);
            this.textBoxFname.Name = "textBoxFname";
            this.textBoxFname.Size = new System.Drawing.Size(180, 23);
            this.textBoxFname.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "First Name :";
            // 
            // textBoxTeacherID
            // 
            this.textBoxTeacherID.Location = new System.Drawing.Point(147, 47);
            this.textBoxTeacherID.Name = "textBoxTeacherID";
            this.textBoxTeacherID.Size = new System.Drawing.Size(180, 23);
            this.textBoxTeacherID.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Teacher ID :";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonUnassign);
            this.tabPage3.Controls.Add(this.buttonAssign);
            this.tabPage3.Controls.Add(this.dataGridViewAssinged);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1216, 429);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Assign Course";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonUnassign
            // 
            this.buttonUnassign.Location = new System.Drawing.Point(123, 361);
            this.buttonUnassign.Name = "buttonUnassign";
            this.buttonUnassign.Size = new System.Drawing.Size(84, 29);
            this.buttonUnassign.TabIndex = 8;
            this.buttonUnassign.Text = "Un-Assign";
            this.buttonUnassign.UseVisualStyleBackColor = true;
            this.buttonUnassign.Click += new System.EventHandler(this.buttonUnassign_Click);
            // 
            // buttonAssign
            // 
            this.buttonAssign.Location = new System.Drawing.Point(16, 361);
            this.buttonAssign.Name = "buttonAssign";
            this.buttonAssign.Size = new System.Drawing.Size(75, 29);
            this.buttonAssign.TabIndex = 7;
            this.buttonAssign.Text = "Assign";
            this.buttonAssign.UseVisualStyleBackColor = true;
            this.buttonAssign.Click += new System.EventHandler(this.buttonAssign_Click_1);
            // 
            // dataGridViewAssinged
            // 
            this.dataGridViewAssinged.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAssinged.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewAssinged.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssinged.Location = new System.Drawing.Point(536, 7);
            this.dataGridViewAssinged.Name = "dataGridViewAssinged";
            this.dataGridViewAssinged.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewAssinged.Size = new System.Drawing.Size(677, 415);
            this.dataGridViewAssinged.TabIndex = 6;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelTeacherInfo);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.comboBoxSelectTeacher);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Location = new System.Drawing.Point(266, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(264, 330);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Teacher Selection";
            // 
            // labelTeacherInfo
            // 
            this.labelTeacherInfo.AutoSize = true;
            this.labelTeacherInfo.Location = new System.Drawing.Point(6, 122);
            this.labelTeacherInfo.Name = "labelTeacherInfo";
            this.labelTeacherInfo.Size = new System.Drawing.Size(35, 17);
            this.labelTeacherInfo.TabIndex = 6;
            this.labelTeacherInfo.Text = "Info:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(70, 82);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 17);
            this.label16.TabIndex = 4;
            this.label16.Text = "Teacher Info :";
            // 
            // comboBoxSelectTeacher
            // 
            this.comboBoxSelectTeacher.FormattingEnabled = true;
            this.comboBoxSelectTeacher.Location = new System.Drawing.Point(116, 30);
            this.comboBoxSelectTeacher.Name = "comboBoxSelectTeacher";
            this.comboBoxSelectTeacher.Size = new System.Drawing.Size(125, 24);
            this.comboBoxSelectTeacher.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(112, 17);
            this.label17.TabIndex = 0;
            this.label17.Text = "Select Teacher :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelCourseInfo);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.comboBoxSelectCourse);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(7, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(253, 330);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Course Selection";
            // 
            // labelCourseInfo
            // 
            this.labelCourseInfo.AutoSize = true;
            this.labelCourseInfo.Location = new System.Drawing.Point(0, 122);
            this.labelCourseInfo.MaximumSize = new System.Drawing.Size(240, 0);
            this.labelCourseInfo.Name = "labelCourseInfo";
            this.labelCourseInfo.Size = new System.Drawing.Size(35, 17);
            this.labelCourseInfo.TabIndex = 5;
            this.labelCourseInfo.Text = "Info:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(71, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 17);
            this.label15.TabIndex = 4;
            this.label15.Text = "Course Info :";
            // 
            // comboBoxSelectCourse
            // 
            this.comboBoxSelectCourse.FormattingEnabled = true;
            this.comboBoxSelectCourse.Location = new System.Drawing.Point(116, 30);
            this.comboBoxSelectCourse.Name = "comboBoxSelectCourse";
            this.comboBoxSelectCourse.Size = new System.Drawing.Size(124, 24);
            this.comboBoxSelectCourse.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Select Course :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(503, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Admin Dashboard";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(1158, 491);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 31);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(1059, 491);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 31);
            this.buttonLogout.TabIndex = 11;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // AdminForm
            // 
            this.AcceptButton = this.buttonAddTeacher;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(1250, 527);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Management System";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminCourse)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminTeacher)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssinged)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxCourseID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewAdminCourse;
        private System.Windows.Forms.Button buttonCourseDelete;
        private System.Windows.Forms.Button buttonCourseEdit;
        private System.Windows.Forms.Button buttonCourseAdd;
        private System.Windows.Forms.TextBox textBoxSemester;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCredits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxLname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxFname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxTeacherID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonUpdateTeacher;
        private System.Windows.Forms.Button buttonDeleteTeacher;
        private System.Windows.Forms.Button buttonEditTeacher;
        private System.Windows.Forms.Button buttonAddTeacher;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.DataGridView dataGridViewAdminTeacher;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBoxSelectTeacher;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxSelectCourse;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonUnassign;
        private System.Windows.Forms.Button buttonAssign;
        private System.Windows.Forms.DataGridView dataGridViewAssinged;
        private System.Windows.Forms.Label labelTeacherInfo;
        private System.Windows.Forms.Label labelCourseInfo;
        private System.Windows.Forms.Button buttonLogout;
    }
}