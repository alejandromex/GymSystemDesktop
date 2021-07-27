using GymSystemDesktop.DbConnection;
using GymSystemDesktop.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GymSystemDesktop.Views.SettingsOptions
{
    public partial class Diseño : UserControl
    {

        DbConn conn;
        int r, g, b, rDecoration, gDecoration, bDecoration, rMenuTop, gMenuTop, bMenuTop, rFondo, gFondo, bFondo;
        public Diseño()
        {
            InitializeComponent();
            conn = DbConn.GetInstance();
        }

        private void txtSideBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnColorSideBar_Click(object sender, EventArgs e)
        {
            sideBarColor.ShowDialog();


            r = sideBarColor.Color.R;
            g = sideBarColor.Color.G;
            b = sideBarColor.Color.B;

            txtR.Text = sideBarColor.Color.R.ToString();
            txtG.Text = sideBarColor.Color.G.ToString();
            txtB.Text = sideBarColor.Color.B.ToString();

            txtSideBar.BackColor = sideBarColor.Color;
        }

        private void ErrorColor()
        {
            MessageBox.Show("Numeracion de colores 0 - 255", "Colores", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }





        //SIDEBAR
        private void ChangeColorText()
        {
            try
            {
                if(txtB.Text == "" || txtG.Text == "" || txtR.Text == "")
                {
                    return;
                }
                r = int.Parse(txtR.Text.ToString());

                if(r > 255 || r < 0)
                {
                    txtR.Text = "255";
                    r = 255;
                    ErrorColor();
                }

                g = int.Parse(txtG.Text.ToString());
                if (g > 255 || g < 0)
                {
                    txtG.Text = "255";
                    g = 255;
                    ErrorColor();
                }

                b = int.Parse(txtB.Text.ToString());
                if(b > 255 || b < 0)
                {
                    txtB.Text = "255";
                    b = 255;
                    ErrorColor();
                }

                txtSideBar.BackColor = Color.FromArgb(255, r, g, b);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void txtR_TextChanged(object sender, EventArgs e)
        {
            ChangeColorText();
        }

        private void btnColorFondo_Click(object sender, EventArgs e)
        {

            sideBarColor.ShowDialog();


            rFondo = sideBarColor.Color.R;
            gFondo = sideBarColor.Color.G;
            bFondo = sideBarColor.Color.B;

            txtRFondo.Text = sideBarColor.Color.R.ToString();
            txtGFondo.Text = sideBarColor.Color.G.ToString();
            txtBFondo.Text = sideBarColor.Color.B.ToString();

            txtColorFondo.BackColor = sideBarColor.Color;
        }

        private void txtG_TextChanged(object sender, EventArgs e)
        {
            ChangeColorText();
        }
        private void txtB_TextChanged(object sender, EventArgs e)
        {
            ChangeColorText();
        }

        private void txtRMenuTop_TextChanged(object sender, EventArgs e)
        {
            ChangeColorTopMenu();
        }

        private void txtGMenuTop_TextChanged(object sender, EventArgs e)
        {
            ChangeColorTopMenu();
        }

        private void txtBMenuTop_TextChanged(object sender, EventArgs e)
        {
            ChangeColorTopMenu();
        }

        private void txtRFondo_TextChanged(object sender, EventArgs e)
        {
            ChangeColorFondo();
        }

        private void txtGFondo_TextChanged(object sender, EventArgs e)
        {
            ChangeColorFondo();
        }

        private void txtBFondo_TextChanged(object sender, EventArgs e)
        {
            ChangeColorFondo();
        }


        // DECORACION
        private void ChanceColorTextDecoration()
        {
            try
            {
                if (txtBDecoracion.Text == "" || txtGDecoracion.Text == "" || txtRDecoracion.Text == "")
                {
                    return;
                }
                rDecoration = int.Parse(txtRDecoracion.Text.ToString());

                if (rDecoration > 255 || rDecoration < 0)
                {
                    txtRDecoracion.Text = "255";
                    rDecoration = 255;
                    ErrorColor();
                }

                gDecoration = int.Parse(txtGDecoracion.Text.ToString());
                if (gDecoration > 255 || gDecoration < 0)
                {
                    txtGDecoracion.Text = "255";
                    gDecoration = 255;
                    ErrorColor();
                }

                bDecoration = int.Parse(txtBDecoracion.Text.ToString());
                if (bDecoration > 255 || bDecoration < 0)
                {
                    txtBDecoracion.Text = "255";
                    bDecoration = 255;
                    ErrorColor();
                }

                txtColorDecoracion.BackColor = Color.FromArgb(255, rDecoration, gDecoration, bDecoration);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ChangeColorTopMenu()
        {
            try
            {
                if (txtBMenuTop.Text == "" || txtGMenuTop.Text == "" || txtRMenuTop.Text == "")
                {
                    return;
                }
                rMenuTop = int.Parse(txtRMenuTop.Text.ToString());

                if (rMenuTop > 255 || rMenuTop < 0)
                {
                    txtRMenuTop.Text = "255";
                    rMenuTop = 255;
                    ErrorColor();
                }

                gMenuTop = int.Parse(txtGMenuTop.Text.ToString());
                if (gMenuTop > 255 || gMenuTop < 0)
                {
                    txtGMenuTop.Text = "255";
                    gMenuTop = 255;
                    ErrorColor();
                }

                bMenuTop = int.Parse(txtBMenuTop.Text.ToString());
                if (bMenuTop > 255 || bMenuTop < 0)
                {
                    txtBMenuTop.Text = "255";
                    bMenuTop = 255;
                    ErrorColor();
                }

                txtColorMenuTop.BackColor = Color.FromArgb(255, rMenuTop, gMenuTop, bMenuTop);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ChangeColorFondo()
        {
            try
            {
                if (txtBFondo.Text == "" || txtGFondo.Text == "" || txtRFondo.Text == "")
                {
                    return;
                }
                rFondo = int.Parse(txtRFondo.Text.ToString());

                if (rFondo > 255 || rFondo < 0)
                {
                    txtRFondo.Text = "255";
                    rFondo = 255;
                    ErrorColor();
                }

                gFondo = int.Parse(txtGFondo.Text.ToString());
                if (gFondo > 255 || gFondo < 0)
                {
                    txtGFondo.Text = "255";
                    gFondo = 255;
                    ErrorColor();
                }

                bFondo = int.Parse(txtBFondo.Text.ToString());
                if (bFondo > 255 || bFondo < 0)
                {
                    txtBFondo.Text = "255";
                    bFondo = 255;
                    ErrorColor();
                }

                txtColorFondo.BackColor = Color.FromArgb(255, rFondo, gFondo, bFondo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtRDecoracion_TextChanged(object sender, EventArgs e)
        {
            ChanceColorTextDecoration();
        }

        private void txtGDecoracion_TextChanged(object sender, EventArgs e)
        {
            ChanceColorTextDecoration();
        }

        private void txtBDecoracion_TextChanged(object sender, EventArgs e)
        {
            ChanceColorTextDecoration();
        }

        //MENU TOP
        private void btnColorMenuTop_Click(object sender, EventArgs e)
        {
            sideBarColor.ShowDialog();


            rMenuTop = sideBarColor.Color.R;
            gMenuTop = sideBarColor.Color.G;
            bMenuTop = sideBarColor.Color.B;

            txtRMenuTop.Text = sideBarColor.Color.R.ToString();
            txtGMenuTop.Text = sideBarColor.Color.G.ToString();
            txtBMenuTop.Text = sideBarColor.Color.B.ToString();

            txtColorMenuTop.BackColor = sideBarColor.Color;
        }




        private void Diseño_Load(object sender, EventArgs e)
        {
            SetColors();
        }

        private void btnColorDecoracion_Click(object sender, EventArgs e)
        {
            sideBarColor.ShowDialog();


            rDecoration = sideBarColor.Color.R;
            gDecoration = sideBarColor.Color.G;
            bDecoration = sideBarColor.Color.B;

            txtRDecoracion.Text = sideBarColor.Color.R.ToString();
            txtGDecoracion.Text = sideBarColor.Color.G.ToString();
            txtBDecoracion.Text = sideBarColor.Color.B.ToString();

            txtColorDecoracion.BackColor = sideBarColor.Color;
        }

        private void SetColors()
        {
            txtB.Text = GlobalVariables.bSidebar.ToString();
            txtG.Text = GlobalVariables.gSidebar.ToString();
            txtR.Text = GlobalVariables.rSidebar.ToString();

            txtBDecoracion.Text = GlobalVariables.bDecoration.ToString();
            txtGDecoracion.Text = GlobalVariables.gDecoration.ToString();
            txtRDecoracion.Text = GlobalVariables.rDecoration.ToString();

            txtBMenuTop.Text = GlobalVariables.bMenuTop.ToString();
            txtGMenuTop.Text = GlobalVariables.gMenuTop.ToString();
            txtRMenuTop.Text = GlobalVariables.rMenuTop.ToString();

            txtBFondo.Text = GlobalVariables.bFondo.ToString();
            txtGFondo.Text = GlobalVariables.gFondo.ToString();
            txtRFondo.Text = GlobalVariables.rFondo.ToString();

            textos.Add(txtBDecoracion);
            textos.Add(txtRDecoracion);
            textos.Add(txtGDecoracion);

            textos.Add(txtBMenuTop);
            textos.Add(txtRMenuTop);
            textos.Add(txtGMenuTop);

            textos.Add(txtBFondo);
            textos.Add(txtRFondo);
            textos.Add(txtGFondo);

            textos.Add(txtB);
            textos.Add(txtG);
            textos.Add(txtR);

            ChangeColorText();
            ChanceColorTextDecoration();
            ChangeColorFondo();
            ChangeColorTopMenu();

        }

        List<Object> textos = new List<Object>();
        private void btnSaveDesing_Click(object sender, EventArgs e)
        {

            foreach(Object texto in textos)
            {
                if( ((Control)texto).Text == "" )
                {
                    MessageBox.Show("Los colores no pueden tener campos vacios", "Colores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string query = $"UPDATE Diseño SET Color1 = '{r},{g},{b}', Color2 = '{rDecoration},{gDecoration},{bDecoration}', Color3 = '{rMenuTop},{gMenuTop},{bMenuTop}', Color4 = '{rFondo},{gFondo},{bFondo}' WHERE id = 1";
            conn.ExecuteQuery(query);

            
        }
    }
}
