
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
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregarFisico = new System.Windows.Forms.Button();
            this.btnAgregarMoral = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteFisico)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClienteFisico
            // 
            this.dgvClienteFisico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClienteFisico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliente,
            this.nombre,
            this.email,
            this.curp,
            this.nacimiento,
            this.genero,
            this.modificacion});
            this.dgvClienteFisico.Location = new System.Drawing.Point(12, 114);
            this.dgvClienteFisico.Name = "dgvClienteFisico";
            this.dgvClienteFisico.Size = new System.Drawing.Size(748, 244);
            this.dgvClienteFisico.TabIndex = 0;
            // 
            // idCliente
            // 
            this.idCliente.HeaderText = "ID";
            this.idCliente.Name = "idCliente";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // email
            // 
            this.email.HeaderText = "Correo Electrónico";
            this.email.Name = "email";
            // 
            // curp
            // 
            this.curp.HeaderText = "CURP";
            this.curp.Name = "curp";
            // 
            // nacimiento
            // 
            this.nacimiento.HeaderText = "Fecha de Nacimiento";
            this.nacimiento.Name = "nacimiento";
            // 
            // genero
            // 
            this.genero.HeaderText = "Género";
            this.genero.Name = "genero";
            // 
            // modificacion
            // 
            this.modificacion.HeaderText = "Fecha de Modificacion";
            this.modificacion.Name = "modificacion";
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
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 384);
            this.Controls.Add(this.btnAgregarMoral);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregarFisico);
            this.Controls.Add(this.dgvClienteFisico);
            this.Name = "FormCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteFisico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClienteFisico;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn curp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn modificacion;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregarFisico;
        private System.Windows.Forms.Button btnAgregarMoral;
    }
}