namespace Project_3
{
    partial class AddRoleToUserForm
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
            cmbRoleToAdd = new ComboBox();
            lblRoleToAdd = new Label();
            btnAddRole = new Button();
            SuspendLayout();
            // 
            // cmbUserSelection
            // 
            cmbUserSelection.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbUserSelection.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbUserSelection.FormattingEnabled = true;
            cmbUserSelection.Location = new Point(120, 50);
            cmbUserSelection.Name = "cmbUserSelection";
            cmbUserSelection.Size = new Size(200, 28);
            cmbUserSelection.TabIndex = 0;
            // 
            // lblUserSelection
            // 
            lblUserSelection.AutoSize = true;
            lblUserSelection.Location = new Point(20, 53);
            lblUserSelection.Name = "lblUserSelection";
            lblUserSelection.Size = new Size(85, 20);
            lblUserSelection.TabIndex = 1;
            lblUserSelection.Text = "Select User:";
            // 
            // cmbRoleToAdd
            // 
            cmbRoleToAdd.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoleToAdd.FormattingEnabled = true;
            cmbRoleToAdd.Location = new Point(120, 100);
            cmbRoleToAdd.Name = "cmbRoleToAdd";
            cmbRoleToAdd.Size = new Size(200, 28);
            cmbRoleToAdd.TabIndex = 2;
            // 
            // lblRoleToAdd
            // 
            lblRoleToAdd.AutoSize = true;
            lblRoleToAdd.Location = new Point(20, 103);
            lblRoleToAdd.Name = "lblRoleToAdd";
            lblRoleToAdd.Size = new Size(92, 20);
            lblRoleToAdd.TabIndex = 3;
            lblRoleToAdd.Text = "Role to Add:";
            // 
            // btnAddRole
            // 
            btnAddRole.Location = new Point(120, 150);
            btnAddRole.Name = "btnAddRole";
            btnAddRole.Size = new Size(200, 40);
            btnAddRole.TabIndex = 4;
            btnAddRole.Text = "Add Role";
            btnAddRole.UseVisualStyleBackColor = true;
            // 
            // AddRoleToUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 253);
            Controls.Add(btnAddRole);
            Controls.Add(lblRoleToAdd);
            Controls.Add(cmbRoleToAdd);
            Controls.Add(lblUserSelection);
            Controls.Add(cmbUserSelection);
            Name = "AddRoleToUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Assign Role to User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbUserSelection;
        private Label lblUserSelection;
        private ComboBox cmbRoleToAdd;
        private Label lblRoleToAdd;
        private Button btnAddRole;
    }
}