
namespace GymSystemDesktop.Views
{
    partial class Settings
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbOptions = new System.Windows.Forms.ListBox();
            this.lblTituloOpcion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbOptions
            // 
            this.lbOptions.FormattingEnabled = true;
            this.lbOptions.ItemHeight = 15;
            this.lbOptions.Items.AddRange(new object[] {
            "Diseño",
            "Planes",
            "Precios",
            "Promociones",
            "Usuarios",
            "General",
            "ADMINISTRADOR"});
            this.lbOptions.Location = new System.Drawing.Point(12, 12);
            this.lbOptions.Name = "lbOptions";
            this.lbOptions.Size = new System.Drawing.Size(250, 514);
            this.lbOptions.TabIndex = 0;
            this.lbOptions.SelectedValueChanged += new System.EventHandler(this.lbOptions_SelectedValueChanged);
            // 
            // lblTituloOpcion
            // 
            this.lblTituloOpcion.AutoSize = true;
            this.lblTituloOpcion.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloOpcion.Location = new System.Drawing.Point(596, 9);
            this.lblTituloOpcion.Name = "lblTituloOpcion";
            this.lblTituloOpcion.Size = new System.Drawing.Size(78, 30);
            this.lblTituloOpcion.TabIndex = 1;
            this.lblTituloOpcion.Text = "Diseño";
            this.lblTituloOpcion.Visible = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 547);
            this.Controls.Add(this.lblTituloOpcion);
            this.Controls.Add(this.lbOptions);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbOptions;
        private System.Windows.Forms.Label lblTituloOpcion;
    }
}