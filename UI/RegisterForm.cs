using CourseManagementSystem.DAL;
using CourseManagementSystem.Model;
using CourseManagementSystem.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManagementSystem
{
    public partial class RegisterForm : Form
    {
        private readonly AppDbContext context = new AppDbContext();
        public RegisterForm()
        {
            InitializeComponent();
            LoadRole();

        }

        private void LoadRole()
        {
            // Load roles into the combo box
            comboBoxRole.Items.Add("Admin");
            comboBoxRole.SelectedIndex = 0; // Set default selection
        }

        private void clearFields()
        {
            textBoxRuser.Clear();
            textBoxRpass.Clear();
            textBoxRpassConfirm.Clear();
            comboBoxRole.SelectedIndex = 0; // Reset to default role
        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string username = textBoxRuser.Text;
            string password = textBoxRpass.Text;
            string confirmPassword = textBoxRpassConfirm.Text;
            string role = comboBoxRole.SelectedItem.ToString();
            //Hide the password 
            textBoxRpass.Visible = false;
            textBoxRpassConfirm.Visible = false;
            // Validate password confirmation
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.","Alert");
                return;
            }
            // Validate input
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Alert");
                return;
            }
            // Check if the username already exists
            var existingUser = context.Users.FirstOrDefault(u => u.Username == username);
            if (existingUser != null)
            {
                MessageBox.Show("Username already exists.", "Alert");
                return;
            }

            // Create a new user
            var user = new User
            {
                Username = username,
                Password = password,
                Role = role
            };
            context.Users.Add(user);
            context.SaveChanges();
            MessageBox.Show("Registration successful!", "Message");
            // Clear the input fields
            clearFields();
        }

        private void buttonRclear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void buttonRback_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
