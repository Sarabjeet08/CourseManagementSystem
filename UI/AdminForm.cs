using System;
using CourseManagementSystem.DAL;
using CourseManagementSystem.Model;
using CourseManagementSystem.BLL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;

namespace CourseManagementSystem.UI
{
    public partial class AdminForm : Form
    {
        private CMSServices CMSServices = new CMSServices();
        public AdminForm()
        {
            InitializeComponent();
            LoadCourses();
            loadTeacher();
            loadDepartment();
            LoadAssinedCourses();
            LoadAssingComboBox();
        }
        public void clearFields()
        {
            //clear Course fields
            textBoxCourseID.Clear();
            textBoxCourseName.Clear();
            textBoxDescription.Clear();
            textBoxCredits.Clear();
            textBoxSemester.Clear();
            //clear Teacher fields
            textBoxTeacherID.Clear();
            textBoxFname.Clear();
            textBoxLname.Clear();
            textBoxEmail.Clear();
            comboBoxDepartment.SelectedIndex = 0;// Reset to default department

        }

        public void LoadCourses()
        {
            // Load courses into the DataGridView
            var courseTeacherList = CMSServices.GetAllCourses().Select(c => new
            {
                CourseId = c.CourseId,
                CourseName = c.CourseName,
                Description = c.Description,
                Credits = c.Credits,
                Semester = c.Semester
            }).ToList();
            dataGridViewAdminCourse.DataSource = courseTeacherList;
            //dataGridViewAdminCourse.DataSource = CMSServices.GetAllCourses();
        }
        private void buttonCourseAdd_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            course.CourseName = textBoxCourseName.Text;
            course.Description = textBoxDescription.Text;
            course.Credits = int.Parse(textBoxCredits.Text);
            course.Semester = textBoxSemester.Text;
            // Validate input
            if (String.IsNullOrEmpty(course.CourseId.ToString()) || string.IsNullOrEmpty(course.CourseName) || string.IsNullOrEmpty(course.Description) || 
                string.IsNullOrEmpty(course.Credits.ToString()) || string.IsNullOrEmpty(course.Semester))
            {
                MessageBox.Show("Please fill in all fields.", "Alert");
                return;
            }
            // Add course to the database
            try
            {
                CMSServices.AddCourse(course);
                MessageBox.Show("Course added successfully.", "Message");
                LoadCourses();
                clearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LoadAssingComboBox();


        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            // Close the current form and exit the application
            Application.Exit();
        }

        private void buttonCourseEdit_Click(object sender, EventArgs e)
        {
            // Get the selected course from the DataGridView
            if (dataGridViewAdminCourse.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a course to edit.", "Alert");
                return;
            }
            DataGridViewRow selectedRow = dataGridViewAdminCourse.SelectedRows[0];
            int courseId = (int)selectedRow.Cells["CourseId"].Value;
            string courseName = selectedRow.Cells["CourseName"].Value.ToString();
            string description = selectedRow.Cells["Description"].Value.ToString();
            int credits = (int)selectedRow.Cells["Credits"].Value;
            string semester = selectedRow.Cells["Semester"].Value.ToString();
            // Fill the text boxes with the selected course's information
            textBoxCourseID.Text = courseId.ToString();
            textBoxCourseName.Text = courseName;
            textBoxDescription.Text = description;
            textBoxCredits.Text = credits.ToString();
            textBoxSemester.Text = semester;

            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // Validate input
            if (String.IsNullOrEmpty(textBoxCourseID.Text) || string.IsNullOrEmpty(textBoxCourseName.Text) || string.IsNullOrEmpty(textBoxDescription.Text) ||
                string.IsNullOrEmpty(textBoxCredits.Text) || string.IsNullOrEmpty(textBoxSemester.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Alert");
                return;
            }
            // Update course information
            int NewCourseId = int.Parse(textBoxCourseID.Text);
            string NewCourseName = textBoxCourseName.Text;
            string NewDescription = textBoxDescription.Text;
            int NewCredits = int.Parse(textBoxCredits.Text);
            string NewSemester = textBoxSemester.Text;
            // Update course in the database
            try
            {
                CMSServices.UpdateCourse(NewCourseId, NewCourseName, NewDescription, NewCredits, NewSemester);
                MessageBox.Show("Course updated successfully.", "Message");
                LoadCourses();
                clearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonCourseDelete_Click(object sender, EventArgs e)
        {
            // Get the selected course from the DataGridView
            if (dataGridViewAdminCourse.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a course to delete.", "Alert");
                return;
            }
            DataGridViewRow selectedRow = dataGridViewAdminCourse.SelectedRows[0];
            int courseId = (int)selectedRow.Cells["CourseId"].Value;
            // Confirm deletion + Name of Coures
            string courseName = selectedRow.Cells["CourseName"].Value.ToString();
            DialogResult result = MessageBox.Show($"Are you sure you want to delete the course '{courseName}'?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Delete course from the database
                try
                {
                    CMSServices.DeleteCourse(courseId);
                    MessageBox.Show("Course deleted successfully.", "Message");
                    LoadCourses();
                    clearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        public void loadTeacher()
        {
            // Load teachers into the DataGridView
            var teacherList = CMSServices.GetAllTeachers().Select(t => new
            {
                TeacherId = t.TeacherId,
                FirstName = t.FirstName,
                LastName = t.LastName,
                Email = t.Email,
                Department = t.Department
            }).ToList();
            dataGridViewAdminTeacher.DataSource = teacherList;

            //dataGridViewAdminTeacher.DataSource = CMSServices.GetAllTeachers();
        }
        public void loadDepartment()
        {
            comboBoxDepartment.Items.Add("Software Engineering");
            comboBoxDepartment.Items.Add("Web & UI Development");
            comboBoxDepartment.Items.Add("Database & Information Systems");
            comboBoxDepartment.Items.Add("Computer Hardware & Networking");
        }

        private void buttonAddTeacher_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();

            teacher.TeacherId = int.Parse(textBoxTeacherID.Text);
            teacher.FirstName = textBoxFname.Text;
            teacher.LastName = textBoxLname.Text;
            teacher.Email = textBoxEmail.Text;
            teacher.Department = comboBoxDepartment.SelectedItem.ToString();
            // Validate input
            if (String.IsNullOrEmpty(teacher.TeacherId.ToString()) || string.IsNullOrEmpty(teacher.FirstName) || string.IsNullOrEmpty(teacher.LastName) ||
                string.IsNullOrEmpty(teacher.Email) || string.IsNullOrEmpty(teacher.Department))
            {
                MessageBox.Show("Please fill in all fields.", "Alert");
                return;
            }
            // Add teacher to the database
            try
            {
                CMSServices.AddTeacher(teacher);
                MessageBox.Show("Teacher added successfully.", "Message");
                loadTeacher();
                clearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadAssingComboBox();
        }

        private void buttonEditTeacher_Click(object sender, EventArgs e)
        {
            // Get the selected teacher from the DataGridView
            if (dataGridViewAdminTeacher.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a teacher to edit.", "Alert");
                return;
            }
            DataGridViewRow selectedRow = dataGridViewAdminTeacher.SelectedRows[0];
            int teacherId = (int)selectedRow.Cells["TeacherId"].Value;
            string firstName = selectedRow.Cells["FirstName"].Value.ToString();
            string lastName = selectedRow.Cells["LastName"].Value.ToString();
            string email = selectedRow.Cells["Email"].Value.ToString();
            string department = selectedRow.Cells["Department"].Value.ToString();
            // Fill the text boxes with the selected teacher's information
            textBoxTeacherID.Text = teacherId.ToString();
            textBoxFname.Text = firstName;
            textBoxLname.Text = lastName;
            textBoxEmail.Text = email;
            comboBoxDepartment.SelectedItem = department;
           

        }

        private void buttonUpdateTeacher_Click(object sender, EventArgs e)
        {
            // Validate input
            if (String.IsNullOrEmpty(textBoxTeacherID.Text) || string.IsNullOrEmpty(textBoxFname.Text) || string.IsNullOrEmpty(textBoxLname.Text) ||
                string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrEmpty(comboBoxDepartment.SelectedItem.ToString()))
            {
                MessageBox.Show("Please fill in all fields.", "Alert");
                return;
            }
            // Update teacher information
            int NewTeacherId = int.Parse(textBoxTeacherID.Text);
            string NewFirstName = textBoxFname.Text;
            string NewLastName = textBoxLname.Text;
            string NewEmail = textBoxEmail.Text;
            string NewDepartment = comboBoxDepartment.SelectedItem.ToString();
            // Update teacher in the database
            try
            {
                CMSServices.UpdateTeacher(NewTeacherId, NewFirstName, NewLastName, NewEmail, NewDepartment);
                MessageBox.Show("Teacher updated successfully.", "Message");
                loadTeacher();
                clearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonDeleteTeacher_Click(object sender, EventArgs e)
        {
            // Get the selected teacher from the DataGridView
            if (dataGridViewAdminTeacher.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a teacher to delete.", "Alert");
                return;
            }
            DataGridViewRow selectedRow = dataGridViewAdminTeacher.SelectedRows[0];
            int teacherId = (int)selectedRow.Cells["TeacherId"].Value;
            // Confirm deletion + Name of Teacher
            string teacherName = selectedRow.Cells["FirstName"].Value.ToString() + " " + selectedRow.Cells["LastName"].Value.ToString();
            DialogResult result = MessageBox.Show($"Are you sure you want to delete the teacher '{teacherName}'?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Delete teacher from the database
                try
                {
                    CMSServices.DeleteTeacher(teacherId);
                    MessageBox.Show("Teacher deleted successfully.", "Message");
                    loadTeacher();
                    clearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        // Assign Course to Teacher
        public void LoadAssinedCourses()
        {
            var assignedCourses = CMSServices.GetAllAssignedCourse();
            var courseTeacherList = assignedCourses.Select(tc =>
            {
                var course = CMSServices.GetCourseById(tc.CourseId);
                var teacher = CMSServices.GetTeacherById(tc.TeacherId);
                return new
                {
                    CourseId = tc.CourseId,
                    CourseName = course?.CourseName ?? "N/A",
                    TeacherId = tc.TeacherId,
                    TeacherName = teacher != null ? $"{teacher.FirstName} {teacher.LastName}" : "N/A"
                };
            }).ToList();

            dataGridViewAssinged.DataSource = courseTeacherList;
        }

        public void LoadAssingComboBox()
        {
            loadTeacher();
            LoadCourses();

            comboBoxSelectCourse.DataSource = CMSServices.GetAllCourses();
            comboBoxSelectCourse.DisplayMember = "CourseName";
            comboBoxSelectCourse.ValueMember = "CourseId";

            comboBoxSelectTeacher.DataSource = CMSServices.GetAllTeachers();
            comboBoxSelectTeacher.DisplayMember = "FirstName";
            comboBoxSelectTeacher.ValueMember = "TeacherId";

            // Clear previous event to prevent duplicate triggers
            comboBoxSelectCourse.SelectedIndexChanged -= ComboBoxSelectionChanged;
            comboBoxSelectTeacher.SelectedIndexChanged -= ComboBoxSelectionChanged;

            // Attach single shared event handler
            comboBoxSelectCourse.SelectedIndexChanged += ComboBoxSelectionChanged;
            comboBoxSelectTeacher.SelectedIndexChanged += ComboBoxSelectionChanged;

            // Initial display
            ComboBoxSelectionChanged(null, null);
        }

        private void ComboBoxSelectionChanged(object sender, EventArgs e)
        {
            if (comboBoxSelectCourse.SelectedValue == null || comboBoxSelectTeacher.SelectedValue == null)
                return;

            int courseId = (int)comboBoxSelectCourse.SelectedValue;
            int teacherId = (int)comboBoxSelectTeacher.SelectedValue;

            var course = CMSServices.GetCourseById(courseId);
            var teacher = CMSServices.GetTeacherById(teacherId);

            if (course != null)
            {
                labelCourseInfo.Text = $"Course ID: {course.CourseId}\n" +
                                       $"Course Name: {course.CourseName}\n" +
                                       $"Semester: {course.Semester}\n" +
                                       $"Description:\n{course.Description}";
            }

            if (teacher != null)
            {
                labelTeacherInfo.Text = $"Teacher ID: {teacher.TeacherId}\n" +
                                        $"Name: {teacher.FirstName} {teacher.LastName}\n" +
                                        $"Email: {teacher.Email}\n" +
                                        $"Department: {teacher.Department}";
            }
        }

     
      
        private void buttonUnassign_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (dataGridViewAssinged.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an assignment to unassign.", "Alert");
                return;
            }

            DataGridViewRow selectedRow = dataGridViewAssinged.SelectedRows[0];

            int courseId = Convert.ToInt32(selectedRow.Cells["CourseId"].Value);
            int teacherId = Convert.ToInt32(selectedRow.Cells["TeacherId"].Value);
            string courseName = selectedRow.Cells["CourseName"].Value?.ToString() ?? "Unknown Course";
            string teacherName = selectedRow.Cells["TeacherName"].Value?.ToString() ?? "Unknown Teacher";

            // Confirm unassignment
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to unassign the course '{courseName}' from teacher '{teacherName}'?",
                "Confirm Unassignment",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    CMSServices.UnassignCourseFromTeacher(teacherId, courseId);
                    MessageBox.Show("Course unassigned from teacher successfully.", "Message");
                    LoadAssinedCourses();
                    clearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Unassignment Failed");
                }
            }


        }
        private void buttonAssign_Click_1(object sender, EventArgs e)
        {
            // Validate input
            if (comboBoxSelectCourse.SelectedItem == null || comboBoxSelectTeacher.SelectedItem == null)
            {
                MessageBox.Show("Please select a course and a teacher.", "Alert");
                return;
            }

            int teacherId = (int)comboBoxSelectTeacher.SelectedValue;
            int courseId = (int)comboBoxSelectCourse.SelectedValue;

            string teacherName = comboBoxSelectTeacher.Text;
            string courseName = comboBoxSelectCourse.Text;

            // Check if course is already assigned to the teacher
            var existingAssignment = CMSServices.GetAssignedCoursesByTeacherId(teacherId)
                .FirstOrDefault(a => a.CourseId == courseId);

            if (existingAssignment != null)
            {
                MessageBox.Show($"The course \"{courseName}\" is already assigned to teacher \"{teacherName}\".", "Duplicate Assignment");
                return;
            }

            // Validate max courses per teacher
            int currentCourseCount = CMSServices.GetAssignedCoursesByTeacherId(teacherId).Count();
            if (currentCourseCount >= 4)
            {
                MessageBox.Show($"Teacher \"{teacherName}\" already has 4 assigned courses.", "Validation Error");
                return;
            }

            // Show confirmation message
            DialogResult result = MessageBox.Show($"Are you sure you want to assign course \"{courseName}\" to teacher \"{teacherName}\"?",
                                                  "Confirm Assignment",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            try
            {
                CMSServices.AssignCourseToTeacher(teacherId, courseId);
                MessageBox.Show($"Course \"{courseName}\" has been successfully assigned to teacher \"{teacherName}\".", "Success");
                LoadAssinedCourses();
                clearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void buttonLogout_Click(object sender, EventArgs e)
        {
            //Comfirm logout
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            // Close the current form and show the login form
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();

        }
    }
 }
