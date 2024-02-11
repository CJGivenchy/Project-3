namespace Project_3
{
    partial class ReturnBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnReturnBook = new Button();
            lstCheckedOutBooks = new ListBox();
            lblCheckedOutBooks = new Label();
            SuspendLayout();
            // 
            // btnReturnBook
            // 
            btnReturnBook.Location = new Point(97, 210);
            btnReturnBook.Name = "btnReturnBook";
            btnReturnBook.Size = new Size(200, 40);
            btnReturnBook.TabIndex = 0;
            btnReturnBook.Text = "Return Selected Book(s)";
            btnReturnBook.UseVisualStyleBackColor = true;
            // 
            // lstCheckedOutBooks
            // 
            lstCheckedOutBooks.FormattingEnabled = true;
            lstCheckedOutBooks.ItemHeight = 20;
            lstCheckedOutBooks.Location = new Point(50, 20);
            lstCheckedOutBooks.Name = "lstCheckedOutBooks";
            lstCheckedOutBooks.SelectionMode = SelectionMode.MultiExtended;
            lstCheckedOutBooks.Size = new Size(300, 184);
            lstCheckedOutBooks.TabIndex = 1;
            // 
            // lblCheckedOutBooks
            // 
            lblCheckedOutBooks.AutoSize = true;
            lblCheckedOutBooks.Location = new Point(50, 0);
            lblCheckedOutBooks.Name = "lblCheckedOutBooks";
            lblCheckedOutBooks.Size = new Size(140, 20);
            lblCheckedOutBooks.TabIndex = 2;
            lblCheckedOutBooks.Text = "Checked Out Books:";
            // 
            // ReturnBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 253);
            Controls.Add(lblCheckedOutBooks);
            Controls.Add(lstCheckedOutBooks);
            Controls.Add(btnReturnBook);
            Name = "ReturnBookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Return Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReturnBook;
        private ListBox lstCheckedOutBooks;
        private Label lblCheckedOutBooks;
    }
}