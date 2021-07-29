
namespace GymSystemDesktop.Views
{
    partial class Home
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imgUser = new System.Windows.Forms.PictureBox();
            this.txtNumeroUsuario = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtActividad = new System.Windows.Forms.TextBox();
            this.lblPlan = new System.Windows.Forms.Label();
            this.lblVigencia = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblStatusInicio = new System.Windows.Forms.Label();
            this.btnRenovar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgUser
            // 
            this.imgUser.Image = global::GymSystemDesktop.Properties.Resources.no_photo_available_icon_20;
            this.imgUser.Location = new System.Drawing.Point(33, 15);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(338, 346);
            this.imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUser.TabIndex = 0;
            this.imgUser.TabStop = false;
            // 
            // txtNumeroUsuario
            // 
            this.txtNumeroUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroUsuario.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumeroUsuario.Location = new System.Drawing.Point(33, 377);
            this.txtNumeroUsuario.Name = "txtNumeroUsuario";
            this.txtNumeroUsuario.Size = new System.Drawing.Size(220, 32);
            this.txtNumeroUsuario.TabIndex = 1;
            this.txtNumeroUsuario.TextChanged += new System.EventHandler(this.txtNumeroUsuario_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogin.Enabled = false;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Image = global::GymSystemDesktop.Properties.Resources.key_color_30px;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(259, 377);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(112, 42);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtActividad);
            this.panel1.Controls.Add(this.lblPlan);
            this.panel1.Controls.Add(this.lblVigencia);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Location = new System.Drawing.Point(406, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 346);
            this.panel1.TabIndex = 3;
            // 
            // txtActividad
            // 
            this.txtActividad.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtActividad.Location = new System.Drawing.Point(113, 192);
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.ReadOnly = true;
            this.txtActividad.Size = new System.Drawing.Size(340, 35);
            this.txtActividad.TabIndex = 8;
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlan.Location = new System.Drawing.Point(4, 192);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(103, 30);
            this.lblPlan.TabIndex = 7;
            this.lblPlan.Text = "Actividad";
            // 
            // lblVigencia
            // 
            this.lblVigencia.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVigencia.Location = new System.Drawing.Point(29, 297);
            this.lblVigencia.Name = "lblVigencia";
            this.lblVigencia.Size = new System.Drawing.Size(397, 33);
            this.lblVigencia.TabIndex = 6;
            this.lblVigencia.Text = "Vigencia hasta: 00/07/2021";
            this.lblVigencia.Visible = false;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtApellido.Location = new System.Drawing.Point(113, 127);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ReadOnly = true;
            this.txtApellido.Size = new System.Drawing.Size(340, 35);
            this.txtApellido.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Apellido";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(113, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(340, 35);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(14, 67);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(93, 30);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblStatusInicio
            // 
            this.lblStatusInicio.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatusInicio.Location = new System.Drawing.Point(33, 425);
            this.lblStatusInicio.Name = "lblStatusInicio";
            this.lblStatusInicio.Size = new System.Drawing.Size(338, 32);
            this.lblStatusInicio.TabIndex = 4;
            this.lblStatusInicio.Text = "label1";
            this.lblStatusInicio.Visible = false;
            // 
            // btnRenovar
            // 
            this.btnRenovar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRenovar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRenovar.Image = global::GymSystemDesktop.Properties.Resources.coins_40px;
            this.btnRenovar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRenovar.Location = new System.Drawing.Point(377, 377);
            this.btnRenovar.Name = "btnRenovar";
            this.btnRenovar.Size = new System.Drawing.Size(112, 42);
            this.btnRenovar.TabIndex = 5;
            this.btnRenovar.Text = "Renovar";
            this.btnRenovar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRenovar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRenovar.UseVisualStyleBackColor = false;
            this.btnRenovar.Visible = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnRenovar);
            this.Controls.Add(this.lblStatusInicio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtNumeroUsuario);
            this.Controls.Add(this.imgUser);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(908, 495);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgUser;
        private System.Windows.Forms.TextBox txtNumeroUsuario;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStatusInicio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVigencia;
        private System.Windows.Forms.TextBox txtActividad;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Button btnRenovar;
    }
}
