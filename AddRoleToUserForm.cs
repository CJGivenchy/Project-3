using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Project3
{
    public partial class AddRoleToUserForm : Form
    {
        private readonly string connectionString = "YourConnectionStringHere"; // Update with your actual connection string

        public AddRoleToUserForm()
        {
            InitializeComponent();
            PopulateUsersComboBox();
        }

        private void PopulateUsersComboBox()
        {
            cmbUserSelection.Items.Clear();
            try
            {
                using var conn = new SqlConnection(connectionString);
                conn.Open();
                var cmd = new SqlCommand("SELECT UserID, Username FROM Users ORDER BY Username", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbUserSelection.Items.Add(new
                        {
                            UserID = reader["UserID"],
                            Username = reader["Username"].ToString()
                        });
                    }
                }
                cmbUserSelection.DisplayMember = "Username";
                cmbUserSelection.ValueMember = "UserID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbUserSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUserSelection.SelectedIndex != -1)
            {
                PopulateAvailableRolesComboBox((int)cmbUserSelection.SelectedValue);
            }
        }

        private void PopulateAvailableRolesComboBox(int userId)
        {
            cmbRoleToAdd.Items.Clear();
            try
            {
                using var conn = new SqlConnection(connectionString);
                conn.Open();
                var cmd = new SqlCommand(@"SELECT RoleName FROM Roles 
                                                WHERE RoleID NOT IN (
                                                    SELECT RoleID FROM UserRoles WHERE UserID = @UserID
                                                ) ORDER BY RoleName", conn);
                cmd.Parameters.AddWithValue("@UserID", userId);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbRoleToAdd.Items.Add(reader["RoleName"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load available roles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAddRole_Click(object sender, EventArgs e)
        {
            if (cmbUserSelection.SelectedIndex == -1 || cmbRoleToAdd.SelectedIndex == -1)
            {
                MessageBox.Show("Please select both a user and a role to add.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedUserId = (cmbUserSelection.SelectedItem as dynamic).UserID;
            var selectedRoleName = cmbRoleToAdd.SelectedItem.ToString();

            try
            {
                using var conn = new SqlConnection(connectionString);
                conn.Open();
                var cmd = new SqlCommand(@"INSERT INTO UserRoles (UserID, RoleID) 
                                                SELECT @UserID, RoleID FROM Roles WHERE RoleName = @RoleName", conn);
                cmd.Parameters.AddWithValue("@UserID", selectedUserId);
                cmd.Parameters.AddWithValue("@RoleName", selectedRoleName);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Role added to user successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add role to user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Initialize component and other form controls here as required
    }
}
