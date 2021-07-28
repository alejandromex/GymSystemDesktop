
namespace GymSystemDesktop
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SideBar = new System.Windows.Forms.Panel();
            this.panelUsuariosSelected = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.panelRegistrarSelected = new System.Windows.Forms.Panel();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelHomeSelected = new System.Windows.Forms.Panel();
            this.NavbarDecoration = new System.Windows.Forms.Panel();
            this.panelNavBar = new System.Windows.Forms.Panel();
            this.lblNombreSucursal = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.imgLogoMain = new System.Windows.Forms.PictureBox();
            this.SideBar.SuspendLayout();
            this.panelNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoMain)).BeginInit();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.SideBar.Controls.Add(this.imgLogoMain);
            this.SideBar.Controls.Add(this.panelUsuariosSelected);
            this.SideBar.Controls.Add(this.btnUsuarios);
            this.SideBar.Controls.Add(this.panelRegistrarSelected);
            this.SideBar.Controls.Add(this.btnRegistrar);
            this.SideBar.Controls.Add(this.btnHome);
            this.SideBar.Controls.Add(this.panelHomeSelected);
            this.SideBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(200, 621);
            this.SideBar.TabIndex = 0;
            // 
            // panelUsuariosSelected
            // 
            this.panelUsuariosSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(10)))), ((int)(((byte)(55)))));
            this.panelUsuariosSelected.Location = new System.Drawing.Point(0, 291);
            this.panelUsuariosSelected.Name = "panelUsuariosSelected";
            this.panelUsuariosSelected.Size = new System.Drawing.Size(15, 62);
            this.panelUsuariosSelected.TabIndex = 5;
            this.panelUsuariosSelected.Visible = false;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = global::GymSystemDesktop.Properties.Resources.user_groups_26px;
            this.btnUsuarios.Location = new System.Drawing.Point(12, 291);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(179, 62);
            this.btnUsuarios.TabIndex = 6;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // panelRegistrarSelected
            // 
            this.panelRegistrarSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(10)))), ((int)(((byte)(55)))));
            this.panelRegistrarSelected.Location = new System.Drawing.Point(0, 214);
            this.panelRegistrarSelected.Name = "panelRegistrarSelected";
            this.panelRegistrarSelected.Size = new System.Drawing.Size(15, 62);
            this.panelRegistrarSelected.TabIndex = 4;
            this.panelRegistrarSelected.Visible = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Image = global::GymSystemDesktop.Properties.Resources.user_30px;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(12, 214);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(179, 62);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::GymSystemDesktop.Properties.Resources.home_white_50px;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 135);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(179, 62);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Inicio";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelHomeSelected
            // 
            this.panelHomeSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(10)))), ((int)(((byte)(55)))));
            this.panelHomeSelected.Location = new System.Drawing.Point(0, 135);
            this.panelHomeSelected.Name = "panelHomeSelected";
            this.panelHomeSelected.Size = new System.Drawing.Size(15, 62);
            this.panelHomeSelected.TabIndex = 3;
            // 
            // NavbarDecoration
            // 
            this.NavbarDecoration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(10)))), ((int)(((byte)(55)))));
            this.NavbarDecoration.Location = new System.Drawing.Point(200, 0);
            this.NavbarDecoration.Name = "NavbarDecoration";
            this.NavbarDecoration.Size = new System.Drawing.Size(954, 10);
            this.NavbarDecoration.TabIndex = 1;
            // 
            // panelNavBar
            // 
            this.panelNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.panelNavBar.Controls.Add(this.lblNombreSucursal);
            this.panelNavBar.Controls.Add(this.btnMinimize);
            this.panelNavBar.Controls.Add(this.pictureBox3);
            this.panelNavBar.Controls.Add(this.btnSettings);
            this.panelNavBar.Controls.Add(this.btnExit);
            this.panelNavBar.Location = new System.Drawing.Point(200, 10);
            this.panelNavBar.Name = "panelNavBar";
            this.panelNavBar.Size = new System.Drawing.Size(958, 50);
            this.panelNavBar.TabIndex = 2;
            this.panelNavBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNavBar_Paint);
            this.panelNavBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelNavBar_MouseDown);
            // 
            // lblNombreSucursal
            // 
            this.lblNombreSucursal.AutoSize = true;
            this.lblNombreSucursal.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreSucursal.Location = new System.Drawing.Point(0, 3);
            this.lblNombreSucursal.Name = "lblNombreSucursal";
            this.lblNombreSucursal.Size = new System.Drawing.Size(100, 40);
            this.lblNombreSucursal.TabIndex = 5;
            this.lblNombreSucursal.Text = "label1";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = global::GymSystemDesktop.Properties.Resources.minimize_window_32px1;
            this.btnMinimize.Location = new System.Drawing.Point(868, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GymSystemDesktop.Properties.Resources.bell_32px;
            this.pictureBox3.Location = new System.Drawing.Point(778, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // btnSettings
            // 
            this.btnSettings.Image = global::GymSystemDesktop.Properties.Resources.settings_32px;
            this.btnSettings.Location = new System.Drawing.Point(823, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(30, 30);
            this.btnSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSettings.TabIndex = 3;
            this.btnSettings.TabStop = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::GymSystemDesktop.Properties.Resources.power_off_button_50px;
            this.btnExit.Location = new System.Drawing.Point(913, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // imgLogoMain
            // 
            this.imgLogoMain.Location = new System.Drawing.Point(0, 0);
            this.imgLogoMain.Name = "imgLogoMain";
            this.imgLogoMain.Size = new System.Drawing.Size(200, 129);
            this.imgLogoMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogoMain.TabIndex = 7;
            this.imgLogoMain.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1155, 615);
            this.Controls.Add(this.panelNavBar);
            this.Controls.Add(this.NavbarDecoration);
            this.Controls.Add(this.SideBar);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.SideBar.ResumeLayout(false);
            this.panelNavBar.ResumeLayout(false);
            this.panelNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Panel NavbarDecoration;
        private System.Windows.Forms.Panel panelNavBar;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox btnSettings;
        private System.Windows.Forms.Panel panelHomeSelected;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelRegistrarSelected;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Panel panelUsuariosSelected;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.Label lblNombreSucursal;
        private System.Windows.Forms.PictureBox imgLogoMain;
    }
}

