using GymSystemDesktop.DbConnection;
using GymSystemDesktop.Helpers;
using GymSystemDesktop.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymSystemDesktop
{
    public partial class MainWindow : Form
    {
        private DbConn conn = DbConn.GetInstance();
        Object lastObjectInScreen = new Object();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        Point spawnPositionUserControl = new Point(220, 90);
        public MainWindow()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }


        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelNavBar_MouseDown(object sender, MouseEventArgs e)
        {
            MoveWindow(e);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Controls.Remove((Control)lastObjectInScreen);
            Home home = new Home();
            lastObjectInScreen = home;
            home.Location = spawnPositionUserControl;
            Controls.Add(home);
            panelHomeSelected.Location = new Point(0, btnHome.Location.Y);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Controls.Remove((Control)lastObjectInScreen);
            Registro registro = new Registro();
            lastObjectInScreen = registro;
            registro.Location = spawnPositionUserControl;
            Controls.Add(registro);
            panelHomeSelected.Location = new Point(0, btnRegistrar.Location.Y);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Controls.Remove((Control)lastObjectInScreen);
            Usuariso usuariso = new Usuariso();
            lastObjectInScreen = usuariso;
            usuariso.Location = spawnPositionUserControl;
            Controls.Add(usuariso);
            panelHomeSelected.Location = new Point(0, btnUsuarios.Location.Y);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FormCollection forms = Application.OpenForms;
            bool openForm = true;
            foreach(Form f in forms)
            {
                
                if(f.Name == "Settings")
                {
                    openForm = false;
                }
            }

            if(openForm)
            {
                Settings settings = new Settings();
                settings.Show();
            }
        }

        public void SetColorsDesing()
        {
            DataTable colors = conn.ExecuteQuery("SELECT * FROM Diseño");
            int R, G, B;
            if (colors.Rows.Count > 0)
            {
                DataRow colorRow = colors.Rows[0];
                foreach (DataColumn colorsColumn in colors.Columns)
                {
                    if (colorsColumn.ColumnName.Contains("Color"))
                    {
                        string[] colorsSplit = colorRow[colorsColumn].ToString().Split(",");

                        R = int.Parse(colorsSplit[0]);
                        G = int.Parse(colorsSplit[1]);
                        B = int.Parse(colorsSplit[2]);

                        if (colorsColumn.ColumnName == "Color1")
                        {
                            SideBar.BackColor = Color.FromArgb(255, R, G, B);
                            GlobalVariables.rSidebar = R;
                            GlobalVariables.gSidebar = G;
                            GlobalVariables.bSidebar = B;

                            btnHome.BackColor = Color.FromArgb(255, R, G, B);
                            btnRegistrar.BackColor = Color.FromArgb(255, R, G, B);
                            btnUsuarios.BackColor = Color.FromArgb(255, R, G, B);
                        }

                        if (colorsColumn.ColumnName == "Color2")
                        {
                            NavbarDecoration.BackColor = Color.FromArgb(255, R, G, B);
                            panelHomeSelected.BackColor = Color.FromArgb(255, R, G, B); 

                            GlobalVariables.rDecoration = R;
                            GlobalVariables.bDecoration = B;
                            GlobalVariables.gDecoration = G;
                        }

                        if (colorsColumn.ColumnName == "Color3")
                        {
                            panelNavBar.BackColor = Color.FromArgb(255, R, G, B);

                            GlobalVariables.rMenuTop = R;
                            GlobalVariables.bMenuTop = B;
                            GlobalVariables.gMenuTop = G;
                        }

                        if (colorsColumn.ColumnName == "Color4")
                        {
                            this.BackColor = Color.FromArgb(255, R, G, B);
                            GlobalVariables.rFondo = R;
                            GlobalVariables.bFondo = B;
                            GlobalVariables.gFondo = G;
                        }
                    }

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Location = spawnPositionUserControl;
            lastObjectInScreen = home;
            panelHomeSelected.Location = new Point(0,btnHome.Location.Y);
            Controls.Add(home);

            lblNombreSucursal.Text = GlobalVariables.UserConnected["nombre"].ToString();
            if(File.Exists(GlobalVariables.UserConnected["img"].ToString()))
            {
                imgLogoMain.Image = new Bitmap(GlobalVariables.UserConnected["img"].ToString());
            }
            SetColorsDesing();
        }

        private void panelNavBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
