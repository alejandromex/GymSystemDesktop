
namespace GymSystemDesktop.Views
{
    partial class Registro
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreRegistro = new System.Windows.Forms.TextBox();
            this.txtApellidoRegistro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEdadRegistro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMesesRegistro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbActividad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDireccionRegistro = new System.Windows.Forms.TextBox();
            this.txtCelularRegistro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.imgUserRegistro = new System.Windows.Forms.PictureBox();
            this.btnSeleccionarFoto = new System.Windows.Forms.Button();
            this.btnTomarFoto = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnCancelRegistro = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.imgPromotionActive = new System.Windows.Forms.PictureBox();
            this.promotionToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cbEstudiante = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgUserRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPromotionActive)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(99, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombreRegistro
            // 
            this.txtNombreRegistro.Location = new System.Drawing.Point(219, 88);
            this.txtNombreRegistro.Name = "txtNombreRegistro";
            this.txtNombreRegistro.Size = new System.Drawing.Size(252, 23);
            this.txtNombreRegistro.TabIndex = 1;
            // 
            // txtApellidoRegistro
            // 
            this.txtApellidoRegistro.Location = new System.Drawing.Point(219, 128);
            this.txtApellidoRegistro.Name = "txtApellidoRegistro";
            this.txtApellidoRegistro.Size = new System.Drawing.Size(252, 23);
            this.txtApellidoRegistro.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(97, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // txtEdadRegistro
            // 
            this.txtEdadRegistro.Location = new System.Drawing.Point(219, 165);
            this.txtEdadRegistro.Name = "txtEdadRegistro";
            this.txtEdadRegistro.Size = new System.Drawing.Size(252, 23);
            this.txtEdadRegistro.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(132, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Edad";
            // 
            // txtMesesRegistro
            // 
            this.txtMesesRegistro.Location = new System.Drawing.Point(219, 325);
            this.txtMesesRegistro.Name = "txtMesesRegistro";
            this.txtMesesRegistro.Size = new System.Drawing.Size(100, 23);
            this.txtMesesRegistro.TabIndex = 7;
            this.txtMesesRegistro.TextChanged += new System.EventHandler(this.txtMesesRegistro_TextChanged);
            this.txtMesesRegistro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMesesRegistro_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(119, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Meses";
            // 
            // cmbActividad
            // 
            this.cmbActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActividad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbActividad.FormattingEnabled = true;
            this.cmbActividad.Location = new System.Drawing.Point(219, 287);
            this.cmbActividad.Name = "cmbActividad";
            this.cmbActividad.Size = new System.Drawing.Size(252, 25);
            this.cmbActividad.Sorted = true;
            this.cmbActividad.TabIndex = 6;
            this.cmbActividad.SelectedIndexChanged += new System.EventHandler(this.cmbActividad_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(87, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Actividad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(86, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(111, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Celular";
            // 
            // txtDireccionRegistro
            // 
            this.txtDireccionRegistro.Location = new System.Drawing.Point(219, 243);
            this.txtDireccionRegistro.Name = "txtDireccionRegistro";
            this.txtDireccionRegistro.Size = new System.Drawing.Size(252, 23);
            this.txtDireccionRegistro.TabIndex = 5;
            // 
            // txtCelularRegistro
            // 
            this.txtCelularRegistro.Location = new System.Drawing.Point(219, 203);
            this.txtCelularRegistro.Name = "txtCelularRegistro";
            this.txtCelularRegistro.Size = new System.Drawing.Size(252, 23);
            this.txtCelularRegistro.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(232, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(447, 50);
            this.label8.TabIndex = 14;
            this.label8.Text = "Registrar Nuevo Usuario";
            // 
            // imgUserRegistro
            // 
            this.imgUserRegistro.Image = global::GymSystemDesktop.Properties.Resources.no_photo_available_icon_20;
            this.imgUserRegistro.Location = new System.Drawing.Point(532, 73);
            this.imgUserRegistro.Name = "imgUserRegistro";
            this.imgUserRegistro.Size = new System.Drawing.Size(309, 275);
            this.imgUserRegistro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUserRegistro.TabIndex = 15;
            this.imgUserRegistro.TabStop = false;
            // 
            // btnSeleccionarFoto
            // 
            this.btnSeleccionarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeleccionarFoto.Image = global::GymSystemDesktop.Properties.Resources.file_explorer_48px;
            this.btnSeleccionarFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionarFoto.Location = new System.Drawing.Point(612, 354);
            this.btnSeleccionarFoto.Name = "btnSeleccionarFoto";
            this.btnSeleccionarFoto.Size = new System.Drawing.Size(156, 54);
            this.btnSeleccionarFoto.TabIndex = 8;
            this.btnSeleccionarFoto.Text = "Seleccionar Foto";
            this.btnSeleccionarFoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeleccionarFoto.UseVisualStyleBackColor = true;
            this.btnSeleccionarFoto.Click += new System.EventHandler(this.btnSeleccionarFoto_Click);
            // 
            // btnTomarFoto
            // 
            this.btnTomarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTomarFoto.Image = global::GymSystemDesktop.Properties.Resources.cameras_48px;
            this.btnTomarFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTomarFoto.Location = new System.Drawing.Point(612, 426);
            this.btnTomarFoto.Name = "btnTomarFoto";
            this.btnTomarFoto.Size = new System.Drawing.Size(156, 54);
            this.btnTomarFoto.TabIndex = 9;
            this.btnTomarFoto.Text = "Tomar Foto";
            this.btnTomarFoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTomarFoto.UseVisualStyleBackColor = true;
            // 
            // btnRegistro
            // 
            this.btnRegistro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.btnRegistro.FlatAppearance.BorderSize = 2;
            this.btnRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(129)))), ((int)(((byte)(255)))));
            this.btnRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnRegistro.Location = new System.Drawing.Point(147, 385);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(126, 45);
            this.btnRegistro.TabIndex = 10;
            this.btnRegistro.Text = "Registrar";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnCancelRegistro
            // 
            this.btnCancelRegistro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(10)))), ((int)(((byte)(55)))));
            this.btnCancelRegistro.FlatAppearance.BorderSize = 2;
            this.btnCancelRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnCancelRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelRegistro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnCancelRegistro.Location = new System.Drawing.Point(329, 385);
            this.btnCancelRegistro.Name = "btnCancelRegistro";
            this.btnCancelRegistro.Size = new System.Drawing.Size(126, 45);
            this.btnCancelRegistro.TabIndex = 19;
            this.btnCancelRegistro.Text = "Cancelar";
            this.btnCancelRegistro.UseVisualStyleBackColor = true;
            this.btnCancelRegistro.Click += new System.EventHandler(this.btnCancelRegistro_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(325, 319);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(65, 30);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "Total:";
            // 
            // imgPromotionActive
            // 
            this.imgPromotionActive.Image = global::GymSystemDesktop.Properties.Resources.goal_24px;
            this.imgPromotionActive.Location = new System.Drawing.Point(483, 324);
            this.imgPromotionActive.Name = "imgPromotionActive";
            this.imgPromotionActive.Size = new System.Drawing.Size(30, 24);
            this.imgPromotionActive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPromotionActive.TabIndex = 21;
            this.imgPromotionActive.TabStop = false;
            this.imgPromotionActive.Visible = false;
            // 
            // cbEstudiante
            // 
            this.cbEstudiante.AutoSize = true;
            this.cbEstudiante.Location = new System.Drawing.Point(219, 354);
            this.cbEstudiante.Name = "cbEstudiante";
            this.cbEstudiante.Size = new System.Drawing.Size(81, 19);
            this.cbEstudiante.TabIndex = 22;
            this.cbEstudiante.Text = "Estudiante";
            this.cbEstudiante.UseVisualStyleBackColor = true;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cbEstudiante);
            this.Controls.Add(this.imgPromotionActive);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCancelRegistro);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.btnTomarFoto);
            this.Controls.Add(this.btnSeleccionarFoto);
            this.Controls.Add(this.imgUserRegistro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCelularRegistro);
            this.Controls.Add(this.txtDireccionRegistro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbActividad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMesesRegistro);
            this.Controls.Add(this.txtEdadRegistro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellidoRegistro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreRegistro);
            this.Controls.Add(this.label1);
            this.Name = "Registro";
            this.Size = new System.Drawing.Size(908, 495);
            ((System.ComponentModel.ISupportInitialize)(this.imgUserRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPromotionActive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreRegistro;
        private System.Windows.Forms.TextBox txtApellidoRegistro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEdadRegistro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMesesRegistro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbActividad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDireccionRegistro;
        private System.Windows.Forms.TextBox txtCelularRegistro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox imgUserRegistro;
        private System.Windows.Forms.Button btnSeleccionarFoto;
        private System.Windows.Forms.Button btnTomarFoto;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnCancelRegistro;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.PictureBox imgPromotionActive;
        private System.Windows.Forms.ToolTip promotionToolTip;
        private System.Windows.Forms.CheckBox cbEstudiante;
    }
}
