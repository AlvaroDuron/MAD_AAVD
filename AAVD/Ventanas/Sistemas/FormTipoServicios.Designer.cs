
namespace AAVD
{
    partial class FormTipoServicios
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
            this.gbTiposServicio = new System.Windows.Forms.GroupBox();
            this.tbCuotaDrenaje = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTipoServicio = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.dgvTipoServicio = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbTiposServicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoServicio)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTiposServicio
            // 
            this.gbTiposServicio.Controls.Add(this.tbCuotaDrenaje);
            this.gbTiposServicio.Controls.Add(this.label2);
            this.gbTiposServicio.Controls.Add(this.label1);
            this.gbTiposServicio.Controls.Add(this.tbTipoServicio);
            this.gbTiposServicio.Location = new System.Drawing.Point(12, 12);
            this.gbTiposServicio.Name = "gbTiposServicio";
            this.gbTiposServicio.Size = new System.Drawing.Size(277, 158);
            this.gbTiposServicio.TabIndex = 13;
            this.gbTiposServicio.TabStop = false;
            this.gbTiposServicio.Text = "Informacion Tipos de servicio";
            // 
            // tbCuotaDrenaje
            // 
            this.tbCuotaDrenaje.Location = new System.Drawing.Point(97, 45);
            this.tbCuotaDrenaje.Name = "tbCuotaDrenaje";
            this.tbCuotaDrenaje.Size = new System.Drawing.Size(171, 20);
            this.tbCuotaDrenaje.TabIndex = 3;
            this.tbCuotaDrenaje.TextChanged += new System.EventHandler(this.tbNumeroZona_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cuota drenaje:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de servicio:";
            // 
            // tbTipoServicio
            // 
            this.tbTipoServicio.Location = new System.Drawing.Point(97, 19);
            this.tbTipoServicio.Name = "tbTipoServicio";
            this.tbTipoServicio.Size = new System.Drawing.Size(171, 20);
            this.tbTipoServicio.TabIndex = 1;
            this.tbTipoServicio.TextChanged += new System.EventHandler(this.tbMunicipio_TextChanged);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(295, 99);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 18;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // dgvTipoServicio
            // 
            this.dgvTipoServicio.AllowUserToAddRows = false;
            this.dgvTipoServicio.AllowUserToDeleteRows = false;
            this.dgvTipoServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoServicio.Location = new System.Drawing.Point(376, 12);
            this.dgvTipoServicio.Name = "dgvTipoServicio";
            this.dgvTipoServicio.ReadOnly = true;
            this.dgvTipoServicio.Size = new System.Drawing.Size(321, 158);
            this.dgvTipoServicio.TabIndex = 17;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(295, 70);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(295, 41);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(295, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // FormTipoServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 180);
            this.Controls.Add(this.gbTiposServicio);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dgvTipoServicio);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "FormTipoServicios";
            this.Text = "Tipos de servicio";
            this.gbTiposServicio.ResumeLayout(false);
            this.gbTiposServicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoServicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTiposServicio;
        private System.Windows.Forms.TextBox tbCuotaDrenaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTipoServicio;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridView dgvTipoServicio;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
    }
}