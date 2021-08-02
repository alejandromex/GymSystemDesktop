using GymSystemDesktop.DbConnection;
using GymSystemDesktop.Helpers;
using GymSystemDesktop.Models;
using GymSystemDesktop.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GymSystemDesktop.Views
{
    public partial class Registro : UserControl
    {
        List<Control> FormControls = new List<Control>();
        Dictionary<string, int> PricesActividades = new Dictionary<string, int>();
        string dirOfPicture = "";

        DbConn conn;
        public Registro()
        {
            InitializeComponent();
            FillActividadesCombo();
            if(cmbActividad.Items.Count == 0)
            {
                MessageBox.Show("Asigna planes en el boton de configuraciones");
            }
            else
            {
                cmbActividad.SelectedIndex = 0;
            }
            FormControls.Add(txtNombreRegistro);
            FormControls.Add(txtApellidoRegistro);
            FormControls.Add(txtEdadRegistro);
            FormControls.Add(txtCelularRegistro);
            FormControls.Add(txtDireccionRegistro);
            FormControls.Add(txtMesesRegistro);
            FormControls.Add(cmbActividad);

            conn = DbConn.GetInstance();
        }


        private bool ValidateControlForms()
        {
            foreach(Control c in FormControls)
            {
                if(c.Text == "")
                {
                    return false;
                }
            }
            return true;
        }

        private void txtMesesRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
               e.Handled = true;
            }
        }


        private void SetTotal()
        {

            if (cmbActividad.Text != "" && txtMesesRegistro.Text != "")
            {
                Dictionary<string, object> promotion = CheckIfExistsPromotion(cmbActividad.Text);
                int pagarPromotion = int.Parse(promotion["precio"].ToString());
                string comentario = promotion["comentario"].ToString();
                if(pagarPromotion > 0)
                {
                    lblTotal.Text = "Total: " + (int.Parse(txtMesesRegistro.Text) * pagarPromotion);
                    imgPromotionActive.Visible = true;
                    promotionToolTip.SetToolTip(imgPromotionActive, comentario);
                    promotionToolTip.ShowAlways = true;
                }
                else
                {
                    lblTotal.Text = "Total: " + (int.Parse(txtMesesRegistro.Text) * PricesActividades[cmbActividad.Text]).ToString();
                    imgPromotionActive.Visible = false;
                }
            }
            else
            {
                lblTotal.Text = "Total: 0";
            }
        }

        private void txtMesesRegistro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txtMesesRegistro.Text != "" &&int.Parse(txtMesesRegistro.Text) > 36)
                {
                    MessageBox.Show("No se permiten pagos adelantados mayores a 36 meses", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMesesRegistro.Text = "36";
                }

                SetTotal();
            }
            catch(Exception ex)
            {
                txtMesesRegistro.Text = "";
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {

            if(ValidateControlForms())
            {



                User user = new User()
                {
                    Nombre = txtNombreRegistro.Text,
                    Apellido = txtApellidoRegistro.Text,
                    Celular = txtCelularRegistro.Text,
                    Direccion = txtDireccionRegistro.Text,
                    Edad = int.Parse(txtEdadRegistro.Text),
                    FechaInicio = DateTime.Now.ToString("yyyy-MM-dd"),
                    FechaFin = DateTime.Now.AddMonths(int.Parse(txtMesesRegistro.Text)).ToString("yyyy-MM-dd"),
                    Llave = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds().ToString(),
                    PlanRegistrado = cmbActividad.Text,
                    Img = dirOfPicture
                };

                if(dirOfPicture == "")
                {
                    MessageBox.Show("Favor de tomar o seleccionar una foto", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if(user.RegistrarUsuario())
                {
                    MessageBox.Show("Registro exitoso, Tu clave identificadora es: "+user.Llave, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string movimiento = "Registro";
                    string tipo = "Incremento";
                    string comentarios = $"Se realizo registro de {user.Nombre} a la actividad {user.PlanRegistrado}";
                    string monto = (int.Parse(txtMesesRegistro.Text) * PricesActividades[cmbActividad.Text]).ToString();
                    string fecha = user.FechaInicio;
                    string atendio = "administrador";

                    string query = $"INSERT INTO movimientos values('{movimiento}', '{tipo}', '{comentarios}', {monto}, '{fecha}', '{atendio}', {GlobalVariables.UserIdConnected});";
                    conn.ExecuteQuery(query);
                    

                    btnCancelRegistro_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Error al registrar al usuario");
                }
                
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }



        }

        private Dictionary<string, object> CheckIfExistsPromotion(string actividad)
        {
            string query = $"SELECT * FROM promociones where nuevos = 1 and actividad = '{actividad}' order by meses";
            DataTable promociones = conn.ExecuteQuery(query);
            int precioPorMes = 0;
            string precioComentario = "";
            Dictionary<string, object> promotionActive = new Dictionary<string, object>();
            if(promociones.Rows.Count > 0)
            {
                int mesEscrito = int.Parse(txtMesesRegistro.Text);
                foreach(DataRow promocion in promociones.Rows)
                {
                    if(mesEscrito >= int.Parse(promocion[3].ToString()))
                    {
                        precioPorMes = int.Parse(promocion[4].ToString());
                        precioComentario = promocion[2].ToString();
                    }
                }

            }
            promotionActive["precio"] = precioPorMes;
            promotionActive["comentario"] = precioComentario;

            return promotionActive;
        }

        private void btnSeleccionarFoto_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "(*.png)|*.png|(*.jpg)|*.jpg";
                openFileDialog.RestoreDirectory = true;

                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    imgUserRegistro.Image = new Bitmap(filePath);
                    this.dirOfPicture = filePath;
                    
                }
            }
        }

        private void btnCancelRegistro_Click(object sender, EventArgs e)
        {
            txtNombreRegistro.Text = "";
            txtApellidoRegistro.Text = "";
            txtCelularRegistro.Text = "";
            txtDireccionRegistro.Text = "";
            txtEdadRegistro.Text = "";
            txtMesesRegistro.Text = "";
            cmbActividad.Text = "";
            imgUserRegistro.Image = Resources.no_photo_available_icon_20;
            dirOfPicture = "";
        }

        private void FillActividadesCombo()
        {
            DataTable dt = DbConn.GetInstance().ExecuteQuery("SELECT * FROM Actividades");
            if (dt.Rows.Count > 0)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    string nombre = dr["nombre"].ToString();
                    int precio = int.Parse(dr["precio"].ToString());
                    cmbActividad.Items.Add(nombre);
                    PricesActividades[nombre] = precio; 
                }
            }
        }

        private void cmbActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetTotal();

        }
    }
}
