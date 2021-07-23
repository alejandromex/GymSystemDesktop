using GymSystemDesktop.DbConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GymSystemDesktop.Views
{
    public partial class Home : UserControl
    {

        DbConn sql;
        private bool isTheRestarActive;


        public Home()
        {
            InitializeComponent();
            sql = DbConn.GetInstance();
            isTheRestarActive = false;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblStatusInicio.TextAlign = ContentAlignment.MiddleCenter;

            if(txtNumeroUsuario.Text == "")
            {
                MessageBox.Show("El campo idetificador de usuarios no puede estar vacio","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(!isTheRestarActive)
                {
                    lblStatusInicio.Visible = true;
                    string llave = txtNumeroUsuario.Text;
                    DataTable userTable = sql.ExecuteQuery($"spSELECT_GetUserByClave {llave}");
                    if(userTable.Rows.Count > 0)
                    {
                        lblStatusInicio.ForeColor = Color.White;
                        lblStatusInicio.BackColor = Color.Green;
                        lblStatusInicio.Text = "Vigencia Correcta";

                        DataRow user = userTable.Rows[0];

                        string nombre = user["nombre"].ToString();
                        string apellido = user["apellido"].ToString();
                        string edad = user["edad"].ToString();

                        txtNombre.Text = nombre;
                        txtApellido.Text = apellido;
                        txtEdad.Text = edad;

                        isTheRestarActive = true;
                        btnLogin.Text = "Reiniciar";
                    }
                    else
                    {
                        lblStatusInicio.ForeColor = Color.Black;
                        lblStatusInicio.BackColor = Color.Orange;
                        lblStatusInicio.Text = "Usuario no registrado";
                    }

                }
                else
                {
                    btnLogin.Text = "Ingresar";
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtEdad.Text = "";
                    txtNumeroUsuario.Text = "";
                    lblStatusInicio.Visible = false;

                    isTheRestarActive = false;
                }
            

            }
        }

        private void txtNumeroUsuario_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtNumeroUsuario.Text))
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }
    }
}
