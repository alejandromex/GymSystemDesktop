
namespace GymSystemDesktop.Views.SettingsOptions
{
    partial class Promociones
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
            this.cmbActividades = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPersonas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.cbNuevosClientes = new System.Windows.Forms.CheckBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPromotions = new System.Windows.Forms.DataGridView();
            this.btnGuardarPromo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaExp = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromotions)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbActividades
            // 
            this.cmbActividades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActividades.FormattingEnabled = true;
            this.cmbActividades.Location = new System.Drawing.Point(129, 48);
            this.cmbActividades.Name = "cmbActividades";
            this.cmbActividades.Size = new System.Drawing.Size(438, 23);
            this.cmbActividades.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Persona:";
            // 
            // cmbPersonas
            // 
            this.cmbPersonas.FormattingEnabled = true;
            this.cmbPersonas.Location = new System.Drawing.Point(211, 93);
            this.cmbPersonas.Name = "cmbPersonas";
            this.cmbPersonas.Size = new System.Drawing.Size(356, 23);
            this.cmbPersonas.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Meses";
            // 
            // txtMeses
            // 
            this.txtMeses.Location = new System.Drawing.Point(211, 174);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(141, 23);
            this.txtMeses.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Comentario";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(211, 136);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(356, 23);
            this.txtComentario.TabIndex = 6;
            // 
            // cbNuevosClientes
            // 
            this.cbNuevosClientes.AutoSize = true;
            this.cbNuevosClientes.Location = new System.Drawing.Point(425, 248);
            this.cbNuevosClientes.Name = "cbNuevosClientes";
            this.cbNuevosClientes.Size = new System.Drawing.Size(142, 19);
            this.cbNuevosClientes.TabIndex = 7;
            this.cbNuevosClientes.Text = "Solo a clientes nuevos";
            this.cbNuevosClientes.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(426, 174);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(141, 23);
            this.txtPrecio.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Precio";
            // 
            // dgvPromotions
            // 
            this.dgvPromotions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromotions.Location = new System.Drawing.Point(129, 278);
            this.dgvPromotions.Name = "dgvPromotions";
            this.dgvPromotions.RowTemplate.Height = 25;
            this.dgvPromotions.Size = new System.Drawing.Size(438, 194);
            this.dgvPromotions.TabIndex = 10;
            // 
            // btnGuardarPromo
            // 
            this.btnGuardarPromo.Location = new System.Drawing.Point(129, 240);
            this.btnGuardarPromo.Name = "btnGuardarPromo";
            this.btnGuardarPromo.Size = new System.Drawing.Size(118, 32);
            this.btnGuardarPromo.TabIndex = 11;
            this.btnGuardarPromo.Text = "Guardar Promo.";
            this.btnGuardarPromo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha de expiracion";
            // 
            // dtpFechaExp
            // 
            this.dtpFechaExp.Location = new System.Drawing.Point(247, 210);
            this.dtpFechaExp.Name = "dtpFechaExp";
            this.dtpFechaExp.Size = new System.Drawing.Size(320, 23);
            this.dtpFechaExp.TabIndex = 13;
            // 
            // Promociones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.dtpFechaExp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGuardarPromo);
            this.Controls.Add(this.dgvPromotions);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbNuevosClientes);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMeses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPersonas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbActividades);
            this.Name = "Promociones";
            this.Size = new System.Drawing.Size(681, 490);
            this.Load += new System.EventHandler(this.Promociones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromotions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbActividades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPersonas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMeses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.CheckBox cbNuevosClientes;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPromotions;
        private System.Windows.Forms.Button btnGuardarPromo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaExp;
    }
}
