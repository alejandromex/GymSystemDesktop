using GymSystemDesktop.DbConnection;
using GymSystemDesktop.Models;
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
        }


        public void FillUsersTable()
        {
            users = conn.ExecuteQuery("SELECT * FROM users");
            dgvUsers.DataSource = users;
            dgvUsers.Columns["id"].Visible = false;
            dgvUsers.Columns["img"].Visible = false;
            dgvUsers.Columns["idsucursal"].Visible = false;
            PaintTable();

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
            for (int i = 0; i < dgvUsers.Rows.Count - 1; i++)
            {
                DateTime fechaFin = Convert.ToDateTime(dgvUsers.Rows[i].Cells[6].Value.ToString().Split(" ")[0]);
                if (fechaFin <= DateTime.Now)
                {
                    dgvUsers.Rows[i].Cells[6].Style.BackColor = Color.Red;
                }
            }
        }

        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {
            (dgvUsers.DataSource as DataTable).DefaultView.RowFilter =    string.Format("Nombre LIKE '%{0}%' or Apellido LIKE '%{1}%'", txtBuscarUsuario.Text, txtBuscarUsuario.Text);

        }


        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if(indexRow == dgvUsers.Rows.Count-1 || indexRow == -1)
            {
                return;
            }
            string idUser = dgvUsers.Rows[indexRow].Cells[0].Value.ToString();

            InformationUser iUser = new InformationUser(idUser);
            iUser.Show();

        }
    }
}
