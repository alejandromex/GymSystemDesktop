using GymSystemDesktop.Models;
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

        public Registro()
        {
            InitializeComponent();
            FormControls.Add(txtNombreRegistro);
            FormControls.Add(txtApellidoRegistro);
            FormControls.Add(txtEdadRegistro);
            FormControls.Add(txtCelularRegistro);
            FormControls.Add(txtDireccionRegistro);
            FormControls.Add(txtMesesRegistro);
            FormControls.Add(cmbActividad);
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

        private void txtMesesRegistro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txtMesesRegistro.Text != "" &&int.Parse(txtMesesRegistro.Text) > 36)
                {
                    MessageBox.Show("No se permiten pagos adelantados mayores a 36 meses", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMesesRegistro.Text = "36";
                }
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
                    FechaInicio = DateTime.Now,
                    FechaFin = DateTime.Now.AddMonths(int.Parse(txtMesesRegistro.Text)),
                    Llave = TimeSpan.FromMilliseconds(DateTime.Now.Second).ToString(),
                    PlanRegistrado = cmbActividad.Text
                };


                MessageBox.Show(user.RegistrarUsuario().ToString());

                //if(user.RegistrarUsuario())
                //{
                //    MessageBox.Show("Registro exitoso");
                //}
                //else
                //{
                //    MessageBox.Show("Error al registrar al usuario");
                //}



                
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }



        }

        private void btnSeleccionarFoto_Click(object sender, EventArgs e)
        {

        }
    }
}
