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
    public partial class AdjustCopiesForm : Form
    {
        private readonly string connectionString = "YourConnectionStringHere"; // Update with your actual connection string

        public AdjustCopiesForm()
        {
            InitializeComponent();
            PopulateBooksComboBox();
        }

        private void PopulateBooksComboBox()
        {
            try
            {
                using var conn = new SqlConnection(connectionString);
                conn.Open();
                var cmd = new SqlCommand("SELECT BookID, Title FROM Books ORDER BY Title", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbBookSearch.Items.Add(new
                        {
                            BookID = reader["BookID"],
                            Title = reader["Title"].ToString()
                        });
                    }
                }
                cmbBookSearch.DisplayMember = "Title";
                cmbBookSearch.ValueMember = "BookID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load books: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAdjustCopies_Click(object sender, EventArgs e)
        {
            if (cmbBookSearch.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a book to adjust.", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedBookId = (cmbBookSearch.SelectedItem as dynamic).BookID;
            var newTotalCopies = (int)numTotalCopies.Value;

            try
            {
                using var conn = new SqlConnection(connectionString);
                conn.Open();
                var cmd = new SqlCommand(@"UPDATE Books SET TotalCopies = @TotalCopies 
                                               WHERE BookID = @BookID", conn);
                cmd.Parameters.AddWithValue("@TotalCopies", newTotalCopies);
                cmd.Parameters.AddWithValue("@BookID", selectedBookId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Total copies adjusted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to adjust copies: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Initialize component and other form controls here as required
    }
}
