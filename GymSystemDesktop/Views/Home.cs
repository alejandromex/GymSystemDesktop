using GymSystemDesktop.DbConnection;
using GymSystemDesktop.Helpers;
using GymSystemDesktop.Properties;
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
                    DataTable userTable = sql.ExecuteQuery($"spSELECT_GetUserByClave {llave}, {GlobalVariables.UserIdConnected}");
                    if(userTable.Rows.Count > 0)
                    {
                        DataRow user = userTable.Rows[0];
                        string fechaInicialTexto = user["fechaFin"].ToString().Split(" ")[0];

                        DateTime fechaVigencia = Convert.ToDateTime(fechaInicialTexto);
                        if(DateTime.Now > fechaVigencia)
                        {
                            lblStatusInicio.ForeColor = Color.Black;
                            lblStatusInicio.BackColor = Color.Red;
                            lblStatusInicio.Text = "Vigencia vencida";
                            btnRenovar.Visible = true;
                        }
                        else
                        {
                            lblStatusInicio.ForeColor = Color.White;
                            lblStatusInicio.BackColor = Color.Green;
                            lblStatusInicio.Text = "Vigencia Correcta";

                        }

                        lblVigencia.Text = "Vigencia hasta el " + fechaVigencia.ToString("yyyy-MM-dd");
                        lblVigencia.Visible = true;

                        string nombre = user["nombre"].ToString();
                        string apellido = user["apellido"].ToString();
                        string actividad = user["planregistrado"].ToString();

                        txtNombre.Text = nombre;
                        txtApellido.Text = apellido;
                        txtActividad.Text = actividad;
                        if(File.Exists(user["img"].ToString()))
                        {
                            imgUser.Image = new Bitmap(user["img"].ToString());
                        }

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
                    RestarForm();
                    isTheRestarActive = false;
                }
            

            }
        }

        private void txtNumeroUsuario_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtNumeroUsuario.Text))
            {
                btnLogin.Enabled = true;
                if(isTheRestarActive)
                {
                    RestarForm();
                    isTheRestarActive = false;
                }
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void RestarForm()
        {
            btnLogin.Text = "Ingresar";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNumeroUsuario.Text = "";
            txtActividad.Text = "";
            lblStatusInicio.Visible = false;
            lblVigencia.Text = "";
            lblVigencia.Visible = false;
            btnRenovar.Visible = false;
            imgUser.Image = Resources.no_photo_available_icon_20;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
