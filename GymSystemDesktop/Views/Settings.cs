using GymSystemDesktop.Views.SettingsOptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GymSystemDesktop.Views
{
    public partial class Settings : Form
    {

        Object lastViewInScreen;
        Point spawnPositionViews = new Point(270, 40);

        public Settings()
        {
            InitializeComponent();

        }


        private void lbOptions_SelectedValueChanged(object sender, EventArgs e)
        {


            if(lbOptions.SelectedItem.ToString() == "Diseño")
            {
                lblTituloOpcion.Text = "Diseño";
                Controls.Remove((Control)lastViewInScreen);
                Diseño diseño = new Diseño();
                diseño.Location = spawnPositionViews;
                lastViewInScreen = diseño;
                Controls.Add(diseño);
            }
            else if(lbOptions.SelectedIndex == 1)
            {
                lblTituloOpcion.Text = "Planes";
                Controls.Remove((Control)lastViewInScreen);
                Planes planes = new Planes();
                planes.Location = spawnPositionViews;
                lastViewInScreen = planes;
                Controls.Add(planes);
            }
            else if(lbOptions.SelectedIndex == 2)
            {
                lblTituloOpcion.Text = "Promociones";
                Controls.Remove((Control)lastViewInScreen);
                Promociones promociones = new Promociones();
                promociones.Location = spawnPositionViews;
                lastViewInScreen = promociones;
                Controls.Add(promociones);
            }
            else if(lbOptions.SelectedIndex == 3)
            {
                lblTituloOpcion.Text = "Tienda";
                Controls.Remove((Control)lastViewInScreen);
                Tienda tienda = new Tienda();
                tienda.Location = spawnPositionViews;
                lastViewInScreen = tienda;
                Controls.Add(tienda);
            }

        }

        private void Settings_Load(object sender, EventArgs e)
        {
            lblTituloOpcion.Text = "Diseño";
            Diseño diseño = new Diseño();
            diseño.Location = spawnPositionViews;
            lastViewInScreen = diseño;
            Controls.Add(diseño);
        }
    }
}
