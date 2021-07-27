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

        Diseño diseño;
        List<Control> views;
        Object lastViewInScreen;
        Point spawnPositionViews = new Point(270, 40);

        public Settings()
        {
            InitializeComponent();
            views = new List<Control>();
            diseño = new Diseño();

            views.Add(diseño);

            SetViews();
        }

        private void SetViews()
        {
            foreach(Control view in views)
            {
                view.Visible = false;
                view.Location = spawnPositionViews;
                view.BackColor = Color.FromArgb(225,224, 224, 224);
                Controls.Add(view);
            }

            Controls.Add(diseño);
        }

        private void lbOptions_SelectedValueChanged(object sender, EventArgs e)
        {


            if(lbOptions.SelectedItem.ToString() == "Diseño")
            {
                lastViewInScreen = diseño;
                diseño.Visible = true;
                lblTituloOpcion.Text = "Diseño";
                lblTituloOpcion.Visible = true;
            }
            else
            {
                ((Control)(lastViewInScreen)).Visible = false;
            }

        }
    }
}
