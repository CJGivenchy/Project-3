using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Project3
{
    public partial class DeleteRoleForm : Form
    {
        private readonly string connectionString = "YourConnectionStringHere"; // Update with your actual connection string

        public DeleteRoleForm()
        {
            InitializeComponent();
            PopulateUsersComboBox();
        }

        private void PopulateUsersComboBox()
        {
            try
            {
                using SqlConnection conn = new(connectionString);
                conn.Open();
                SqlCommand cmd = new("SELECT UserID, Username FROM Users ORDER BY Username", conn);
                SqlDataAdapter adapter = new(cmd);
                DataTable users = new();
                adapter.Fill(users);
                cmbUserSelection.DisplayMember = "Username"; // Updated from cmbUsers to cmbUserSelection
                cmbUserSelection.ValueMember = "UserID";
                cmbUserSelection.DataSource = users;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbUserSelection_SelectedIndexChanged(object sender, EventArgs e) // Method name updated to match the ComboBox name
        {
            if (cmbUserSelection.SelectedValue != null)
            {
                PopulateRolesForSelectedUser((int)cmbUserSelection.SelectedValue);
            }
        }

        private void PopulateRolesForSelectedUser(int userId)
        {
            try
            {
                using SqlConnection conn = new(connectionString);
                conn.Open();
                SqlCommand cmd = new(@"SELECT RoleID, RoleName FROM UserRoles ur
                                                      JOIN Roles r ON ur.RoleID = r.RoleID
                                                      WHERE ur.UserID = @UserID", conn);
                cmd.Parameters.AddWithValue("@UserID", userId);
                SqlDataAdapter adapter = new(cmd);
                DataTable roles = new();
                adapter.Fill(roles);
                cmbRoleToDelete.DisplayMember = "RoleName"; // Updated from lstRoles to cmbRoleToDelete
                cmbRoleToDelete.ValueMember = "RoleID";
                cmbRoleToDelete.DataSource = roles;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load roles for the selected user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDeleteRole_Click(object sender, EventArgs e)
        {
            if (cmbUserSelection.SelectedValue != null && cmbRoleToDelete.SelectedValue != null) // Updated to use cmbRoleToDelete.SelectedValue
            {
                try
                {
                    using SqlConnection conn = new(connectionString);
                    conn.Open();
                    string roleName = cmbRoleToDelete.Text; // Since it's a ComboBox, we use the Text property to get the selected RoleName
                    SqlCommand cmd = new(@"DELETE FROM UserRoles 
                                                          WHERE UserID = @UserID 
                                                          AND RoleID = (SELECT RoleID FROM Roles WHERE RoleName = @RoleName)", conn);
                    cmd.Parameters.AddWithValue("@UserID", cmbUserSelection.SelectedValue);
                    cmd.Parameters.AddWithValue("@RoleName", roleName);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Selected role has been successfully deleted from the user.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopulateRolesForSelectedUser((int)cmbUserSelection.SelectedValue); // Refresh roles list
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to delete role: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Rest of the form's code, including InitializeComponent
    }
}
