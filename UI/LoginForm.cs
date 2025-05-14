using System;
using CourseManagementSystem.DAL;
using CourseManagementSystem.Model;
using CourseManagementSystem.UI;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManagementSystem.UI
{
    public partial class LoginForm : Form
    {
        private readonly AppDbContext context = new AppDbContext();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void clearFields()
        {
            textBoxLuser.Clear();
            textBoxLpass.Clear();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxLuser.Text;
            string password = textBoxLpass.Text;
            // Validate input
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.", "Alert");
                return;
            }
            // Validate user credentials
            var user = context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                // User is valid, proceed to the next form based on role
                string role = user.Role;
                if (role == "Admin")
                {
                    AdminForm adminForm = new AdminForm();
                    this.Hide();
                    adminForm.ShowDialog();
                    this.Close();
                }
                
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }

        }

        private void buttonLclear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void buttonLback_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.ShowDialog();
            this.Close();
        }
    }
}
