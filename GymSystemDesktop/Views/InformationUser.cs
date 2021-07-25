using GymSystemDesktop.DbConnection;
using GymSystemDesktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GymSystemDesktop.Views
{
    public partial class InformationUser : Form
    {
        DbConn sql = DbConn.GetInstance();
        User user = new User();


        public InformationUser()
        {
            InitializeComponent();
        }

        public InformationUser(string userId)
        {

            InitializeComponent();
            GetUserInformation(userId);
        }

        private void GetUserInformation(string userId)
        {
            DataTable userDt = sql.ExecuteQuery($"SELECT * FROM users WHERE id = {userId}");
            foreach(DataRow dr in userDt.Rows)
            {
                user.Apellido = dr["apellido"].ToString();
                user.Nombre = dr["nombre"].ToString();
                user.Img = dr["img"].ToString();
                user.Llave = dr["llave"].ToString();
                user.Edad = int.Parse(dr["edad"].ToString());
                user.FechaInicio = dr["fechainicio"].ToString().Split(" ")[0];
                user.FechaFin = dr["fechafin"].ToString().Split(" ")[0];
                user.PlanRegistrado = dr["planregistrado"].ToString();
                user.Direccion = dr["direccion"].ToString();
                user.Celular = dr["celular"].ToString();
            }

        }

        private void InformationUser_Load(object sender, EventArgs e)
        {
            if(File.Exists(user.Img))
            {
                imgUserDetail.Image = new Bitmap(user.Img);
            }
            else
            {
                MessageBox.Show("La imagen de usuario no existe o su ubicacion cambio", "Imagen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtNombre.Text = user.Nombre;
            txtApellido.Text = user.Apellido;
            txtEdad.Text = user.Edad.ToString();
            txtCelular.Text = user.Celular;
            txtDireccion.Text = user.Direccion;
            txtFechaF.Text = user.FechaFin;
            txtFechaI.Text = user.FechaInicio;
            txtLlave.Text = user.Llave;
            txtPlan.Text = user.PlanRegistrado;
        }

        private void imgUserDetail_Click(object sender, EventArgs e)
        {

        }
    }
}
