
namespace AAVD
{
    partial class FormClientePrincipal
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
            this.mReporte = new System.Windows.Forms.ToolStripMenuItem();
            this.mContratos = new System.Windows.Forms.ToolStripMenuItem();
            this.mCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.gDatos = new System.Windows.Forms.GroupBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.bContratos = new System.Windows.Forms.Button();
            this.bReportes = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mReporte,
            this.mContratos,
            this.mCerrarSesion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mReporte
            // 
            this.mReporte.Name = "mReporte";
            this.mReporte.Size = new System.Drawing.Size(111, 20);
            this.mReporte.Text = "Reporte Historico";
            // 
            // mContratos
            // 
            this.mContratos.Name = "mContratos";
            this.mContratos.Size = new System.Drawing.Size(71, 20);
            this.mContratos.Text = "Contratos";
            // 
            // mCerrarSesion
            // 
            this.mCerrarSesion.Name = "mCerrarSesion";
            this.mCerrarSesion.Size = new System.Drawing.Size(88, 20);
            this.mCerrarSesion.Text = "Cerrar Sesion";
            // 
            // gDatos
            // 
            this.gDatos.Controls.Add(this.lNombre);
            this.gDatos.Location = new System.Drawing.Point(47, 64);
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
            // bContratos
            // 
            this.bContratos.Location = new System.Drawing.Point(73, 163);
            this.bContratos.Name = "bContratos";
            this.bContratos.Size = new System.Drawing.Size(100, 50);
            this.bContratos.TabIndex = 11;
            this.bContratos.Text = "Contratos";
            this.bContratos.UseVisualStyleBackColor = true;
            this.bContratos.Click += new System.EventHandler(this.bContratos_Click);
            // 
            // bReportes
            // 
            this.bReportes.Location = new System.Drawing.Point(217, 163);
            this.bReportes.Name = "bReportes";
            this.bReportes.Size = new System.Drawing.Size(100, 50);
            this.bReportes.TabIndex = 10;
            this.bReportes.Text = "Reporte Historico";
            this.bReportes.UseVisualStyleBackColor = true;
            this.bReportes.Click += new System.EventHandler(this.bReportes_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(359, 163);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(100, 50);
            this.bCerrar.TabIndex = 12;
            this.bCerrar.Text = "Cerrar Sesion";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // FormClientePrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 461);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bContratos);
            this.Controls.Add(this.bReportes);
            this.Controls.Add(this.gDatos);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormClientePrincipal";
            this.Text = "Cliente - Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gDatos.ResumeLayout(false);
            this.gDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mReporte;
        private System.Windows.Forms.ToolStripMenuItem mContratos;
        private System.Windows.Forms.ToolStripMenuItem mCerrarSesion;
        private System.Windows.Forms.GroupBox gDatos;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Button bContratos;
        private System.Windows.Forms.Button bReportes;
        private System.Windows.Forms.Button bCerrar;
    }
}