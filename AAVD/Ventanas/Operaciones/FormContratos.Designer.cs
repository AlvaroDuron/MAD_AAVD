
namespace AAVD
{
    partial class FormContratos
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
            this.dgvContrato = new System.Windows.Forms.DataGridView();
            this.numeroContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroMedidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroExterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAltaMod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bEliminar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.rbClientesFisicos = new System.Windows.Forms.RadioButton();
            this.rbClientesMorales = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTipoServicio = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContrato)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvContrato
            // 
            this.dgvContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContrato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroContrato,
            this.numeroMedidor,
            this.categoria,
            this.tipoServicio,
            this.numeroExterior,
            this.calle,
            this.colonia,
            this.municipio,
            this.estado,
            this.creacion,
            this.fechaAltaMod});
            this.dgvContrato.Location = new System.Drawing.Point(27, 144);
            this.dgvContrato.Name = "dgvContrato";
            this.dgvContrato.Size = new System.Drawing.Size(667, 249);
            this.dgvContrato.TabIndex = 0;
            // 
            // numeroContrato
            // 
            this.numeroContrato.DataPropertyName = "numeroContrato";
            this.numeroContrato.HeaderText = "Numero de Contrato";
            this.numeroContrato.Name = "numeroContrato";
            // 
            // numeroMedidor
            // 
            this.numeroMedidor.DataPropertyName = "numeroMedidor";
            this.numeroMedidor.HeaderText = "Numero de Medidor";
            this.numeroMedidor.Name = "numeroMedidor";
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "categoria";
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            // 
            // tipoServicio
            // 
            this.tipoServicio.DataPropertyName = "tipoServicio";
            this.tipoServicio.HeaderText = "Tipo de Servicio";
            this.tipoServicio.Name = "tipoServicio";
            // 
            // numeroExterior
            // 
            this.numeroExterior.DataPropertyName = "numeroExterior";
            this.numeroExterior.HeaderText = "Numero Exterior";
            this.numeroExterior.Name = "numeroExterior";
            // 
            // calle
            // 
            this.calle.DataPropertyName = "calle";
            this.calle.HeaderText = "Calle";
            this.calle.Name = "calle";
            // 
            // colonia
            // 
            this.colonia.DataPropertyName = "colonia";
            this.colonia.HeaderText = "Colonia";
            this.colonia.Name = "colonia";
            // 
            // municipio
            // 
            this.municipio.DataPropertyName = "municipio";
            this.municipio.HeaderText = "Municipio";
            this.municipio.Name = "municipio";
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // creacion
            // 
            this.creacion.DataPropertyName = "creacion";
            this.creacion.HeaderText = "Fecha de Creacion";
            this.creacion.Name = "creacion";
            // 
            // fechaAltaMod
            // 
            this.fechaAltaMod.DataPropertyName = "fechaAltaMod";
            this.fechaAltaMod.HeaderText = "Fecha de Modificacion";
            this.fechaAltaMod.Name = "fechaAltaMod";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo de Servicio:";
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(619, 78);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(75, 23);
            this.bEliminar.TabIndex = 5;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(619, 107);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 6;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // bModificar
            // 
            this.bModificar.Location = new System.Drawing.Point(619, 48);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(75, 23);
            this.bModificar.TabIndex = 8;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(619, 19);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(75, 23);
            this.bAgregar.TabIndex = 7;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(226, 45);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(121, 21);
            this.cbCliente.TabIndex = 9;
            // 
            // rbClientesFisicos
            // 
            this.rbClientesFisicos.AutoSize = true;
            this.rbClientesFisicos.Checked = true;
            this.rbClientesFisicos.Location = new System.Drawing.Point(17, 38);
            this.rbClientesFisicos.Name = "rbClientesFisicos";
            this.rbClientesFisicos.Size = new System.Drawing.Size(97, 17);
            this.rbClientesFisicos.TabIndex = 0;
            this.rbClientesFisicos.TabStop = true;
            this.rbClientesFisicos.Text = "Clientes Fisicos";
            this.rbClientesFisicos.UseVisualStyleBackColor = true;
            this.rbClientesFisicos.Click += new System.EventHandler(this.rbClientesFisicos_Click);
            // 
            // rbClientesMorales
            // 
            this.rbClientesMorales.AutoSize = true;
            this.rbClientesMorales.Location = new System.Drawing.Point(17, 61);
            this.rbClientesMorales.Name = "rbClientesMorales";
            this.rbClientesMorales.Size = new System.Drawing.Size(102, 17);
            this.rbClientesMorales.TabIndex = 1;
            this.rbClientesMorales.Text = "Clientes Morales";
            this.rbClientesMorales.UseVisualStyleBackColor = true;
            this.rbClientesMorales.Click += new System.EventHandler(this.rbClientesMorales_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTipoServicio);
            this.groupBox1.Controls.Add(this.rbClientesMorales);
            this.groupBox1.Controls.Add(this.cbCliente);
            this.groupBox1.Controls.Add(this.rbClientesFisicos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 90);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // cbTipoServicio
            // 
            this.cbTipoServicio.FormattingEnabled = true;
            this.cbTipoServicio.Location = new System.Drawing.Point(226, 15);
            this.cbTipoServicio.Name = "cbTipoServicio";
            this.cbTipoServicio.Size = new System.Drawing.Size(121, 21);
            this.cbTipoServicio.TabIndex = 10;
            // 
            // FormContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 420);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.dgvContrato);
            this.Name = "FormContratos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contratos";
            this.Load += new System.EventHandler(this.FormContratos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContrato)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContrato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.RadioButton rbClientesFisicos;
        private System.Windows.Forms.RadioButton rbClientesMorales;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroMedidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroExterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonia;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn creacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAltaMod;
        private System.Windows.Forms.ComboBox cbTipoServicio;
    }
}