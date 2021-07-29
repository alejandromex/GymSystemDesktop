using GymSystemDesktop.DbConnection;
using GymSystemDesktop.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace GymSystemDesktop
{
    public partial class Login : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        DbConn conn;

        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            conn = DbConn.GetInstance();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }


        private void MoveWindow(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveWindow(e);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario;
            string contrasena;

            usuario = txtUsuario.Text;
            contrasena = txtContrasena.Text;

            if(!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(contrasena))
            {
                DataTable userTb = conn.ExecuteQuery($"SELECT * FROM Sucursal WHERE nombre = '{usuario}' and contrasena = '{contrasena}'");
                if(userTb.Rows.Count > 0)
                {
                    DataRow user = userTb.Rows[0];
                    GlobalVariables.UserConnected = user;
                    GlobalVariables.UserIdConnected = int.Parse(user["id"].ToString());

                    MainWindow f = new MainWindow();
                    f.Show();
                    
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error, Revisar sus credenciales","Inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
