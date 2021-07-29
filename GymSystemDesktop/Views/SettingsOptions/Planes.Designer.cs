
namespace GymSystemDesktop.Views.SettingsOptions
{
    partial class Planes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPlanes = new System.Windows.Forms.DataGridView();
            this.btnEliminarPlan = new System.Windows.Forms.Button();
            this.lblPlanSeleccionado = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarPlan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlanes
            // 
            this.dgvPlanes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPlanes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlanes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanes.Location = new System.Drawing.Point(32, 82);
            this.dgvPlanes.Name = "dgvPlanes";
            this.dgvPlanes.RowHeadersWidth = 10;
            this.dgvPlanes.RowTemplate.Height = 25;
            this.dgvPlanes.Size = new System.Drawing.Size(618, 384);
            this.dgvPlanes.TabIndex = 0;
            this.dgvPlanes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlanes_CellClick);
            this.dgvPlanes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlanes_CellContentClick);
            this.dgvPlanes.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlanes_CellEndEdit);
            // 
            // btnEliminarPlan
            // 
            this.btnEliminarPlan.BackColor = System.Drawing.Color.Red;
            this.btnEliminarPlan.FlatAppearance.BorderSize = 0;
            this.btnEliminarPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPlan.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarPlan.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPlan.Location = new System.Drawing.Point(462, 48);
            this.btnEliminarPlan.Name = "btnEliminarPlan";
            this.btnEliminarPlan.Size = new System.Drawing.Size(82, 28);
            this.btnEliminarPlan.TabIndex = 1;
            this.btnEliminarPlan.Text = "Eliminar";
            this.btnEliminarPlan.UseVisualStyleBackColor = false;
            this.btnEliminarPlan.Click += new System.EventHandler(this.btnEliminarPlan_Click);
            // 
            // lblPlanSeleccionado
            // 
            this.lblPlanSeleccionado.AutoSize = true;
            this.lblPlanSeleccionado.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlanSeleccionado.Location = new System.Drawing.Point(550, 54);
            this.lblPlanSeleccionado.Name = "lblPlanSeleccionado";
            this.lblPlanSeleccionado.Size = new System.Drawing.Size(0, 17);
            this.lblPlanSeleccionado.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(32, 53);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(142, 23);
            this.txtNombre.TabIndex = 3;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(194, 53);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(142, 23);
            this.txtPrecio.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Precio";
            // 
            // btnAgregarPlan
            // 
            this.btnAgregarPlan.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAgregarPlan.FlatAppearance.BorderSize = 0;
            this.btnAgregarPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPlan.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarPlan.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPlan.Location = new System.Drawing.Point(342, 48);
            this.btnAgregarPlan.Name = "btnAgregarPlan";
            this.btnAgregarPlan.Size = new System.Drawing.Size(82, 28);
            this.btnAgregarPlan.TabIndex = 7;
            this.btnAgregarPlan.Text = "Agregar";
            this.btnAgregarPlan.UseVisualStyleBackColor = false;
            this.btnAgregarPlan.Click += new System.EventHandler(this.btnAgregarPlan_Click);
            // 
            // Planes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.btnAgregarPlan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblPlanSeleccionado);
            this.Controls.Add(this.btnEliminarPlan);
            this.Controls.Add(this.dgvPlanes);
            this.Name = "Planes";
            this.Size = new System.Drawing.Size(681, 490);
            this.Load += new System.EventHandler(this.Planes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlanes;
        private System.Windows.Forms.Button btnEliminarPlan;
        private System.Windows.Forms.Label lblPlanSeleccionado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarPlan;
    }
}
