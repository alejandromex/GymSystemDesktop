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
    public partial class Promociones : UserControl
    {
        DbConn conn;
        DataTable actividades;
        DataTable usuarios;
        DataTable promociones;
        public Promociones()
        {
            InitializeComponent();
            conn = DbConn.GetInstance();
        }

        private void Promociones_Load(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM actividades Where idsucursal = {GlobalVariables.UserIdConnected}";
            actividades = conn.ExecuteQuery(query);
            if(actividades.Rows.Count > 0)
            {
                foreach(DataRow actividad in actividades.Rows)
                {
                    cmbActividades.Items.Add(actividad["nombre"].ToString());
                }
            }

            query = $"SELECT * FROM users WHERE idsucursal = {GlobalVariables.UserIdConnected}";
            usuarios = conn.ExecuteQuery(query);
            cmbPersonas.Items.Add("Todos");
            if(usuarios.Rows.Count > 0)
            {
                foreach(DataRow usuario in usuarios.Rows)
                {
                    cmbPersonas.Items.Add(usuario["nombre"].ToString() + " " +usuario["apellido"].ToString()  + " | " + usuario["id"].ToString());
                }
            }
            FillTable();
            
        }

        private void FillTable()
        {
            string query = $"SELECT * FROM promociones WHERE idSucursal = {GlobalVariables.UserIdConnected}";
            promociones = conn.ExecuteQuery(query);
            if (promociones.Rows.Count > 0)
            {
                dgvPromotions.DataSource = promociones;
                dgvPromotions.Columns.Remove("id");
                dgvPromotions.Columns.Remove("idSucursal");
                dgvPromotions.Columns.Remove("idUsuario");
            }
        }

        private void btnGuardarPromo_Click(object sender, EventArgs e)
        {
            if(cmbActividades.Text != "" && cmbPersonas.Text != "" && txtComentario.Text != "" && txtMeses.Text != "" && txtPrecio.Text != "" && dtpFechaExp.Text != "")
            {
                string actividad = cmbActividades.Text;
                string persona = cmbPersonas.Text;
                string comentario = txtComentario.Text;
                int meses = int.Parse(txtMeses.Text);
                int precio = int.Parse(txtPrecio.Text);
                DateTime fechaExp = Convert.ToDateTime(dtpFechaExp.Value);
                int idSucursal = GlobalVariables.UserIdConnected;
                int idUsuario = -1;
                int nuevos = 0;
                if(persona != "Todos")
                {
                    idUsuario = int.Parse(persona.Split('|')[1].Trim());
                }

                if(cbNuevosClientes.Checked)
                {
                    nuevos = 1;
                }

                conn.ExecuteSp("spINSERT_CreateANewPromotion", new object[] { actividad, comentario, meses, precio, nuevos, fechaExp.ToString("yyyy-MM-dd"), idUsuario, idSucursal });
                MessageBox.Show("Promocion registrada correctamente", "Promociones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbActividades.Text = "";
                cmbPersonas.Text = "";
                txtComentario.Text = "";
                txtMeses.Text = "";
                txtPrecio.Text = "";
                idSucursal = -1;
                idUsuario = -1;
                cbNuevosClientes.Checked = false;
                FillTable();
            }
        }
    }
}
