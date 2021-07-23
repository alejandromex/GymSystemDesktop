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
    public partial class Form1 : Form
    {

        private List<Panel> panelsSelected;
        private List<Control> views;
        Object lastObjectInScreen = new Object();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        Point spawnPositionUserControl = new Point(206, 66);
        
        Home home;
        Registro registro;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            panelsSelected = new List<Panel>();
            views = new List<Control>();

            registro = new Registro();
            home = new Home();

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
        }

        private void FillViews()
        {
            views.Add(home);
            views.Add(registro);

            foreach(Control view in views)
            {
                view.Location = spawnPositionUserControl;
                view.TabIndex = 10;
                view.Visible = false;
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
    }
}
