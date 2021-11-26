
namespace AAVD
{
    partial class FormEmpleadoPrincipal
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
            this.bClientes = new System.Windows.Forms.Button();
            this.bReportes = new System.Windows.Forms.Button();
            this.bContratos = new System.Windows.Forms.Button();
            this.bConsumos = new System.Windows.Forms.Button();
            this.bZonas = new System.Windows.Forms.Button();
            this.bTarifas = new System.Windows.Forms.Button();
            this.gDatos = new System.Windows.Forms.GroupBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.bCerrar = new System.Windows.Forms.Button();
            this.bConsumoHistorico = new System.Windows.Forms.Button();
            this.bActivar = new System.Windows.Forms.Button();
            this.dgvClientesBaneados = new System.Windows.Forms.DataGridView();
            this.nombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbClientesMorales = new System.Windows.Forms.RadioButton();
            this.rbClientesFisicos = new System.Windows.Forms.RadioButton();
            this.gDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesBaneados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bClientes
            // 
            this.bClientes.Location = new System.Drawing.Point(12, 15);
            this.bClientes.Name = "bClientes";
            this.bClientes.Size = new System.Drawing.Size(100, 50);
            this.bClientes.TabIndex = 2;
            this.bClientes.Text = "Clientes";
            this.bClientes.UseVisualStyleBackColor = true;
            this.bClientes.Click += new System.EventHandler(this.bClientes_Click);
            // 
            // bReportes
            // 
            this.bReportes.Location = new System.Drawing.Point(12, 127);
            this.bReportes.Name = "bReportes";
            this.bReportes.Size = new System.Drawing.Size(100, 50);
            this.bReportes.TabIndex = 3;
            this.bReportes.Text = "Reportes";
            this.bReportes.UseVisualStyleBackColor = true;
            this.bReportes.Click += new System.EventHandler(this.bReportes_Click);
            // 
            // bContratos
            // 
            this.bContratos.Location = new System.Drawing.Point(12, 71);
            this.bContratos.Name = "bContratos";
            this.bContratos.Size = new System.Drawing.Size(100, 50);
            this.bContratos.TabIndex = 5;
            this.bContratos.Text = "Contratos";
            this.bContratos.UseVisualStyleBackColor = true;
            this.bContratos.Click += new System.EventHandler(this.bContratos_Click);
            // 
            // bConsumos
            // 
            this.bConsumos.Location = new System.Drawing.Point(12, 295);
            this.bConsumos.Name = "bConsumos";
            this.bConsumos.Size = new System.Drawing.Size(100, 50);
            this.bConsumos.TabIndex = 4;
            this.bConsumos.Text = "Consumos";
            this.bConsumos.UseVisualStyleBackColor = true;
            this.bConsumos.Click += new System.EventHandler(this.bConsumos_Click);
            // 
            // bZonas
            // 
            this.bZonas.Location = new System.Drawing.Point(12, 239);
            this.bZonas.Name = "bZonas";
            this.bZonas.Size = new System.Drawing.Size(100, 50);
            this.bZonas.TabIndex = 7;
            this.bZonas.Text = "Zonas";
            this.bZonas.UseVisualStyleBackColor = true;
            this.bZonas.Click += new System.EventHandler(this.bZonas_Click);
            // 
            // bTarifas
            // 
            this.bTarifas.Location = new System.Drawing.Point(12, 183);
            this.bTarifas.Name = "bTarifas";
            this.bTarifas.Size = new System.Drawing.Size(100, 50);
            this.bTarifas.TabIndex = 6;
            this.bTarifas.Text = "Tarifas";
            this.bTarifas.UseVisualStyleBackColor = true;
            this.bTarifas.Click += new System.EventHandler(this.bTarifas_Click);
            // 
            // gDatos
            // 
            this.gDatos.Controls.Add(this.lNombre);
            this.gDatos.Controls.Add(this.bCerrar);
            this.gDatos.Location = new System.Drawing.Point(129, 21);
            this.gDatos.Name = "gDatos";
            this.gDatos.Size = new System.Drawing.Size(507, 80);
            this.gDatos.TabIndex = 8;
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
            this.bCerrar.TabIndex = 13;
            this.bCerrar.Text = "Cerrar Sesion";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // bConsumoHistorico
            // 
            this.bConsumoHistorico.Location = new System.Drawing.Point(12, 351);
            this.bConsumoHistorico.Name = "bConsumoHistorico";
            this.bConsumoHistorico.Size = new System.Drawing.Size(100, 50);
            this.bConsumoHistorico.TabIndex = 15;
            this.bConsumoHistorico.Text = "Consumo Historico";
            this.bConsumoHistorico.UseVisualStyleBackColor = true;
            this.bConsumoHistorico.Click += new System.EventHandler(this.bConsumoHistorico_Click);
            // 
            // bActivar
            // 
            this.bActivar.Location = new System.Drawing.Point(561, 225);
            this.bActivar.Name = "bActivar";
            this.bActivar.Size = new System.Drawing.Size(75, 23);
            this.bActivar.TabIndex = 17;
            this.bActivar.Text = "Reactivar";
            this.bActivar.UseVisualStyleBackColor = true;
            this.bActivar.Click += new System.EventHandler(this.bActivar_Click);
            // 
            // dgvClientesBaneados
            // 
            this.dgvClientesBaneados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientesBaneados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreUsuario,
            this.estado});
            this.dgvClientesBaneados.Location = new System.Drawing.Point(129, 225);
            this.dgvClientesBaneados.Name = "dgvClientesBaneados";
            this.dgvClientesBaneados.Size = new System.Drawing.Size(426, 274);
            this.dgvClientesBaneados.TabIndex = 18;
            this.dgvClientesBaneados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientesBaneados_CellClick);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbClientesMorales);
            this.groupBox1.Controls.Add(this.rbClientesFisicos);
            this.groupBox1.Location = new System.Drawing.Point(129, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 67);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // rbClientesMorales
            // 
            this.rbClientesMorales.AutoSize = true;
            this.rbClientesMorales.Location = new System.Drawing.Point(10, 42);
            this.rbClientesMorales.Name = "rbClientesMorales";
            this.rbClientesMorales.Size = new System.Drawing.Size(102, 17);
            this.rbClientesMorales.TabIndex = 21;
            this.rbClientesMorales.Text = "Clientes Morales";
            this.rbClientesMorales.UseVisualStyleBackColor = true;
            this.rbClientesMorales.Click += new System.EventHandler(this.rbClientesMorales_Click);
            // 
            // rbClientesFisicos
            // 
            this.rbClientesFisicos.AutoSize = true;
            this.rbClientesFisicos.Checked = true;
            this.rbClientesFisicos.Location = new System.Drawing.Point(10, 19);
            this.rbClientesFisicos.Name = "rbClientesFisicos";
            this.rbClientesFisicos.Size = new System.Drawing.Size(97, 17);
            this.rbClientesFisicos.TabIndex = 20;
            this.rbClientesFisicos.TabStop = true;
            this.rbClientesFisicos.Text = "Clientes Fisicos";
            this.rbClientesFisicos.UseVisualStyleBackColor = true;
            this.rbClientesFisicos.Click += new System.EventHandler(this.rbClientesFisicos_Click);
            // 
            // FormEmpleadoPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 511);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvClientesBaneados);
            this.Controls.Add(this.bActivar);
            this.Controls.Add(this.bConsumoHistorico);
            this.Controls.Add(this.gDatos);
            this.Controls.Add(this.bZonas);
            this.Controls.Add(this.bTarifas);
            this.Controls.Add(this.bContratos);
            this.Controls.Add(this.bConsumos);
            this.Controls.Add(this.bReportes);
            this.Controls.Add(this.bClientes);
            this.Name = "FormEmpleadoPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado - Home";
            this.Load += new System.EventHandler(this.FormEmpleadoPrincipal_Load);
            this.gDatos.ResumeLayout(false);
            this.gDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesBaneados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bClientes;
        private System.Windows.Forms.Button bReportes;
        private System.Windows.Forms.Button bContratos;
        private System.Windows.Forms.Button bConsumos;
        private System.Windows.Forms.Button bZonas;
        private System.Windows.Forms.Button bTarifas;
        private System.Windows.Forms.GroupBox gDatos;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Button bConsumoHistorico;
        private System.Windows.Forms.Button bActivar;
        private System.Windows.Forms.DataGridView dgvClientesBaneados;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbClientesMorales;
        private System.Windows.Forms.RadioButton rbClientesFisicos;
    }
}