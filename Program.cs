using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize the login form and show it
            LoginForm loginForm = new LoginForm();
            DialogResult loginResult = loginForm.ShowDialog();

            if (loginResult == DialogResult.OK)
            {
                // Assuming LoginForm sets a public property or static variable indicating the user's role
                // For demonstration, let's assume LoginForm has a static property UserRole indicating the role
                switch (LoginForm.UserRole)
                {
                    case "Admin":
                        // Show the Admin Form
                        Application.Run(new AdminForm());
                        break;
                    case "Faculty":
                    case "Student":
                        // Show the Faculty/Student Form
                        Application.Run(new FacultyStudentForm());
                        break;
                    default:
                        MessageBox.Show("Invalid role detected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                // Handle cases where the login is canceled or failed
                MessageBox.Show("Login was unsuccessful or canceled.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
