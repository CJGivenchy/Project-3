using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Project3
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            AttachEventHandlers();
        }

        private void AttachEventHandlers()
        {
            this.btnAddUser.Click += new EventHandler(BtnAddUser_Click);
            this.btnDeleteUserRole.Click += new EventHandler(BtnDeleteUserRole_Click);
            this.btnAddRoleToUser.Click += new EventHandler(BtnAddRoleToUser_Click);
        }

        private void BtnAddUser_Click(object? sender, EventArgs e) // Adjusted for nullability
        {
            AddUserForm addUserForm = new();
            addUserForm.ShowDialog();
        }

        private void BtnDeleteUserRole_Click(object? sender, EventArgs e) // Adjusted for nullability
        {
            DeleteRoleForm deleteRoleForm = new();
            deleteRoleForm.ShowDialog();
        }

        private void BtnAddRoleToUser_Click(object? sender, EventArgs e) // Adjusted for nullability
        {
            AddRoleToUserForm addRoleToUserForm = new();
            addRoleToUserForm.ShowDialog();
        }
    }
}
