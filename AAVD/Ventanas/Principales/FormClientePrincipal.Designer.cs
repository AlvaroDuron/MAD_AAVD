
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
            this.gDatos = new System.Windows.Forms.GroupBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.bContratos = new System.Windows.Forms.Button();
            this.bReportes = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gDatos
            // 
            this.gDatos.Controls.Add(this.lNombre);
            this.gDatos.Location = new System.Drawing.Point(37, 31);
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
            this.bContratos.Location = new System.Drawing.Point(63, 130);
            this.bContratos.Name = "bContratos";
            this.bContratos.Size = new System.Drawing.Size(100, 50);
            this.bContratos.TabIndex = 11;
            this.bContratos.Text = "Contratos";
            this.bContratos.UseVisualStyleBackColor = true;
            this.bContratos.Click += new System.EventHandler(this.bContratos_Click);
            // 
            // bReportes
            // 
            this.bReportes.Location = new System.Drawing.Point(207, 130);
            this.bReportes.Name = "bReportes";
            this.bReportes.Size = new System.Drawing.Size(100, 50);
            this.bReportes.TabIndex = 10;
            this.bReportes.Text = "Consumo Historico";
            this.bReportes.UseVisualStyleBackColor = true;
            this.bReportes.Click += new System.EventHandler(this.bReportes_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(207, 206);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(100, 50);
            this.bCerrar.TabIndex = 12;
            this.bCerrar.Text = "Cerrar Sesion";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 13;
            this.button1.Text = "Pagar Recibos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormClientePrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 298);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bContratos);
            this.Controls.Add(this.bReportes);
            this.Controls.Add(this.gDatos);
            this.Name = "FormClientePrincipal";
            this.Text = "Cliente - Home";
            this.gDatos.ResumeLayout(false);
            this.gDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gDatos;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Button bContratos;
        private System.Windows.Forms.Button bReportes;
        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Button button1;
    }
}