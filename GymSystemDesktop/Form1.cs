using GymSystemDesktop.DbConnection;
using GymSystemDesktop.Helpers;
using GymSystemDesktop.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymSystemDesktop
{
    public partial class MainWindow : Form
    {
        private List<Panel> panelsSelected;
        private List<Control> views;
        private DbConn conn = DbConn.GetInstance();
        Object lastObjectInScreen = new Object();


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        Point spawnPositionUserControl = new Point(220, 90);
        
        Home home;
        Registro registro;
        Usuariso usuarios;

        public MainWindow()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            panelsSelected = new List<Panel>();
            views = new List<Control>();

            registro = new Registro();
            home = new Home();
            usuarios = new Usuariso();

            FillPanelSelected();
            FillViews();

            home.Visible = true;

            lastObjectInScreen = home;


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

        private void FillPanelSelected()
        {
            panelsSelected.Add(panelRegistrarSelected);
            panelsSelected.Add(panelHomeSelected);
            panelsSelected.Add(panelUsuariosSelected);
        }

        private void FillViews()
        {
            views.Add(home);
            views.Add(registro);
            views.Add(usuarios);

            foreach(Control view in views)
            {
                view.Location = spawnPositionUserControl;
                view.TabIndex = 10;
                view.Visible = false;
                view.Size = new Size(1038, 660);
                view.BackColor = Color.Transparent;
                Controls.Add(view);
            }
        }

        private void HideSelectedPanel()
        {
            foreach(Panel panel in panelsSelected)
            {
                panel.Visible = false;
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
            HideSelectedPanel();

            ((Control)(lastObjectInScreen)).Visible = false;

            panelHomeSelected.Visible = true;
            lastObjectInScreen = home;
            home.Visible = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            HideSelectedPanel();
            ((Control)(lastObjectInScreen)).Visible = false;
            panelRegistrarSelected.Visible = true;
            lastObjectInScreen = registro;
            registro.Visible = true;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            HideSelectedPanel();
            ((Control)lastObjectInScreen).Visible = false;

            panelUsuariosSelected.Visible = true;
            lastObjectInScreen = usuarios;
            usuarios.Visible = true;
            usuarios.FillUsersTable();


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
                            foreach (Control panelS in panelsSelected)
                            {
                                panelS.BackColor = Color.FromArgb(255, R, G, B);
                            }

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
            SetColorsDesing();
        }
    }
}
