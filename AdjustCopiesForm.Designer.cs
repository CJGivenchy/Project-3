namespace Project3
{
    partial class AdjustCopiesForm
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
            cmbBookSearch = new ComboBox();
            numTotalCopies = new NumericUpDown();
            btnAdjustCopies = new Button();
            lblBookSearch = new Label();
            lblTotalCopies = new Label();
            ((System.ComponentModel.ISupportInitialize)numTotalCopies).BeginInit();
            SuspendLayout();
            // 
            // cmbBookSearch
            // 
            cmbBookSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbBookSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbBookSearch.FormattingEnabled = true;
            cmbBookSearch.Location = new Point(150, 30);
            cmbBookSearch.Name = "cmbBookSearch";
            cmbBookSearch.Size = new Size(200, 28);
            cmbBookSearch.TabIndex = 0;
            // 
            // numTotalCopies
            // 
            numTotalCopies.Location = new Point(150, 70);
            numTotalCopies.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            numTotalCopies.Name = "numTotalCopies";
            numTotalCopies.Size = new Size(200, 27);
            numTotalCopies.TabIndex = 1;
            // 
            // btnAdjustCopies
            // 
            btnAdjustCopies.Location = new Point(150, 110);
            btnAdjustCopies.Name = "btnAdjustCopies";
            btnAdjustCopies.Size = new Size(200, 40);
            btnAdjustCopies.TabIndex = 2;
            btnAdjustCopies.Text = "Adjust Copies";
            btnAdjustCopies.UseVisualStyleBackColor = true;
            // 
            // lblBookSearch
            // 
            lblBookSearch.AutoSize = true;
            lblBookSearch.Location = new Point(20, 33);
            lblBookSearch.Name = "lblBookSearch";
            lblBookSearch.Size = new Size(94, 20);
            lblBookSearch.TabIndex = 3;
            lblBookSearch.Text = "Book Search:";
            // 
            // lblTotalCopies
            // 
            lblTotalCopies.AutoSize = true;
            lblTotalCopies.Location = new Point(20, 73);
            lblTotalCopies.Name = "lblTotalCopies";
            lblTotalCopies.Size = new Size(94, 20);
            lblTotalCopies.TabIndex = 4;
            lblTotalCopies.Text = "Total Copies:";
            // 
            // AdjustCopiesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 203);
            Controls.Add(lblTotalCopies);
            Controls.Add(lblBookSearch);
            Controls.Add(btnAdjustCopies);
            Controls.Add(numTotalCopies);
            Controls.Add(cmbBookSearch);
            Name = "AdjustCopiesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adjust Book Copies";
            ((System.ComponentModel.ISupportInitialize)numTotalCopies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBookSearch;
        private NumericUpDown numTotalCopies;
        private Button btnAdjustCopies;
        private Label lblBookSearch;
        private Label lblTotalCopies;
    }
}
