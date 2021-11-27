
namespace AAVD
{
    partial class FormMunicipio
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbZonas = new System.Windows.Forms.GroupBox();
            this.tbNumeroZona = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.dgvMunicipio = new System.Windows.Forms.DataGridView();
            this.numeroZona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbZonas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMunicipio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(295, 99);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 18;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(295, 70);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(295, 41);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(295, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gbZonas
            // 
            this.gbZonas.Controls.Add(this.tbNumeroZona);
            this.gbZonas.Controls.Add(this.label2);
            this.gbZonas.Controls.Add(this.label1);
            this.gbZonas.Controls.Add(this.tbNombre);
            this.gbZonas.Location = new System.Drawing.Point(12, 12);
            this.gbZonas.Name = "gbZonas";
            this.gbZonas.Size = new System.Drawing.Size(277, 158);
            this.gbZonas.TabIndex = 13;
            this.gbZonas.TabStop = false;
            this.gbZonas.Text = "Informacion Municipio";
            // 
            // tbNumeroZona
            // 
            this.tbNumeroZona.Location = new System.Drawing.Point(122, 45);
            this.tbNumeroZona.Name = "tbNumeroZona";
            this.tbNumeroZona.Size = new System.Drawing.Size(149, 20);
            this.tbNumeroZona.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero de Zona:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Municipio:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(122, 19);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(149, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // dgvMunicipio
            // 
            this.dgvMunicipio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMunicipio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroZona,
            this.municipio,
            this.nombre});
            this.dgvMunicipio.Location = new System.Drawing.Point(384, 12);
            this.dgvMunicipio.Name = "dgvMunicipio";
            this.dgvMunicipio.Size = new System.Drawing.Size(240, 158);
            this.dgvMunicipio.TabIndex = 19;
            // 
            // numeroZona
            // 
            this.numeroZona.DataPropertyName = "numeroZona";
            this.numeroZona.HeaderText = "Numero de Zona";
            this.numeroZona.Name = "numeroZona";
            this.numeroZona.ReadOnly = true;
            // 
            // municipio
            // 
            this.municipio.DataPropertyName = "municipio";
            this.municipio.HeaderText = "Municipio";
            this.municipio.Name = "municipio";
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Zona";
            this.nombre.Name = "nombre";
            // 
            // FormMunicipio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 191);
            this.Controls.Add(this.dgvMunicipio);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbZonas);
            this.Name = "FormMunicipio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Municipios";
            this.Load += new System.EventHandler(this.FormMunicipio_Load);
            this.gbZonas.ResumeLayout(false);
            this.gbZonas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMunicipio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gbZonas;
        private System.Windows.Forms.TextBox tbNumeroZona;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.DataGridView dgvMunicipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroZona;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
    }
}