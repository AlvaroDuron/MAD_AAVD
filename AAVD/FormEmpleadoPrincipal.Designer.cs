﻿
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.bClientes = new System.Windows.Forms.Button();
            this.bReportes = new System.Windows.Forms.Button();
            this.bContratos = new System.Windows.Forms.Button();
            this.bConsumos = new System.Windows.Forms.Button();
            this.bZonas = new System.Windows.Forms.Button();
            this.bTarifas = new System.Windows.Forms.Button();
            this.gDatos = new System.Windows.Forms.GroupBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.bCerrar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mCerrarSesion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mCerrarSesion
            // 
            this.mCerrarSesion.Name = "mCerrarSesion";
            this.mCerrarSesion.Size = new System.Drawing.Size(88, 20);
            this.mCerrarSesion.Text = "Cerrar Sesion";
            // 
            // bClientes
            // 
            this.bClientes.Location = new System.Drawing.Point(44, 200);
            this.bClientes.Name = "bClientes";
            this.bClientes.Size = new System.Drawing.Size(100, 50);
            this.bClientes.TabIndex = 2;
            this.bClientes.Text = "Clientes";
            this.bClientes.UseVisualStyleBackColor = true;
            this.bClientes.Click += new System.EventHandler(this.bClientes_Click);
            // 
            // bReportes
            // 
            this.bReportes.Location = new System.Drawing.Point(187, 200);
            this.bReportes.Name = "bReportes";
            this.bReportes.Size = new System.Drawing.Size(100, 50);
            this.bReportes.TabIndex = 3;
            this.bReportes.Text = "Reportes";
            this.bReportes.UseVisualStyleBackColor = true;
            this.bReportes.Click += new System.EventHandler(this.bReportes_Click);
            // 
            // bContratos
            // 
            this.bContratos.Location = new System.Drawing.Point(187, 285);
            this.bContratos.Name = "bContratos";
            this.bContratos.Size = new System.Drawing.Size(100, 50);
            this.bContratos.TabIndex = 5;
            this.bContratos.Text = "Contratos";
            this.bContratos.UseVisualStyleBackColor = true;
            this.bContratos.Click += new System.EventHandler(this.bContratos_Click);
            // 
            // bConsumos
            // 
            this.bConsumos.Location = new System.Drawing.Point(44, 285);
            this.bConsumos.Name = "bConsumos";
            this.bConsumos.Size = new System.Drawing.Size(100, 50);
            this.bConsumos.TabIndex = 4;
            this.bConsumos.Text = "Consumos";
            this.bConsumos.UseVisualStyleBackColor = true;
            this.bConsumos.Click += new System.EventHandler(this.bConsumos_Click);
            // 
            // bZonas
            // 
            this.bZonas.Location = new System.Drawing.Point(338, 285);
            this.bZonas.Name = "bZonas";
            this.bZonas.Size = new System.Drawing.Size(100, 50);
            this.bZonas.TabIndex = 7;
            this.bZonas.Text = "Zonas";
            this.bZonas.UseVisualStyleBackColor = true;
            this.bZonas.Click += new System.EventHandler(this.bZonas_Click);
            // 
            // bTarifas
            // 
            this.bTarifas.Location = new System.Drawing.Point(338, 200);
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
            this.gDatos.Location = new System.Drawing.Point(44, 44);
            this.gDatos.Name = "gDatos";
            this.gDatos.Size = new System.Drawing.Size(412, 80);
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
            this.bCerrar.Location = new System.Drawing.Point(187, 367);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(100, 50);
            this.bCerrar.TabIndex = 13;
            this.bCerrar.Text = "Cerrar Sesion";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // FormEmpleadoPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 461);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.gDatos);
            this.Controls.Add(this.bZonas);
            this.Controls.Add(this.bTarifas);
            this.Controls.Add(this.bContratos);
            this.Controls.Add(this.bConsumos);
            this.Controls.Add(this.bReportes);
            this.Controls.Add(this.bClientes);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormEmpleadoPrincipal";
            this.Text = "Empleado - Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gDatos.ResumeLayout(false);
            this.gDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mCerrarSesion;
        private System.Windows.Forms.Button bClientes;
        private System.Windows.Forms.Button bReportes;
        private System.Windows.Forms.Button bContratos;
        private System.Windows.Forms.Button bConsumos;
        private System.Windows.Forms.Button bZonas;
        private System.Windows.Forms.Button bTarifas;
        private System.Windows.Forms.GroupBox gDatos;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Button bCerrar;
    }
}