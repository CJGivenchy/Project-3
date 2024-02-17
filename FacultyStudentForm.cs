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
    public partial class FacultyStudentForm : Form
    {
        public FacultyStudentForm()
        {
            InitializeComponent();
            AttachEventHandlers();
        }

        private void AttachEventHandlers()
        {
            // Attach event handlers to buttons
            this.btnCheckOutBook.Click += new EventHandler(BtnCheckOutBook_Click);
            this.btnReturnBook.Click += new EventHandler(BtnReturnBook_Click);
        }

        private void BtnCheckOutBook_Click(object sender, EventArgs e)
        {
            // Open the CheckOutForm for the user to select and check out books
            CheckOutForm checkOutForm = new CheckOutForm(); // Assuming you have a form named CheckOutForm for this purpose
            checkOutForm.ShowDialog(); // Show the form as a dialog
            // Optionally, refresh any relevant data/display in this form after the CheckOutForm is closed
        }

        private void BtnReturnBook_Click(object sender, EventArgs e)
        {
            // Open the ReturnBookForm for the user to select books to return
            // Assuming you have a form named ReturnBookForm for this purpose and it takes no arguments in its constructor
            ReturnBookForm returnBookForm = new ReturnBookForm();
            returnBookForm.ShowDialog(); // Show the form as a dialog
            // Optionally, refresh any relevant data/display in this form after the ReturnBookForm is closed
        }

        // Ensure InitializeComponent method is present and correctly initializes your form's components,
        // especially btnCheckOutBook and btnReturnBook.
    }
}
