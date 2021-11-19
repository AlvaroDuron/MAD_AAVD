
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
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTipoServicio = new System.Windows.Forms.TextBox();
            this.bEliminar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.numeroContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroMedidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContrato)).BeginInit();
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
            this.estatus,
            this.municipio,
            this.domicilio,
            this.creacion,
            this.modificacion});
            this.dgvContrato.Location = new System.Drawing.Point(27, 92);
            this.dgvContrato.Name = "dgvContrato";
            this.dgvContrato.Size = new System.Drawing.Size(667, 249);
            this.dgvContrato.TabIndex = 0;
            // 
            // tbCliente
            // 
            this.tbCliente.Location = new System.Drawing.Point(243, 44);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(100, 20);
            this.tbCliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo de Servicio:";
            // 
            // tbTipoServicio
            // 
            this.tbTipoServicio.Location = new System.Drawing.Point(487, 44);
            this.tbTipoServicio.Name = "tbTipoServicio";
            this.tbTipoServicio.Size = new System.Drawing.Size(100, 20);
            this.tbTipoServicio.TabIndex = 3;
            this.tbTipoServicio.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(714, 153);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(75, 23);
            this.bEliminar.TabIndex = 5;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(714, 182);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 6;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // bModificar
            // 
            this.bModificar.Location = new System.Drawing.Point(714, 123);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(75, 23);
            this.bModificar.TabIndex = 8;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(714, 94);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(75, 23);
            this.bAgregar.TabIndex = 7;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
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
            // estatus
            // 
            this.estatus.DataPropertyName = "estatus";
            this.estatus.HeaderText = "Estado";
            this.estatus.Name = "estatus";
            // 
            // municipio
            // 
            this.municipio.DataPropertyName = "municipio";
            this.municipio.HeaderText = "Municipio";
            this.municipio.Name = "municipio";
            // 
            // domicilio
            // 
            this.domicilio.DataPropertyName = "domicilio";
            this.domicilio.HeaderText = "Domicilio";
            this.domicilio.Name = "domicilio";
            // 
            // creacion
            // 
            this.creacion.DataPropertyName = "creacion";
            this.creacion.HeaderText = "Fecha de Creacion";
            this.creacion.Name = "creacion";
            // 
            // modificacion
            // 
            this.modificacion.DataPropertyName = "modificacion";
            this.modificacion.HeaderText = "Fecha de Modificacion";
            this.modificacion.Name = "modificacion";
            // 
            // FormContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 367);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTipoServicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCliente);
            this.Controls.Add(this.dgvContrato);
            this.Name = "FormContratos";
            this.Text = "Contratos";
            this.Load += new System.EventHandler(this.FormContratos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContrato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContrato;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTipoServicio;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroMedidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn creacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn modificacion;
    }
}