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
    public partial class CheckOutForm : Form
    {
        private readonly string connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=TinyLibraryDB;Integrated Security=True";

        public CheckOutForm()
        {
            InitializeComponent();
            InitializeFormControls();
        }

        private void InitializeFormControls()
        {
            btnCheckOut.Enabled = false; // Disable the check out button until a book is selected
        }

        private void TxtTitleSearch_TextChanged(object sender, EventArgs e)
        {
            SearchBooks(txtTitleSearch.Text.Trim());
        }

        private void SearchBooks(string searchText)
        {
            lstAvailableTitles.Items.Clear();

            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new SqlCommand(@"SELECT Title FROM Books WHERE Title LIKE @SearchText AND TotalCopies > 0", conn);
                    cmd.Parameters.AddWithValue("@SearchText", $"%{searchText}%");

                    using var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var title = reader["Title"] as string; // Using 'as' operator for safe casting
                        lstAvailableTitles.Items.Add(title ?? "Unknown Title"); // Provide a default value if null
                    }
                }

                btnCheckOut.Enabled = lstAvailableTitles.Items.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to search books: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LstAvailableTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCheckOut.Enabled = lstAvailableTitles.SelectedIndex != -1;
        }

        private void BtnCheckOut_Click(object sender, EventArgs e)
        {
            if (lstAvailableTitles.SelectedItem != null)
            {
                string selectedBookTitle = lstAvailableTitles.SelectedItem?.ToString() ?? "Unknown Title";
                CheckOutBook(selectedBookTitle);
            }
        }

        // Marked as static following CA1822 Code Analysis recommendation
        private static void CheckOutBook(string bookTitle)
        {
            MessageBox.Show($"{bookTitle} has been checked out.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Implement the logic to update the database and form view after checkout
        }
    }
}
