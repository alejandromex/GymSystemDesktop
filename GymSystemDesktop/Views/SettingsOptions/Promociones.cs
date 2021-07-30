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

            query = $"SELECT * FROM promociones WHERE id = {GlobalVariables.UserIdConnected}";
            promociones = conn.ExecuteQuery(query);
            if(promociones.Rows.Count > 0)
            {
                dgvPromotions.DataSource = promociones;
                dgvPromotions.Columns.Remove("id");
                dgvPromotions.Columns.Remove("idSucursal");
                dgvPromotions.Columns.Remove("idUsuario");
            }
        }
    }
}
