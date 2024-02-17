namespace Project3
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
            btnAddRoleToUser = new Button();
            btnDeleteUserRole = new Button();
            SuspendLayout();
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(100, 70);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(200, 40);
            btnAddUser.TabIndex = 0;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += BtnAddUser_Click;
            // 
            // btnAddRoleToUser
            // 
            btnAddRoleToUser.Location = new Point(100, 162);
            btnAddRoleToUser.Name = "btnAddRoleToUser";
            btnAddRoleToUser.Size = new Size(200, 40);
            btnAddRoleToUser.TabIndex = 1;
            btnAddRoleToUser.Text = "Add Role to User";
            btnAddRoleToUser.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUserRole
            // 
            btnDeleteUserRole.Location = new Point(100, 116);
            btnDeleteUserRole.Name = "btnDeleteUserRole";
            btnDeleteUserRole.Size = new Size(200, 40);
            btnDeleteUserRole.TabIndex = 2;
            btnDeleteUserRole.Text = "Delete User Role";
            btnDeleteUserRole.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 253);
            Controls.Add(btnDeleteUserRole);
            Controls.Add(btnAddRoleToUser);
            Controls.Add(btnAddUser);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddUser;
        private Button btnAddRoleToUser;
        private Button btnDeleteUserRole;
    }
}
