using GymSystemDesktop.DbConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymSystemDesktop.Views
{
    public partial class Usuariso : UserControl
    {

        DbConn conn;
        DataTable users;

        public Usuariso()
        {
            InitializeComponent();
            conn = DbConn.GetInstance();
        }

        private void Usuariso_Load(object sender, EventArgs e)
        {
            FillUsersTable();
            PaintTable();

        }


        private void FillUsersTable()
        {
            users = conn.ExecuteQuery("SELECT * FROM users");
            users.Columns.Remove("id");
            users.Columns.Remove("img");
            dgvUsers.DataSource = users;
        }

        private void PaintTable()
        {
            foreach(DataGridViewRow dgvr in dgvUsers.Rows)
            {
                dgvr.DefaultCellStyle.BackColor = Color.FromArgb(255, 41, 39, 40);
                dgvr.DefaultCellStyle.ForeColor = Color.White;
            }
        }

        private void dgvUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            PaintTable();
        }

        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {

   
            //dgvUsers.DataSource = usersFilter;
        }
    }
}
