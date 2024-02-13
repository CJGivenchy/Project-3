namespace Project_3
{
    partial class DeleteRoleForm
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
            cmbUserSelection = new ComboBox();
            lblUserSelection = new Label();
            cmbRoleToDelete = new ComboBox();
            lblRoleToDelete = new Label();
            btnDeleteRole = new Button();
            SuspendLayout();
            // 
            // cmbUserSelection
            // 
            cmbUserSelection.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbUserSelection.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbUserSelection.FormattingEnabled = true;
            cmbUserSelection.Location = new Point(120, 20);
            cmbUserSelection.Name = "cmbUserSelection";
            cmbUserSelection.Size = new Size(200, 28);
            cmbUserSelection.TabIndex = 0;
            // 
            // lblUserSelection
            // 
            lblUserSelection.AutoSize = true;
            lblUserSelection.Location = new Point(20, 23);
            lblUserSelection.Name = "lblUserSelection";
            lblUserSelection.Size = new Size(85, 20);
            lblUserSelection.TabIndex = 1;
            lblUserSelection.Text = "Select User:";
            // 
            // cmbRoleToDelete
            // 
            cmbRoleToDelete.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoleToDelete.FormattingEnabled = true;
            cmbRoleToDelete.Location = new Point(120, 50);
            cmbRoleToDelete.Name = "cmbRoleToDelete";
            cmbRoleToDelete.Size = new Size(200, 28);
            cmbRoleToDelete.TabIndex = 2;
            // 
            // lblRoleToDelete
            // 
            lblRoleToDelete.AutoSize = true;
            lblRoleToDelete.Location = new Point(6, 53);
            lblRoleToDelete.Name = "lblRoleToDelete";
            lblRoleToDelete.Size = new Size(108, 20);
            lblRoleToDelete.TabIndex = 3;
            lblRoleToDelete.Text = "Role to Delete:";
            // 
            // btnDeleteRole
            // 
            btnDeleteRole.Location = new Point(120, 140);
            btnDeleteRole.Name = "btnDeleteRole";
            btnDeleteRole.Size = new Size(200, 40);
            btnDeleteRole.TabIndex = 4;
            btnDeleteRole.Text = "Delete Role";
            btnDeleteRole.UseVisualStyleBackColor = true;
            // 
            // DeleteRoleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 203);
            Controls.Add(btnDeleteRole);
            Controls.Add(lblRoleToDelete);
            Controls.Add(cmbRoleToDelete);
            Controls.Add(lblUserSelection);
            Controls.Add(cmbUserSelection);
            Name = "DeleteRoleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delete User Role";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbUserSelection;
        private Label lblUserSelection;
        private ComboBox cmbRoleToDelete;
        private Label lblRoleToDelete;
        private Button btnDeleteRole;
    }
}
