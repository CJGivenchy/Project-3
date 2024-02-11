namespace Project_3
{
    partial class CheckOutForm
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
            textBox1 = new TextBox();
            lblTitleSearch = new Label();
            lstAvailableTitles = new ListBox();
            lblAvailableTitles = new Label();
            btnCheckOut = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 27);
            textBox1.TabIndex = 0;
            // 
            // lblTitleSearch
            // 
            lblTitleSearch.AutoSize = true;
            lblTitleSearch.Location = new Point(20, 23);
            lblTitleSearch.Name = "lblTitleSearch";
            lblTitleSearch.Size = new Size(89, 20);
            lblTitleSearch.TabIndex = 1;
            lblTitleSearch.Text = "Title Search:";
            // 
            // lstAvailableTitles
            // 
            lstAvailableTitles.FormattingEnabled = true;
            lstAvailableTitles.ItemHeight = 20;
            lstAvailableTitles.Location = new Point(150, 60);
            lstAvailableTitles.Name = "lstAvailableTitles";
            lstAvailableTitles.Size = new Size(300, 144);
            lstAvailableTitles.TabIndex = 2;
            // 
            // lblAvailableTitles
            // 
            lblAvailableTitles.AutoSize = true;
            lblAvailableTitles.Location = new Point(20, 63);
            lblAvailableTitles.Name = "lblAvailableTitles";
            lblAvailableTitles.Size = new Size(113, 20);
            lblAvailableTitles.TabIndex = 3;
            lblAvailableTitles.Text = "Available Titles:";
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(150, 210);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(100, 40);
            btnCheckOut.TabIndex = 4;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // CheckOutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 253);
            Controls.Add(btnCheckOut);
            Controls.Add(lblAvailableTitles);
            Controls.Add(lstAvailableTitles);
            Controls.Add(lblTitleSearch);
            Controls.Add(textBox1);
            Name = "CheckOutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Check Out Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label lblTitleSearch;
        private ListBox lstAvailableTitles;
        private Label lblAvailableTitles;
        private Button btnCheckOut;
    }
}