
namespace AAVD
{
    partial class FormCliente
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
            this.dgvClienteFisico = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregarFisico = new System.Windows.Forms.Button();
            this.btnAgregarMoral = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbClientesMorales = new System.Windows.Forms.RadioButton();
            this.rbClientesFisicos = new System.Windows.Forms.RadioButton();
            this.curp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rfc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constitucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAltaMod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteFisico)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClienteFisico
            // 
            this.dgvClienteFisico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClienteFisico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.curp,
            this.rfc,
            this.nombreUsuario,
            this.nombre,
            this.apellidoPaterno,
            this.apellidoMaterno,
            this.nacimiento,
            this.constitucion,
            this.genero,
            this.email,
            this.fechaAltaMod});
            this.dgvClienteFisico.Location = new System.Drawing.Point(12, 114);
            this.dgvClienteFisico.Name = "dgvClienteFisico";
            this.dgvClienteFisico.Size = new System.Drawing.Size(748, 244);
            this.dgvClienteFisico.TabIndex = 0;
            this.dgvClienteFisico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClienteFisico_CellClick);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(778, 202);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(130, 23);
            this.btnRegresar.TabIndex = 20;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(778, 173);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 23);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(778, 144);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(130, 23);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregarFisico
            // 
            this.btnAgregarFisico.Location = new System.Drawing.Point(777, 85);
            this.btnAgregarFisico.Name = "btnAgregarFisico";
            this.btnAgregarFisico.Size = new System.Drawing.Size(131, 23);
            this.btnAgregarFisico.TabIndex = 17;
            this.btnAgregarFisico.Text = "Agregar Cliente Fisico";
            this.btnAgregarFisico.UseVisualStyleBackColor = true;
            this.btnAgregarFisico.Click += new System.EventHandler(this.btnAgregarFisico_Click);
            // 
            // btnAgregarMoral
            // 
            this.btnAgregarMoral.Location = new System.Drawing.Point(777, 114);
            this.btnAgregarMoral.Name = "btnAgregarMoral";
            this.btnAgregarMoral.Size = new System.Drawing.Size(131, 23);
            this.btnAgregarMoral.TabIndex = 21;
            this.btnAgregarMoral.Text = "Agregar Cliente Moral";
            this.btnAgregarMoral.UseVisualStyleBackColor = true;
            this.btnAgregarMoral.Click += new System.EventHandler(this.btnAgregarMoral_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbClientesMorales);
            this.groupBox1.Controls.Add(this.rbClientesFisicos);
            this.groupBox1.Location = new System.Drawing.Point(411, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 58);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // rbClientesMorales
            // 
            this.rbClientesMorales.AutoSize = true;
            this.rbClientesMorales.Location = new System.Drawing.Point(181, 35);
            this.rbClientesMorales.Name = "rbClientesMorales";
            this.rbClientesMorales.Size = new System.Drawing.Size(102, 17);
            this.rbClientesMorales.TabIndex = 1;
            this.rbClientesMorales.Text = "Clientes Morales";
            this.rbClientesMorales.UseVisualStyleBackColor = true;
            this.rbClientesMorales.Click += new System.EventHandler(this.rbClientesMorales_Click);
            // 
            // rbClientesFisicos
            // 
            this.rbClientesFisicos.AutoSize = true;
            this.rbClientesFisicos.Checked = true;
            this.rbClientesFisicos.Location = new System.Drawing.Point(78, 35);
            this.rbClientesFisicos.Name = "rbClientesFisicos";
            this.rbClientesFisicos.Size = new System.Drawing.Size(97, 17);
            this.rbClientesFisicos.TabIndex = 0;
            this.rbClientesFisicos.TabStop = true;
            this.rbClientesFisicos.Text = "Clientes Fisicos";
            this.rbClientesFisicos.UseVisualStyleBackColor = true;
            this.rbClientesFisicos.Click += new System.EventHandler(this.rbClientesFisicos_Click);
            // 
            // curp
            // 
            this.curp.DataPropertyName = "curp";
            this.curp.HeaderText = "CURP";
            this.curp.Name = "curp";
            // 
            // rfc
            // 
            this.rfc.DataPropertyName = "rfc";
            this.rfc.HeaderText = "RFC";
            this.rfc.Name = "rfc";
            this.rfc.Visible = false;
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.DataPropertyName = "nombreUsuario";
            this.nombreUsuario.HeaderText = "Nombre de Usuario";
            this.nombreUsuario.Name = "nombreUsuario";
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // apellidoPaterno
            // 
            this.apellidoPaterno.DataPropertyName = "apellidoPaterno";
            this.apellidoPaterno.HeaderText = "Apellido Paterno";
            this.apellidoPaterno.Name = "apellidoPaterno";
            // 
            // apellidoMaterno
            // 
            this.apellidoMaterno.DataPropertyName = "apellidoMaterno";
            this.apellidoMaterno.HeaderText = "Apellido Materno";
            this.apellidoMaterno.Name = "apellidoMaterno";
            // 
            // nacimiento
            // 
            this.nacimiento.DataPropertyName = "nacimiento";
            this.nacimiento.HeaderText = "Fecha de Nacimiento";
            this.nacimiento.Name = "nacimiento";
            // 
            // constitucion
            // 
            this.constitucion.DataPropertyName = "constitucion";
            this.constitucion.HeaderText = "Fecha de Constitucion";
            this.constitucion.Name = "constitucion";
            this.constitucion.Visible = false;
            // 
            // genero
            // 
            this.genero.DataPropertyName = "genero";
            this.genero.HeaderText = "Género";
            this.genero.Name = "genero";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Correo Electrónico";
            this.email.Name = "email";
            // 
            // fechaAltaMod
            // 
            this.fechaAltaMod.DataPropertyName = "fechaAltaMod";
            this.fechaAltaMod.HeaderText = "Fecha de Modificacion";
            this.fechaAltaMod.Name = "fechaAltaMod";
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 415);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgregarMoral);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregarFisico);
            this.Controls.Add(this.dgvClienteFisico);
            this.Name = "FormCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteFisico)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClienteFisico;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregarFisico;
        private System.Windows.Forms.Button btnAgregarMoral;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbClientesMorales;
        private System.Windows.Forms.RadioButton rbClientesFisicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn curp;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn constitucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAltaMod;
    }
}