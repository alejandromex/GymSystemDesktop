using GymSystemDesktop.DbConnection;
using GymSystemDesktop.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GymSystemDesktop.Views.SettingsOptions
{
    public partial class Planes : UserControl
    {

        DbConn conn;
        DataTable planes;
        int idSeleccionado;
        public Planes()
        {
            InitializeComponent();
            conn = DbConn.GetInstance();
        }

        private void Planes_Load(object sender, EventArgs e)
        {
            FillTable();
        }

        private void FillTable()
        {
            planes = conn.ExecuteQuery("SELECT * FROM Actividades");
            dgvPlanes.DataSource = planes;
            dgvPlanes.Columns[0].Visible = false;
            dgvPlanes.Columns[dgvPlanes.Columns.Count - 1].Visible = false;
            dgvPlanes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPlanes.ColumnHeadersDefaultCellStyle.Font.Name.ToUpper();
            dgvPlanes.AllowUserToAddRows = false;
        }

        private void dgvPlanes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPlanes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dgvPlanes[0, e.RowIndex].Value.ToString());
            string nombre = dgvPlanes[1, e.RowIndex].Value.ToString();
            string precio = dgvPlanes[2, e.RowIndex].Value.ToString();

            string query = $"UPDATE Actividades SET nombre = '{nombre}', precio = {precio} where id = {id}";
            conn.ExecuteQuery(query);

        }

        private void dgvPlanes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == -1)
            {
                return;
            }
            idSeleccionado = int.Parse(dgvPlanes[0, e.RowIndex].Value.ToString());
            lblPlanSeleccionado.Text = dgvPlanes[1, e.RowIndex].Value.ToString();

        }

        private void btnEliminarPlan_Click(object sender, EventArgs e)
        {
            if(lblPlanSeleccionado.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show($"Estas seguro de eliminar el plan {lblPlanSeleccionado.Text}", "Eliminar plan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dialogResult == DialogResult.Yes)
                {
                    string query = $"DELETE FROM Actividades WHERE id = {idSeleccionado}";
                    conn.ExecuteQuery(query);
                    FillTable();
                }
            }
        }

        private void btnAgregarPlan_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string precio = txtPrecio.Text;

            if(!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(precio))
            {
                string query = $"INSERT INTO Actividades values('{nombre}', {precio}, {GlobalVariables.UserIdConnected})";
                conn.ExecuteQuery(query);
                FillTable();
            }
            
        }
    }
}
