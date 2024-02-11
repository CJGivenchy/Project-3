namespace Project_3
{
    partial class AdminForm
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
            btnAddUser = new Button();
            btnDeleteUserRole = new Button();
            btnAddRoleToUser = new Button();
            SuspendLayout();
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(50, 50);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(120, 40);
            btnAddUser.TabIndex = 0;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUserRole
            // 
            btnDeleteUserRole.Location = new Point(50, 100);
            btnDeleteUserRole.Name = "btnDeleteUserRole";
            btnDeleteUserRole.Size = new Size(120, 40);
            btnDeleteUserRole.TabIndex = 1;
            btnDeleteUserRole.Text = "Delete User Role";
            btnDeleteUserRole.UseVisualStyleBackColor = true;
            // 
            // btnAddRoleToUser
            // 
            btnAddRoleToUser.Location = new Point(50, 150);
            btnAddRoleToUser.Name = "btnAddRoleToUser";
            btnAddRoleToUser.Size = new Size(144, 40);
            btnAddRoleToUser.TabIndex = 2;
            btnAddRoleToUser.Text = "Add Role to User";
            btnAddRoleToUser.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 253);
            Controls.Add(btnAddRoleToUser);
            Controls.Add(btnDeleteUserRole);
            Controls.Add(btnAddUser);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddUser;
        private Button btnDeleteUserRole;
        private Button btnAddRoleToUser;
    }
}