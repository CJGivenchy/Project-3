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
    public partial class AddNewTitleForm : Form
    {
        private readonly string connectionString = "YourConnectionStringHere"; // Update with your actual connection string

        public AddNewTitleForm()
        {
            InitializeComponent();
            PopulateAuthorsComboBox();
        }

        private void PopulateAuthorsComboBox()
        {
            try
            {
                using var conn = new SqlConnection(connectionString);
                conn.Open();
                var cmd = new SqlCommand("SELECT AuthorID, Name FROM Authors ORDER BY Name", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbAuthors.Items.Add(new
                        {
                            AuthorID = reader["AuthorID"],
                            Name = reader["Name"].ToString()
                        });
                    }
                }
                cmbAuthors.DisplayMember = "Name";
                cmbAuthors.ValueMember = "AuthorID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load authors: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAddTitle_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtISBN13.Text))
            {
                MessageBox.Show("Title and ISBN13 are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var conn = new SqlConnection(connectionString);
                conn.Open();
                // Begin transaction
                SqlTransaction transaction = conn.BeginTransaction();

                // Insert the new book
                var cmd = new SqlCommand(@"INSERT INTO Books (Title, CopyrightYear, ISBN13, Location, TotalCopies) 
                                                VALUES (@Title, @CopyrightYear, @ISBN13, @Location, @TotalCopies); 
                                                SELECT SCOPE_IDENTITY();", conn, transaction);
                cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@CopyrightYear", string.IsNullOrWhiteSpace(txtCopyrightYear.Text) ? (object)DBNull.Value : Convert.ToInt32(txtCopyrightYear.Text));
                cmd.Parameters.AddWithValue("@ISBN13", txtISBN13.Text);
                cmd.Parameters.AddWithValue("@Location", txtLocation.Text);
                cmd.Parameters.AddWithValue("@TotalCopies", numTotalCopies.Value);
                int newBookId = Convert.ToInt32(cmd.ExecuteScalar());

                // Associate book with selected author
                if (cmbAuthors.SelectedItem != null)
                {
                    var selectedAuthorId = (cmbAuthors.SelectedItem as dynamic).AuthorID;
                    cmd = new SqlCommand("INSERT INTO BookAuthors (BookID, AuthorID) VALUES (@BookID, @AuthorID)", conn, transaction);
                    cmd.Parameters.AddWithValue("@BookID", newBookId);
                    cmd.Parameters.AddWithValue("@AuthorID", selectedAuthorId);
                    cmd.ExecuteNonQuery();
                }

                transaction.Commit();

                MessageBox.Show("New title added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add new title: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Initialize component and other form controls here as required
    }
}

