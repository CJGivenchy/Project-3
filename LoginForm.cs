using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Project3
{
    public partial class LoginForm : Form
    {
        // Directly using the provided connection string (for demonstration)
        private readonly string connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=TinyLibraryDB;Integrated Security=True";

        // Public property to store the user's role after successful authentication, now nullable
        public string? UserRole { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            PopulateRoles();
        }

        private void PopulateRoles()
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT RoleName FROM Roles", conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbRole.Items.Add(reader["RoleName"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load roles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text; // Assuming plaintext for simplicity
            // Safely handle potential null from cmbRole.SelectedItem
            string role = cmbRole.SelectedItem?.ToString() ?? string.Empty;

            if (!string.IsNullOrEmpty(role) && AuthenticateUser(username, password, role))
            {
                UserRole = role; // Set the UserRole property to the authenticated user's role

                MessageBox.Show("Login successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username, password, or role.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AuthenticateUser(string username, string password, string role)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new SqlCommand(@"SELECT COUNT(*) FROM Users 
                                                WHERE Username = @Username AND Password = @Password AND Role = @Role", conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password); // Consider using parameterized queries to avoid SQL injection
                    cmd.Parameters.AddWithValue("@Role", role); // Ensure role checking is part of authentication

                    int result = (int)cmd.ExecuteScalar();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Authentication failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Make sure to include InitializeComponent method and any other necessary methods or properties for the form.
    }
}
