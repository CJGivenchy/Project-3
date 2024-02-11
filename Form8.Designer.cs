namespace Project_3
{
    partial class FacultyStudentForm
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
            btnCheckOutBook = new Button();
            btnReturnBook = new Button();
            SuspendLayout();
            // 
            // btnCheckOutBook
            // 
            btnCheckOutBook.Location = new Point(50, 30);
            btnCheckOutBook.Name = "btnCheckOutBook";
            btnCheckOutBook.Size = new Size(300, 40);
            btnCheckOutBook.TabIndex = 0;
            btnCheckOutBook.Text = "Check Out a Book";
            btnCheckOutBook.UseVisualStyleBackColor = true;
            // 
            // btnReturnBook
            // 
            btnReturnBook.Location = new Point(50, 90);
            btnReturnBook.Name = "btnReturnBook";
            btnReturnBook.Size = new Size(300, 40);
            btnReturnBook.TabIndex = 1;
            btnReturnBook.Text = "Return a Book";
            btnReturnBook.UseVisualStyleBackColor = true;
            // 
            // FacultyStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 153);
            Controls.Add(btnReturnBook);
            Controls.Add(btnCheckOutBook);
            Name = "FacultyStudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library Services";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCheckOutBook;
        private Button btnReturnBook;
    }
}