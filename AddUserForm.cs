using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace Project3
{
    public partial class AddUserForm : Form
    {
        private readonly string connectionString = "YourConnectionStringHere"; // Update with your actual connection string

        public AddUserForm()
        {
            InitializeComponent();
            PopulateRolesComboBox();
        }

        private void PopulateRolesComboBox()
        {
            try
            {
                using SqlConnection conn = new(connectionString);
                conn.Open();
                SqlCommand cmd = new("SELECT RoleName FROM Roles", conn);
                using SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbRole.Items.Add(reader["RoleName"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load roles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || cmbRole.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using SqlConnection conn = new(connectionString);
                conn.Open();
                // Begin transaction
                SqlTransaction transaction = conn.BeginTransaction();

                SqlCommand cmd = new("INSERT INTO Users (Username, Password, FirstName, LastName) VALUES (@Username, @Password, @FirstName, @LastName); SELECT SCOPE_IDENTITY();", conn, transaction);
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text); // Note: Store hashed password in a real application
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);

                // Execute command and get the new user's ID
                int newUserId = Convert.ToInt32(cmd.ExecuteScalar());

                // Assign role to the new user
                cmd = new SqlCommand("INSERT INTO UserRoles (UserID, RoleID) SELECT @UserID, RoleID FROM Roles WHERE RoleName = @RoleName", conn, transaction);
                cmd.Parameters.AddWithValue("@UserID", newUserId);
                cmd.Parameters.AddWithValue("@RoleName", cmbRole.SelectedItem.ToString());

                cmd.ExecuteNonQuery();

                // Commit transaction
                transaction.Commit();

                MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Add the rest of the form's code here, including InitializeComponent method that sets up the form controls
    }
}

