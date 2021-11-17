
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.mReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.mRecibos = new System.Windows.Forms.ToolStripMenuItem();
            this.mTarifas = new System.Windows.Forms.ToolStripMenuItem();
            this.mConsumos = new System.Windows.Forms.ToolStripMenuItem();
            this.mContratos = new System.Windows.Forms.ToolStripMenuItem();
            this.gDatos = new System.Windows.Forms.GroupBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.bZonas = new System.Windows.Forms.Button();
            this.bTarifas = new System.Windows.Forms.Button();
            this.bContratos = new System.Windows.Forms.Button();
            this.bConsumos = new System.Windows.Forms.Button();
            this.bReportes = new System.Windows.Forms.Button();
            this.bClientes = new System.Windows.Forms.Button();
            this.bEmpleados = new System.Windows.Forms.Button();
            this.bParametros = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mClientes,
            this.mEmpleados,
            this.mReportes,
            this.mRecibos,
            this.mTarifas,
            this.mConsumos,
            this.mContratos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mClientes
            // 
            this.mClientes.Name = "mClientes";
            this.mClientes.Size = new System.Drawing.Size(61, 20);
            this.mClientes.Text = "Clientes";
            // 
            // mEmpleados
            // 
            this.mEmpleados.Name = "mEmpleados";
            this.mEmpleados.Size = new System.Drawing.Size(77, 20);
            this.mEmpleados.Text = "Empleados";
            // 
            // mReportes
            // 
            this.mReportes.Name = "mReportes";
            this.mReportes.Size = new System.Drawing.Size(65, 20);
            this.mReportes.Text = "Reportes";
            // 
            // mRecibos
            // 
            this.mRecibos.Name = "mRecibos";
            this.mRecibos.Size = new System.Drawing.Size(60, 20);
            this.mRecibos.Text = "Recibos";
            // 
            // mTarifas
            // 
            this.mTarifas.Name = "mTarifas";
            this.mTarifas.Size = new System.Drawing.Size(52, 20);
            this.mTarifas.Text = "Tarifas";
            // 
            // mConsumos
            // 
            this.mConsumos.Name = "mConsumos";
            this.mConsumos.Size = new System.Drawing.Size(76, 20);
            this.mConsumos.Text = "Consumos";
            // 
            // mContratos
            // 
            this.mContratos.Name = "mContratos";
            this.mContratos.Size = new System.Drawing.Size(71, 20);
            this.mContratos.Text = "Contratos";
            // 
            // gDatos
            // 
            this.gDatos.Controls.Add(this.lNombre);
            this.gDatos.Location = new System.Drawing.Point(47, 58);
            this.gDatos.Name = "gDatos";
            this.gDatos.Size = new System.Drawing.Size(412, 80);
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
            // bZonas
            // 
            this.bZonas.Location = new System.Drawing.Point(348, 262);
            this.bZonas.Name = "bZonas";
            this.bZonas.Size = new System.Drawing.Size(100, 50);
            this.bZonas.TabIndex = 13;
            this.bZonas.Text = "Zonas";
            this.bZonas.UseVisualStyleBackColor = true;
            this.bZonas.Click += new System.EventHandler(this.bZonas_Click);
            // 
            // bTarifas
            // 
            this.bTarifas.Location = new System.Drawing.Point(348, 177);
            this.bTarifas.Name = "bTarifas";
            this.bTarifas.Size = new System.Drawing.Size(100, 50);
            this.bTarifas.TabIndex = 12;
            this.bTarifas.Text = "Tarifas";
            this.bTarifas.UseVisualStyleBackColor = true;
            this.bTarifas.Click += new System.EventHandler(this.bTarifas_Click);
            // 
            // bContratos
            // 
            this.bContratos.Location = new System.Drawing.Point(197, 262);
            this.bContratos.Name = "bContratos";
            this.bContratos.Size = new System.Drawing.Size(100, 50);
            this.bContratos.TabIndex = 11;
            this.bContratos.Text = "Contratos";
            this.bContratos.UseVisualStyleBackColor = true;
            this.bContratos.Click += new System.EventHandler(this.bContratos_Click);
            // 
            // bConsumos
            // 
            this.bConsumos.Location = new System.Drawing.Point(54, 262);
            this.bConsumos.Name = "bConsumos";
            this.bConsumos.Size = new System.Drawing.Size(100, 50);
            this.bConsumos.TabIndex = 10;
            this.bConsumos.Text = "Consumos";
            this.bConsumos.UseVisualStyleBackColor = true;
            this.bConsumos.Click += new System.EventHandler(this.bConsumos_Click);
            // 
            // bReportes
            // 
            this.bReportes.Location = new System.Drawing.Point(197, 177);
            this.bReportes.Name = "bReportes";
            this.bReportes.Size = new System.Drawing.Size(100, 50);
            this.bReportes.TabIndex = 9;
            this.bReportes.Text = "Reportes";
            this.bReportes.UseVisualStyleBackColor = true;
            this.bReportes.Click += new System.EventHandler(this.bReportes_Click);
            // 
            // bClientes
            // 
            this.bClientes.Location = new System.Drawing.Point(54, 177);
            this.bClientes.Name = "bClientes";
            this.bClientes.Size = new System.Drawing.Size(100, 50);
            this.bClientes.TabIndex = 8;
            this.bClientes.Text = "Clientes";
            this.bClientes.UseVisualStyleBackColor = true;
            this.bClientes.Click += new System.EventHandler(this.bClientes_Click);
            // 
            // bEmpleados
            // 
            this.bEmpleados.Location = new System.Drawing.Point(197, 342);
            this.bEmpleados.Name = "bEmpleados";
            this.bEmpleados.Size = new System.Drawing.Size(100, 50);
            this.bEmpleados.TabIndex = 14;
            this.bEmpleados.Text = "Empleados";
            this.bEmpleados.UseVisualStyleBackColor = true;
            this.bEmpleados.Click += new System.EventHandler(this.bEmpleados_Click);
            // 
            // bParametros
            // 
            this.bParametros.Location = new System.Drawing.Point(57, 342);
            this.bParametros.Name = "bParametros";
            this.bParametros.Size = new System.Drawing.Size(100, 50);
            this.bParametros.TabIndex = 15;
            this.bParametros.Text = "Parametros";
            this.bParametros.UseVisualStyleBackColor = true;
            this.bParametros.Click += new System.EventHandler(this.bParametros_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(348, 342);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(100, 50);
            this.bCerrar.TabIndex = 16;
            this.bCerrar.Text = "Cerrar Sesion";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // FormAdministradorPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 461);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bParametros);
            this.Controls.Add(this.bEmpleados);
            this.Controls.Add(this.bZonas);
            this.Controls.Add(this.gDatos);
            this.Controls.Add(this.bTarifas);
            this.Controls.Add(this.bContratos);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.bConsumos);
            this.Controls.Add(this.bClientes);
            this.Controls.Add(this.bReportes);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAdministradorPrincipal";
            this.Text = "Administrador - Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gDatos.ResumeLayout(false);
            this.gDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mClientes;
        private System.Windows.Forms.ToolStripMenuItem mEmpleados;
        private System.Windows.Forms.ToolStripMenuItem mReportes;
        private System.Windows.Forms.ToolStripMenuItem mRecibos;
        private System.Windows.Forms.ToolStripMenuItem mTarifas;
        private System.Windows.Forms.ToolStripMenuItem mConsumos;
        private System.Windows.Forms.ToolStripMenuItem mContratos;
        private System.Windows.Forms.GroupBox gDatos;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Button bZonas;
        private System.Windows.Forms.Button bTarifas;
        private System.Windows.Forms.Button bContratos;
        private System.Windows.Forms.Button bConsumos;
        private System.Windows.Forms.Button bReportes;
        private System.Windows.Forms.Button bClientes;
        private System.Windows.Forms.Button bEmpleados;
        private System.Windows.Forms.Button bParametros;
        private System.Windows.Forms.Button bCerrar;
    }
}