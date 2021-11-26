
namespace AAVD
{
    partial class FormAdministradorPrincipal
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
            this.gDatos = new System.Windows.Forms.GroupBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.bCerrar = new System.Windows.Forms.Button();
            this.bZonas = new System.Windows.Forms.Button();
            this.bTarifas = new System.Windows.Forms.Button();
            this.bContratos = new System.Windows.Forms.Button();
            this.bConsumos = new System.Windows.Forms.Button();
            this.bReportes = new System.Windows.Forms.Button();
            this.bClientes = new System.Windows.Forms.Button();
            this.bEmpleados = new System.Windows.Forms.Button();
            this.bCategorias = new System.Windows.Forms.Button();
            this.bMunicipios = new System.Windows.Forms.Button();
            this.dgvEmpleadosBaneados = new System.Windows.Forms.DataGridView();
            this.nombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bActivar = new System.Windows.Forms.Button();
            this.gDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadosBaneados)).BeginInit();
            this.SuspendLayout();
            // 
            // gDatos
            // 
            this.gDatos.Controls.Add(this.lNombre);
            this.gDatos.Controls.Add(this.bCerrar);
            this.gDatos.Location = new System.Drawing.Point(133, 12);
            this.gDatos.Name = "gDatos";
            this.gDatos.Size = new System.Drawing.Size(507, 80);
            this.gDatos.TabIndex = 9;
            this.gDatos.TabStop = false;
            this.gDatos.Text = "Nombre de Usuario";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(7, 20);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(44, 13);
            this.lNombre.TabIndex = 0;
            this.lNombre.Text = "Nombre";
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(426, 14);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 60);
            this.bCerrar.TabIndex = 10;
            this.bCerrar.Text = "Cerrar Sesion";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // bZonas
            // 
            this.bZonas.Location = new System.Drawing.Point(12, 348);
            this.bZonas.Name = "bZonas";
            this.bZonas.Size = new System.Drawing.Size(100, 50);
            this.bZonas.TabIndex = 6;
            this.bZonas.Text = "Zonas";
            this.bZonas.UseVisualStyleBackColor = true;
            this.bZonas.Click += new System.EventHandler(this.bZonas_Click);
            // 
            // bTarifas
            // 
            this.bTarifas.Location = new System.Drawing.Point(12, 460);
            this.bTarifas.Name = "bTarifas";
            this.bTarifas.Size = new System.Drawing.Size(100, 50);
            this.bTarifas.TabIndex = 8;
            this.bTarifas.Text = "Tarifas";
            this.bTarifas.UseVisualStyleBackColor = true;
            this.bTarifas.Click += new System.EventHandler(this.bTarifas_Click);
            // 
            // bContratos
            // 
            this.bContratos.Location = new System.Drawing.Point(12, 124);
            this.bContratos.Name = "bContratos";
            this.bContratos.Size = new System.Drawing.Size(100, 50);
            this.bContratos.TabIndex = 3;
            this.bContratos.Text = "Contratos";
            this.bContratos.UseVisualStyleBackColor = true;
            this.bContratos.Click += new System.EventHandler(this.bContratos_Click);
            // 
            // bConsumos
            // 
            this.bConsumos.Location = new System.Drawing.Point(12, 292);
            this.bConsumos.Name = "bConsumos";
            this.bConsumos.Size = new System.Drawing.Size(100, 50);
            this.bConsumos.TabIndex = 5;
            this.bConsumos.Text = "Consumos";
            this.bConsumos.UseVisualStyleBackColor = true;
            this.bConsumos.Click += new System.EventHandler(this.bConsumos_Click);
            // 
            // bReportes
            // 
            this.bReportes.Location = new System.Drawing.Point(12, 180);
            this.bReportes.Name = "bReportes";
            this.bReportes.Size = new System.Drawing.Size(100, 50);
            this.bReportes.TabIndex = 9;
            this.bReportes.Text = "Reportes";
            this.bReportes.UseVisualStyleBackColor = true;
            this.bReportes.Click += new System.EventHandler(this.bReportes_Click);
            // 
            // bClientes
            // 
            this.bClientes.Location = new System.Drawing.Point(12, 68);
            this.bClientes.Name = "bClientes";
            this.bClientes.Size = new System.Drawing.Size(100, 50);
            this.bClientes.TabIndex = 2;
            this.bClientes.Text = "Clientes";
            this.bClientes.UseVisualStyleBackColor = true;
            this.bClientes.Click += new System.EventHandler(this.bClientes_Click);
            // 
            // bEmpleados
            // 
            this.bEmpleados.Location = new System.Drawing.Point(12, 12);
            this.bEmpleados.Name = "bEmpleados";
            this.bEmpleados.Size = new System.Drawing.Size(100, 50);
            this.bEmpleados.TabIndex = 1;
            this.bEmpleados.Text = "Empleados";
            this.bEmpleados.UseVisualStyleBackColor = true;
            this.bEmpleados.Click += new System.EventHandler(this.bEmpleados_Click);
            // 
            // bCategorias
            // 
            this.bCategorias.Location = new System.Drawing.Point(12, 236);
            this.bCategorias.Name = "bCategorias";
            this.bCategorias.Size = new System.Drawing.Size(100, 50);
            this.bCategorias.TabIndex = 4;
            this.bCategorias.Text = "Categorias";
            this.bCategorias.UseVisualStyleBackColor = true;
            this.bCategorias.Click += new System.EventHandler(this.bCategorias_Click);
            // 
            // bMunicipios
            // 
            this.bMunicipios.Location = new System.Drawing.Point(12, 404);
            this.bMunicipios.Name = "bMunicipios";
            this.bMunicipios.Size = new System.Drawing.Size(100, 50);
            this.bMunicipios.TabIndex = 11;
            this.bMunicipios.Text = "Municipios";
            this.bMunicipios.UseVisualStyleBackColor = true;
            this.bMunicipios.Click += new System.EventHandler(this.bMunicipios_Click);
            // 
            // dgvEmpleadosBaneados
            // 
            this.dgvEmpleadosBaneados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleadosBaneados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreUsuario,
            this.estado});
            this.dgvEmpleadosBaneados.Location = new System.Drawing.Point(133, 236);
            this.dgvEmpleadosBaneados.Name = "dgvEmpleadosBaneados";
            this.dgvEmpleadosBaneados.Size = new System.Drawing.Size(426, 274);
            this.dgvEmpleadosBaneados.TabIndex = 20;
            this.dgvEmpleadosBaneados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleadosBaneados_CellClick);
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.DataPropertyName = "nombreUsuario";
            this.nombreUsuario.HeaderText = "Nombre de Usuario";
            this.nombreUsuario.Name = "nombreUsuario";
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // bActivar
            // 
            this.bActivar.Location = new System.Drawing.Point(565, 236);
            this.bActivar.Name = "bActivar";
            this.bActivar.Size = new System.Drawing.Size(75, 23);
            this.bActivar.TabIndex = 19;
            this.bActivar.Text = "Reactivar";
            this.bActivar.UseVisualStyleBackColor = true;
            this.bActivar.Click += new System.EventHandler(this.bActivar_Click);
            // 
            // FormAdministradorPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 532);
            this.Controls.Add(this.dgvEmpleadosBaneados);
            this.Controls.Add(this.bActivar);
            this.Controls.Add(this.bMunicipios);
            this.Controls.Add(this.bCategorias);
            this.Controls.Add(this.bEmpleados);
            this.Controls.Add(this.bZonas);
            this.Controls.Add(this.gDatos);
            this.Controls.Add(this.bTarifas);
            this.Controls.Add(this.bContratos);
            this.Controls.Add(this.bConsumos);
            this.Controls.Add(this.bClientes);
            this.Controls.Add(this.bReportes);
            this.Name = "FormAdministradorPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador - Home";
            this.Load += new System.EventHandler(this.FormAdministradorPrincipal_Load);
            this.gDatos.ResumeLayout(false);
            this.gDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadosBaneados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gDatos;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Button bZonas;
        private System.Windows.Forms.Button bTarifas;
        private System.Windows.Forms.Button bContratos;
        private System.Windows.Forms.Button bConsumos;
        private System.Windows.Forms.Button bReportes;
        private System.Windows.Forms.Button bClientes;
        private System.Windows.Forms.Button bEmpleados;
        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Button bCategorias;
        private System.Windows.Forms.Button bMunicipios;
        private System.Windows.Forms.DataGridView dgvEmpleadosBaneados;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Button bActivar;
    }
}